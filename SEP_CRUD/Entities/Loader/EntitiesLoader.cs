using SEP_CRUD.Generator.Base;
using SEP_CRUD.Helper.NameConvention;
using SEP_CRUD.Template.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Entities.Loader
{
    public class EntitiesLoader : DatabaseLoader
    {
        private static EntitiesLoader sInstance = null;
        public static EntitiesLoader Instance
        {
            get
            {
                if (sInstance == null)
                {
                    sInstance = new EntitiesLoader();
                }
                return sInstance;
            }
        }

        public static void Dispose()
        {
            if (sInstance != null) sInstance.Destroy();
            sInstance = null;
        }

        private List<Table> LoadAllTables()
        {
            List<Table> tables = new List<Table>();
            // Load All Tables
            List<string> tableNames = LoadTableNames();
            int n = tableNames.Count;

            Table table;
            for (int i = 0; i < n; i++)
            {
                table = new Table();
                table.DatabaseName = tableNames[i];
                table.BindingName = Convention.Normalize(tableNames[i]);
                tables.Add(table);
            }
            return tables;
        }

        private List<Column> LoadAllColumns(List<Table> tables)
        {
            List<Column> columns = new List<Column>();
            // Load All Columns
            int n = tables.Count;
            Table table;
            Column column;

            for (int i = 0; i < n; i++)
            {
                table = tables[i];
                table.Clear();
                table.PrimaryKey.Clear();
                using (SqlDataReader reader = LoadCommand(Constant.LoadTableInfoSqlQuery(table.DatabaseName)).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        column = new Column();
                        try
                        {
                            column.TableId = table.Id;
                            column.DatabaseName = reader.GetString(0);
                            column.BindingName = Convention.Normalize(column.DatabaseName);
                            column.DatabaseType = reader.GetString(1);
                            column.BindingType = TypeBinder.Instance.BindType(column.DatabaseType);

                            column.Nullable = reader.GetBoolean(6);
                            column.IsPrimaryKey = (!reader.IsDBNull(7)) ? reader.GetBoolean(7) : false;

                        }
                        catch (Exception)
                        {
                            column.DatabaseName = "";
                        }

                        if (column.DatabaseName != "")
                        {
                            columns.Add(column);
                            table.Add(column);
                            if (column.IsPrimaryKey)
                                table.PrimaryKey.Add(column);
                        }
                    }
                }

            }
            return columns;
        }

        private Column FindColumnByNameAndTableId(List<Column> columns, int tableId, string columnName)
        {
            foreach(Column c in columns) {
                if (c.TableId == tableId && c.DatabaseName.Equals(columnName)) return c;
            }
            return null;
        }

        private Table FindTableByName(List<Table> tables, string name)
        {
            foreach(Table t in tables)
            {
                if (t.DatabaseName.Equals(name)) return t;
            }
            return null;
        }

        private ForeignKey FindForeignKeyByName(List<ForeignKey> list, string name)
        {
            foreach(ForeignKey f in list)
            {
                if (f.DatabaseName.Equals(name)) return f;
            }
            return null;
        }

        private List<ForeignKey> LoadAllForeignKeys(List<Table> tables, List<Column> columns)
        {
            List<ForeignKey> list = new List<ForeignKey>();
            ForeignKey key;
            Table srcTable, destTable;
            Column srcColumn, destColumn;
            using (SqlDataReader reader = LoadCommand(Constant.LoadForeignKeySqlQuery).ExecuteReader())
            {
                while (reader.Read())
                {
                    key = new ForeignKey();
                    try
                    {
                        key.DatabaseName = reader.GetString(0);
                        key.BindingName = Convention.Normalize(key.DatabaseName);
                        srcTable = FindTableByName(tables, reader.GetString(2));
                        if (srcTable == null) continue;

                        srcColumn = FindColumnByNameAndTableId(columns, srcTable.Id, reader.GetString(3));
                        if (srcColumn == null) continue;

                        destTable = FindTableByName(tables, reader.GetString(4));
                        if (destTable == null) continue;

                        destColumn = FindColumnByNameAndTableId(columns, destTable.Id, reader.GetString(5));
                        if (destColumn == null) continue;

                        srcColumn.ForeignKey = key;
                        key.Add(srcColumn, destColumn);
                        list.Add(key);
                    }
                    catch (Exception) {}
                }
            }
            return list;
        }

        private NameConvention Convention;

        public Result LoadData(Entities entities)
        {
            Result result = CheckValid();
            if (!result.OK) return result;
            Convention = entities.NameConvention;

            // Set DatabaseName & BindingName
            entities.DatabaseName = DatabaseName;
            entities.BindingName = Convention.Normalize(DatabaseName);

            // Clear all data
            entities.Clear();

            List<Table> tables = LoadAllTables();
            List<Column> columns = LoadAllColumns(tables);
            List<ForeignKey> foreignKeys = LoadAllForeignKeys(tables, columns);

            foreach (var t in tables)
            {
                entities.Add(t);
                entities.Add(t.PrimaryKey);
            }
            foreach (var c in columns)
                entities.Add(c);
            foreach (var f in foreignKeys)
                entities.Add(f);
            Convention = null;
            return Result.Create(true);
        }
    }
}

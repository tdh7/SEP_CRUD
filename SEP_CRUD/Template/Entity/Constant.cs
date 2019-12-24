namespace SEP_CRUD.Template.Entity
{
    public class Constant
    {
        public const string LoadTablesSqlQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

        public static string LoadTableInfoSqlQuery(string tableName)
        {
            return @"SELECT c.name, t.name, t.name +
   CASE WHEN t.name IN ('char', 'varchar','nchar','nvarchar') THEN '('+

             CASE WHEN c.max_length=-1 THEN 'MAX'

                  ELSE CONVERT(VARCHAR(4),

                               CASE WHEN t.name IN ('nchar','nvarchar')

                               THEN  c.max_length/2 ELSE c.max_length END )

                  END +')'

          WHEN t.name IN ('decimal','numeric')

                  THEN '('+ CONVERT(VARCHAR(4),c.precision)+','

                          + CONVERT(VARCHAR(4),c.Scale)+')'

                  ELSE '' END as ""DDL name"",

   c.max_length,
   c.precision ,
   c.scale ,
   c.is_nullable,
   ISNULL(i.is_primary_key, 0)
FROM
   sys.columns c
INNER JOIN
   sys.types t ON c.user_type_id = t.user_type_id
LEFT OUTER JOIN
   sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
LEFT OUTER JOIN
   sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
WHERE
   c.object_id = OBJECT_ID('" + tableName + "')";
        }
        public const string LoadForeignKeySqlQuery =
            @"SELECT  obj.name AS FK_NAME,
    sch.name AS [schema_name],
    tab1.name AS [table],
    col1.name AS [column],
    tab2.name AS [referenced_table],
    col2.name AS [referenced_column]
FROM sys.foreign_key_columns fkc
INNER JOIN sys.objects obj
    ON obj.object_id = fkc.constraint_object_id
INNER JOIN sys.tables tab1
    ON tab1.object_id = fkc.parent_object_id
INNER JOIN sys.schemas sch
    ON tab1.schema_id = sch.schema_id
INNER JOIN sys.columns col1
    ON col1.column_id = parent_column_id AND col1.object_id = tab1.object_id
INNER JOIN sys.tables tab2
    ON tab2.object_id = fkc.referenced_object_id
INNER JOIN sys.columns col2
    ON col2.column_id = referenced_column_id AND col2.object_id = tab2.object_id
";
        public static string LoadForeignKeyTableSqlQuery(string tableName)
        {
            return LoadForeignKeySqlQuery + "where tab1.name = '" + tableName + "'";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Generator.Base
{
    public class Result
    {
        public static Result Create(string message)
        {
            return new Result(message);
        }

        public static Result Create(bool ok, String message)
        {
            return new Result(ok, message);
        }

        public static Result Create(bool ok)
        {
            return new Result(ok);
        }

        private Result(bool ok)
        {
            this.result = ok;
            this.message = "";
        }

        private Result(bool ok, string message)
        {
            this.result = ok;
            if (message == null) this.message = "";
            else
            this.message = message;
        }

        private Result(string message)
        {
            if(message==null||message.Length==0)
            {
                this.result = true;
                this.message = "";
            } else
            {
                this.result = false;
                this.message = message;
            }
        }

        readonly bool result;

        public bool GetResult()
        {
            return result;
        }

        readonly string message;
        public string GetMessage()
        {
            return message;
        }
    }
}

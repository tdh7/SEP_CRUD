﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SEP_CRUD.Template.Entity
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Entity\ResultTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ResultTemplate : ClassTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Syste" +
                    "m.Text;\r\n\r\nnamespace ");
            
            #line 11 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Entity\ResultTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_namespace));
            
            #line default
            #line hidden
            this.Write(@"
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
            this.message = """";
        }

        private Result(bool ok, string message)
        {
            this.result = ok;
            if (message == null) this.message = """";
            else
            this.message = message;
        }

        private Result(string message)
        {
            if(message==null||message.Length==0)
            {
                this.result = true;
                this.message = """";
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

        public bool OK
        {
            get { return GetResult(); }
        }

        readonly string message;
        public string Message
        {
            get
            {
                return message;
            }
        }
    }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
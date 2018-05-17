﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Entities.Interop.EntityFramework.Templates.IdentityGenerator
{
    using Intent.MetaModel.Domain;
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Entities.Interop.EntityFramework\Templates\IdentityGenerator\IdentityGeneratorTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class IdentityGeneratorTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 13 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Entities.Interop.EntityFramework\Templates\IdentityGenerator\IdentityGeneratorTemplate.tt"




            
            #line default
            #line hidden
            this.Write("using System;\r\n");
            
            #line 18 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Entities.Interop.EntityFramework\Templates\IdentityGenerator\IdentityGeneratorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)] \r\n\r\nnamespace ");
            
            #line 22 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Entities.Interop.EntityFramework\Templates\IdentityGenerator\IdentityGeneratorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public static class ");
            
            #line 24 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Entities.Interop.EntityFramework\Templates\IdentityGenerator\IdentityGeneratorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        private static readonly long EpochMilliseconds = new DateTime(19" +
                    "70, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks / 10000L;\r\n        /// <summary>\r\n   " +
                    "     /// Creates a sequential GUID according to SQL Server\'s ordering rules.\r\n  " +
                    "      /// </summary>\r\n        public static Guid NewSequentialId()\r\n        {\r\n " +
                    "           // This code was not reviewed to guarantee uniqueness under most cond" +
                    "itions, nor completely optimize for avoiding\r\n            // page splits in SQL " +
                    "Server when doing inserts from multiple hosts, so do not re-use in production sy" +
                    "stems.\r\n            var guidBytes = Guid.NewGuid().ToByteArray();\r\n\r\n           " +
                    " // get the milliseconds since Jan 1 1970\r\n            byte[] sequential = BitCo" +
                    "nverter.GetBytes((DateTime.Now.Ticks / 10000L) - EpochMilliseconds);\r\n\r\n        " +
                    "    // discard the 2 most significant bytes, as we only care about the milliseco" +
                    "nds increasing, but the highest ones \r\n            // should be 0 for several th" +
                    "ousand years to come (non-issue).\r\n            if (BitConverter.IsLittleEndian)\r" +
                    "\n            {\r\n                guidBytes[10] = sequential[5];\r\n                " +
                    "guidBytes[11] = sequential[4];\r\n                guidBytes[12] = sequential[3];\r\n" +
                    "                guidBytes[13] = sequential[2];\r\n                guidBytes[14] = " +
                    "sequential[1];\r\n                guidBytes[15] = sequential[0];\r\n            }\r\n " +
                    "           else\r\n            {\r\n                Buffer.BlockCopy(sequential, 2, " +
                    "guidBytes, 10, 6);\r\n            }\r\n\r\n            return new Guid(guidBytes);\r\n  " +
                    "      }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
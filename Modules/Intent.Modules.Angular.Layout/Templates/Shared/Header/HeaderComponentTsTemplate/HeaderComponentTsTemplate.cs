// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Angular.Layout.Templates.Shared.Header.HeaderComponentTsTemplate
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.TypeScript.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentTsTemplate\HeaderComponentTsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class HeaderComponentTsTemplate : TypeScriptTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("import { Component } from \'@angular/core\';\r\n\r\n@IntentMerge\r\n@Component({\r\n  selec" +
                    "tor: \'app-layout-header\',\r\n  templateUrl: \'./header.component.html\',\r\n  styleUrl" +
                    "s: [\'./header.component.css\']\r\n})\r\nexport class ");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentTsTemplate\HeaderComponentTsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" {\r\n  title = \'");
            
            #line 18 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentTsTemplate\HeaderComponentTsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Project.Application.Name));
            
            #line default
            #line hidden
            this.Write("\';\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

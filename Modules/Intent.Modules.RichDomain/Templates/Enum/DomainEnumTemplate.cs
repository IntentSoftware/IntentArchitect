﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Packages.RichDomain.Templates.Enum
{
    using Intent.SoftwareFactory.MetaModels.UMLModel;
    using Intent.MetaModel.UMLModel;
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
    
    #line 1 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.RichDomain\Templates\Enum\DomainEnumTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class DomainEnumTemplate : IntentProjectItemTemplateBase<EnumDefinition>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 15 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.RichDomain\Templates\Enum\DomainEnumTemplate.tt"

 
            
            #line default
            #line hidden
            this.Write(" \r\n\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing Intent.Framework.Dom" +
                    "ain;\r\nusing Intent.Framework.Core;\r\n\r\nnamespace ");
            
            #line 23 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.RichDomain\Templates\Enum\DomainEnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public enum ");
            
            #line 25 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.RichDomain\Templates\Enum\DomainEnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Type));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n");
            
            #line 27 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.RichDomain\Templates\Enum\DomainEnumTemplate.tt"
    foreach(var literal in Model.Values)
    { 
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 29 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.RichDomain\Templates\Enum\DomainEnumTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(literal));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 30 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.RichDomain\Templates\Enum\DomainEnumTemplate.tt"
    } 
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }
    
    #line default
    #line hidden
}

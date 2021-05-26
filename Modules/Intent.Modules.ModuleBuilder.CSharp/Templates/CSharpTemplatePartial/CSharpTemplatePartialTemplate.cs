// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.Modules.Common.Types.Api;
    using Intent.ModuleBuilder.CSharp.Api;
    using Intent.ModuleBuilder.Api;
    using Intent.ModuleBuilder.Helpers;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CSharpTemplatePartialTemplate : CSharpTemplateBase<Intent.ModuleBuilder.CSharp.Api.CSharpTemplateModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System.Collections.Generic;\r\nusing Intent.Engine;\r\nusing Intent.Modules.Com" +
                    "mon.Templates;\r\nusing Intent.Modules.Common.CSharp.Templates;\r\nusing Intent.Rosl" +
                    "ynWeaver.Attributes;\r\nusing Intent.Templates;\r\n");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetModelType() != null ? string.Format("using {0};", Model.GetModelType().Namespace) : ""));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n    partial class ");
            
            #line 28 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 28 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBaseType()));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        [IntentManaged(Mode.Fully)]\r\n        public const string Templat" +
                    "eId = \"");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateId()));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n\t    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n        public ");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IOutputTarget outputTarget, ");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(" model");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetModelType() == null ? " = null" : ""));
            
            #line default
            #line hidden
            this.Write(") : base(TemplateId, outputTarget, model)\r\n        {\r\n        }\r\n\r\n        protec" +
                    "ted override CSharpFileConfig DefineFileConfig()\r\n        {\r\n            return " +
                    "new CSharpFileConfig(\r\n                className: $\"");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetClassName()));
            
            #line default
            #line hidden
            this.Write("\",\r\n                @namespace: $\"{this.GetNamespace()}\",\r\n                relati" +
                    "veLocation: $\"{this.GetFolderPath()}\");\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

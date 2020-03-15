// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiModelImplementationTemplate
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.Modules.ModuleBuilder.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ApiModelImplementationTemplate : IntentRoslynProjectItemTemplateBase<IElementSettings>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Inten" +
                    "t.Metadata.Models;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace " +
                    "");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    internal class ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public const string SpecializationType = \"");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n        private readonly IElement _element;\r\n\r\n        public ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IElement element)
        {
            if (element.SpecializationType != SpecializationType)
            {
                throw new ArgumentException($""Invalid element type {element.SpecializationType}"", nameof(element));
            }
            _element = element;
        }

        public string Id => _element.Id;
        
        public string Name => _element.Name;
        
        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;
        
");
            
            #line 39 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
  if (Model.MenuOptions != null) {
        foreach(var creationOption in Model.MenuOptions.CreationOptions.Where(x => GetCreationOptionTypeInterface(x, false) != null)) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully)]\r\n        public ");
            
            #line 42 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionTypeInterface(creationOption, creationOption.AllowMultiple)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 42 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionName(creationOption)));
            
            #line default
            #line hidden
            this.Write(" => _element.ChildElements\r\n            .Where(x => x.SpecializationType == Api.");
            
            #line 43 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionTypeClass(creationOption)));
            
            #line default
            #line hidden
            this.Write(".SpecializationType)\r\n            .Select(x => new ");
            
            #line 44 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionTypeClass(creationOption)));
            
            #line default
            #line hidden
            this.Write("(x))\r\n");
            
            #line 45 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
      if (creationOption.AllowMultiple) { 
            
            #line default
            #line hidden
            this.Write("            .ToList<");
            
            #line 46 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionTypeInterface(creationOption, false)));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 47 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
      } else { 
            
            #line default
            #line hidden
            this.Write("            .SingleOrDefault();\r\n");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
      } 
            
            #line default
            #line hidden
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
      }
    }
            
            #line default
            #line hidden
            this.Write("\r\n        protected bool Equals(");
            
            #line 53 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@" other)
        {
            return Equals(_element, other._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((");
            
            #line 63 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiModelImplementationTemplate\ApiModelImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(")obj);\r\n        }\r\n\r\n        public override int GetHashCode()\r\n        {\r\n      " +
                    "      return (_element != null ? _element.GetHashCode() : 0);\r\n        }\r\n    }\r" +
                    "\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
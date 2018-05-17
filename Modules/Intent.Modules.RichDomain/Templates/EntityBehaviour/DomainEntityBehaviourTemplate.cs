﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.RichDomain.Templates.EntityBehaviour
{
    using Intent.SoftwareFactory.MetaModels.UMLModel;
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
    
    #line 1 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class DomainEntityBehaviourTemplate : IntentRoslynProjectItemTemplateBase<Class>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("  \r\n\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing" +
                    " Intent.CodeGen;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Ignore)]\r\n\r\nnamespace ");
            
            #line 22 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{   \r\n    [IntentManaged(Mode.Merge)]\r\n    [DefaultIntentManaged(Mode.Merge, Si" +
                    "gnature = Mode.Merge, Body = Mode.Ignore, Targets = Targets.Methods, AccessModif" +
                    "iers = AccessModifiers.Public)]\r\n    partial class ");
            
            #line 26 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("  \r\n    {\r\n\r\n");
            
            #line 29 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
	if (Model.Attributes.Any()) {
            
            #line default
            #line hidden
            this.Write("        [IntentInitialGen]\r\n");
            
            #line 31 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
		string constructorDefinition = Model.Attributes.Any(a => !a.IsAssociationAttribute)
			? Model.Attributes.Where(a => !a.IsAssociationAttribute).Select(x => x.DomainType() + " " + x.Name.ToCamelCase()).Aggregate((x, y) => x + ", " + y)
			: "";

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 35 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 35 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constructorDefinition));
            
            #line default
            #line hidden
            this.Write(")\r\n            : this (false)\r\n        {\r\n");
            
            #line 38 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
		foreach (var attribute in Model.Attributes.Where(a => !a.IsAssociationAttribute)) {
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 39 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 39 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 40 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
		}//for

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 44 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
		foreach (var attribute in Model.Attributes.Where(a => a.Stereotypes.Any(x => x.Name == "Calculated"))) {
            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 45 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.DomainType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 45 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get { return default(");
            
            #line 47 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.DomainType()));
            
            #line default
            #line hidden
            this.Write("); }\r\n            set { }\r\n        }\r\n");
            
            #line 50 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
		}
	}//if

            
            #line default
            #line hidden
            
            #line 53 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
  foreach (var operation in Model.Operations)
    {
        string returnType = operation.ReturnType != null ? operation.ReturnType.DomainType() : "void";
        string parameterDefinitions = operation.Parameters.Any() ? operation.Parameters.Select(x => x.DomainType() + " " + x.Name.ToCamelCase()).Aggregate((x, y) => x + ", " + y) : "";
        if (!operation.IsCommandBehaviour())
        {
			if (!operation.IsAbstract)
			{
            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 61 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 61 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 61 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDefinitions));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            throw new NotImplementedException(\"Replace with your im" +
                    "plementation...\");\r\n        }\r\n");
            
            #line 65 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
			}
			else
			{ 
            
            #line default
            #line hidden
            this.Write("        public abstract ");
            
            #line 68 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 68 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 68 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDefinitions));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 69 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
			}
		}
    }

            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n\r\n    [IntentManaged(Mode.Merge)]\r\n    [DefaultIntentManaged(Mode.Merge," +
                    " Signature = Mode.Merge, Body = Mode.Ignore, Targets = Targets.Methods, AccessMo" +
                    "difiers = AccessModifiers.Public)]\r\n    partial class ");
            
            #line 78 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Behaviour\r\n    {\r\n");
            
            #line 80 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
  foreach (var operation in Model.Operations)
    {
        string returnType = operation.ReturnType != null ? operation.ReturnType.DomainType() : "void";
        string parameterDefinitions = operation.Parameters.Any() ? operation.Parameters.Select(x => x.DomainType() + " " + x.Name.ToCamelCase()).Aggregate((x, y) => x + ", " + y) : "";
        if (operation.IsCommandBehaviour())
        {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 87 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 87 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 87 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDefinitions));
            
            #line default
            #line hidden
            this.Write(")\r\n        {");
            
            #line 88 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OperationStart()));
            
            #line default
            #line hidden
            this.Write("\r\n            throw new NotImplementedException(\"Replace with your implementation" +
                    "...\");\r\n        }\r\n\r\n");
            
            #line 92 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityBehaviour\DomainEntityBehaviourTemplate.tt"
      }
    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

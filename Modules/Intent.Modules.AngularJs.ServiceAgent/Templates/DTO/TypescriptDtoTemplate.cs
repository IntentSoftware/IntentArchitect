﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AngularJs.ServiceAgent.Templates.DTO
{
    using Intent.SoftwareFactory.MetaModels.Common;
    using Intent.SoftwareFactory.MetaModels.Class;
    using Intent.SoftwareFactory.Templates;
    using Intent.MetaModel.Dto.Old;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class TypescriptDtoTemplate : IntentTypescriptProjectItemTemplateBase<DtoModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\nnamespace ");
            
            #line 17 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 19 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
 AddClass(Model.Class);
            
            #line default
            #line hidden
            this.Write("} \r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 22 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"

    void AddClass(ClassModel model)
    {

        
        #line default
        #line hidden
        
        #line 25 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("    export interface ");

        
        #line default
        #line hidden
        
        #line 26 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(model.ClassType.TypeName));

        
        #line default
        #line hidden
        
        #line 26 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("\r\n    {\r\n");

        
        #line default
        #line hidden
        
        #line 28 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
        foreach (var p in model.Properties)
        {
            
        

        
        #line default
        #line hidden
        
        #line 32 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("        ");

        
        #line default
        #line hidden
        
        #line 32 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Name.ToCamelCase()));

        
        #line default
        #line hidden
        
        #line 32 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(": ");

        
        #line default
        #line hidden
        
        #line 32 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Type.ConvertType()));

        
        #line default
        #line hidden
        
        #line 32 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 33 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
 
        }

        
        #line default
        #line hidden
        
        #line 35 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("    }\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 38 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
        foreach (var child in model.ChildClasses)
        {
            AddClass(child);
        }

        
        #line default
        #line hidden
        
        #line 43 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"

    }

        
        #line default
        #line hidden
        
        #line 46 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
 



        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}

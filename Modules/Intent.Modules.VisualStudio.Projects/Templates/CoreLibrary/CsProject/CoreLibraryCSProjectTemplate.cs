﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.VisualStudio.Projects.Templates.CoreLibrary.CsProject
{
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.VisualStudio;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreLibrary\CsProject\CoreLibraryCSProjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class CoreLibraryCSProjectTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            this.Write("<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <TargetFramework>netc" +
                    "oreapp2.1</TargetFramework>\r\n  </PropertyGroup>\r\n\r\n");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreLibrary\CsProject\CoreLibraryCSProjectTemplate.tt"
  if (Project.Dependencies().Any()) { 
            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreLibrary\CsProject\CoreLibraryCSProjectTemplate.tt"
      foreach (var dependency in Project.Dependencies()) { 
            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"..\\");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreLibrary\CsProject\CoreLibraryCSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreLibrary\CsProject\CoreLibraryCSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write(".csproj\" />\r\n");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreLibrary\CsProject\CoreLibraryCSProjectTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 27 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreLibrary\CsProject\CoreLibraryCSProjectTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("</Project>\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

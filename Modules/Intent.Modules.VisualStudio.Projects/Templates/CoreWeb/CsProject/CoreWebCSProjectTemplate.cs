﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.VisualStudio.Projects.Templates.CoreWeb.CsProject
{
    using Intent.SoftwareFactory.MetaModels.Class;
    using Intent.SoftwareFactory.Templates;
    using Intent.SoftwareFactory.VisualStudio;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class CoreWebCSProjectTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            this.Write(@"<Project Sdk=""Microsoft.NET.Sdk.Web"">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <Folder Include=""wwwroot\"" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include=""Microsoft.AspNetCore.All"" Version=""2.0.8"" />
    <PackageReference Include=""Microsoft.VisualStudio.Web.CodeGeneration.Design"" Version=""2.0.3"" />
  </ItemGroup>

  <ItemGroup>
    <DotNetCliToolReference Include=""Microsoft.VisualStudio.Web.CodeGeneration.Tools"" Version=""2.0.4"" />
  </ItemGroup>

");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
  if (Project.Dependencies().Any()) { 
            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n");
            
            #line 36 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
      foreach (var dependency in Project.Dependencies()) { 
            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"..");
            
            #line 37 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 37 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write(".csproj\" />\r\n");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n\r\n");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.VisualStudio.Projects\Templates\CoreWeb\CsProject\CoreWebCSProjectTemplate.tt"
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

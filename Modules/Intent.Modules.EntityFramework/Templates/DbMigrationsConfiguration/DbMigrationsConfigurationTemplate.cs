﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFramework.Templates.DbMigrationsConfiguration
{
    using Intent.Modules.Common.Templates;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class DbMigrationsConfigurationTemplate : CSharpTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Data.Entity.Migrations;\r\nusing System.Data.Entity.Mig" +
                    "rations.Model;\r\nusing System.Data.Entity.SqlServer;\r\nusing System.IO;\r\n");
            
            #line 9 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 13 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n    public sealed c" +
                    "lass ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\r\n        : DbMigrationsConfiguration<");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDbContextClassName()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n            AutomaticMigrationsEnabled = false;\r\n        }\r\n\r\n    " +
                    "    protected override void Seed(");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDbContextClassName()));
            
            #line default
            #line hidden
            this.Write(" context)\r\n        {\r\n            base.Seed(context);\r\n");
            
            #line 27 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"

            foreach (var @event in GetSeedDataRequiredRegistrations())
            {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(@event));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 32 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write("\r\n            CustomSeed(context);\r\n        }\r\n\r\n        [IntentManaged(Mode.Merg" +
                    "e, Signature = Mode.Fully, Body = Mode.Ignore)]\r\n        private void CustomSeed" +
                    "(");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsConfiguration\DbMigrationsConfigurationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDbContextClassName()));
            
            #line default
            #line hidden
            this.Write(" dbContext)\r\n        {\r\n            // Put your seed data here\r\n        }\r\n    }\r" +
                    "\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

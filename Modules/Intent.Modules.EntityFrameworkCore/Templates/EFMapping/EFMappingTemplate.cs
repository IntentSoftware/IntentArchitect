﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFrameworkCore.Templates.EFMapping
{
    using Intent.Modelers.Domain.Api;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class EFMappingTemplate : IntentRoslynProjectItemTemplateBase<IClass>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\nusing System;\r\nusing Microsoft.EntityFrameworkCore;\r\nusing Microsoft.EntityFra" +
                    "meworkCore.Metadata.Builders;\r\n");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IEntityTypeConfiguration<");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityStateName));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public void Configure(EntityTypeBuilder<");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityStateName));
            
            #line default
            #line hidden
            this.Write("> builder)\r\n        {\r\n");
            
            #line 27 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

if (Model.ParentClass == null)
{

            
            #line default
            #line hidden
            this.Write("            builder.ToTable(\"");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetStereotypeProperty(Stereotypes.Rdbms.Table.Name, Stereotypes.Rdbms.Table.Property.Name, Model.Name)));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetStereotypeProperty(Stereotypes.Rdbms.Table.Name, Stereotypes.Rdbms.Table.Property.Schema, "dbo")));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 32 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

}

var explicitPrimaryKeys = Model.Attributes.Where(x => x.HasStereotype(Stereotypes.Rdbms.PrimaryKey.Name)).ToList();
var addedImplicitKey = false;
if (Model.ParentClass == null && !explicitPrimaryKeys.Any())
{
    addedImplicitKey = true;

            
            #line default
            #line hidden
            this.Write("            builder.HasKey(x => x.Id);\r\n            builder.Property(x => x.Id).H" +
                    "asColumnName(\"Id\");\r\n");
            
            #line 43 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

}
else
{

            
            #line default
            #line hidden
            this.Write("            builder.HasKey(x => ");
            
            #line 48 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((explicitPrimaryKeys.Count() == 1 ? "x." + explicitPrimaryKeys.Single().Name.ToPascalCase() : string.Format("new {{ {0} }}", string.Join(", ", explicitPrimaryKeys.Select(x => "x." + x.Name))))));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

}

if (Model.ParentClass != null) {

            
            #line default
            #line hidden
            this.Write("            builder.HasBaseType<");
            
            #line 54 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ParentClass.Name));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

}

foreach (var attribute in Model.Attributes)
{
    if (attribute.Name.ToLower() == "id" && addedImplicitKey)
    {
        throw new Exception(string.Format("Surrogate Key is implicit for class {0}. Either remove the 'id' attribute, or disable the 'Implicit Surrogate Key' option for this template", Model.Name));
    }

            
            #line default
            #line hidden
            this.Write("            builder.Property(x => x.");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 66 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

    if (!attribute.Type.IsNullable)
    {

            
            #line default
            #line hidden
            this.Write("\r\n                .IsRequired()");
            
            #line 71 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

    }

    if (attribute.GetStereotypeProperty(Stereotypes.Rdbms.PrimaryKey.Name, Stereotypes.Rdbms.PrimaryKey.Property.Identity, false)){

            
            #line default
            #line hidden
            this.Write("\r\n                .UseSqlServerIdentityColumn()\r\n");
            
            #line 78 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

    }

    if (attribute.HasStereotype(Stereotypes.Rdbms.DefaultConstraint.Name) && attribute.GetStereotypeProperty<string>(Stereotypes.Rdbms.DefaultConstraint.Name, Stereotypes.Rdbms.DefaultConstraint.Property.Value) != null)
    {

            
            #line default
            #line hidden
            this.Write("\r\n                .HasDefaultValueSql(\"");
            
            #line 85 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.GetStereotypeProperty<string>(Stereotypes.Rdbms.DefaultConstraint.Name, Stereotypes.Rdbms.DefaultConstraint.Property.Value)));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 86 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

    }

    if (attribute.Type.Element.Name == "string" )
    {
        var maxLength =
            attribute.GetStereotypeProperty<int?>(Stereotypes.Rdbms.Text.Name, Stereotypes.Rdbms.Text.Property.MaxLength) ??
            attribute.GetStereotypeProperty<int?>(Stereotypes.Legacy.StringOptions.Name, Stereotypes.Legacy.StringOptions.Property.MaxLength);
        if (maxLength.HasValue)
        {

            
            #line default
            #line hidden
            this.Write("\r\n                .HasMaxLength(");
            
            #line 98 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(maxLength.Value));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 99 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

        }
    }

    var dataType = attribute.GetStereotypeProperty<string>(Stereotypes.Legacy.Numeric.Name, Stereotypes.Legacy.Numeric.Property.DataType, "decimal");
    var decimalPrecision = attribute.GetStereotypeProperty<int?>(Stereotypes.Rdbms.Numeric.Name, Stereotypes.Rdbms.Numeric.Property.Precision);
    var decimalScale = attribute.GetStereotypeProperty<int?>(Stereotypes.Rdbms.Numeric.Name, Stereotypes.Rdbms.Numeric.Property.Scale);
    if (decimalPrecision.HasValue && decimalScale.HasValue)
    {

            
            #line default
            #line hidden
            this.Write("\r\n                .HasColumnType(\"");
            
            #line 110 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dataType));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 110 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decimalPrecision));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 110 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decimalScale));
            
            #line default
            #line hidden
            this.Write(")\")\r\n");
            
            #line 111 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

    }

    if (HasTypeOverride(attribute))
    {

            
            #line default
            #line hidden
            this.Write("                .HasColumnType(\"");
            
            #line 117 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeOverride(attribute)));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 118 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("                ;\r\n\r\n");
            
            #line 123 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

}

var indexes = Model.Attributes
    .Where(x => x.HasStereotype(Stereotypes.Rdbms.Index.Name))
    .GroupBy(x => x.GetStereotypeProperty(Stereotypes.Rdbms.Index.Name, Stereotypes.Rdbms.Index.Property.UniqueKey, "IX_" + Model.Name + "_" + x.Name));
foreach(var index in indexes)
{

            
            #line default
            #line hidden
            this.Write("            builder.HasIndex(x => ");
            
            #line 132 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(index.Count() == 1 ? "x." + index.Single().Name.ToPascalCase() : string.Format("new {{ {0} }}", string.Join(", ", index.OrderBy(x => x.GetStereotypeProperty<int>("Index", "Order", 0)).Select(x => "x." + x.Name)))));
            
            #line default
            #line hidden
            this.Write(")\r\n                .HasName(\"");
            
            #line 133 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(index.Key));
            
            #line default
            #line hidden
            this.Write("\")\r\n                .IsUnique(");
            
            #line 134 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(index.First().GetStereotypeProperty(Stereotypes.Rdbms.Index.Name, Stereotypes.Rdbms.Index.Property.IsUnique, "false")));
            
            #line default
            #line hidden
            this.Write(")\r\n                ;\r\n");
            
            #line 136 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

}

foreach (var associationEnd in Model.AssociatedClasses)
{

    if (associationEnd != associationEnd.Association.TargetEnd)
    {
        continue;
    }

    switch (associationEnd.Relationship())
    {
        case RelationshipType.OneToOne:

            
            #line default
            #line hidden
            this.Write("            builder.HasOne(x => x.");
            
            #line 151 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n                .WithOne(");
            
            #line 152 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().IsNavigable ? "x => x." + associationEnd.OtherEnd().Name().ToPascalCase() : ""));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 153 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            if (associationEnd.OtherEnd().MinMultiplicity != "0")
            {

            
            #line default
            #line hidden
            this.Write("                .HasForeignKey<");
            
            #line 157 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(">(x => x.Id)\r\n                .IsRequired()\r\n                .OnDelete(DeleteBeha" +
                    "vior.Cascade)\r\n");
            
            #line 160 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("                .HasForeignKey<");
            
            #line 165 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 165 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetForeignKeyLambda(associationEnd.OtherEnd())));
            
            #line default
            #line hidden
            this.Write(")\r\n                .OnDelete(DeleteBehavior.Restrict)\r\n");
            
            #line 167 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write("                ;\r\n\r\n");
            
            #line 172 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            break;
        case RelationshipType.OneToMany:

            
            #line default
            #line hidden
            this.Write("            builder.HasOne(x => x.");
            
            #line 176 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n                .WithMany(");
            
            #line 177 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().IsNavigable ? "x => x." + associationEnd.OtherEnd().Name().ToPascalCase() : ""));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 178 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            if (UseForeignKeys)
            {

            
            #line default
            #line hidden
            this.Write("                .HasForeignKey(");
            
            #line 182 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetForeignKeyLambda(associationEnd.OtherEnd())));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 183 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("                .HasForeignKey(\"");
            
            #line 188 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Id\"))\r\n");
            
            #line 189 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write("                .OnDelete(DeleteBehavior.Restrict)\r\n                ;\r\n\r\n");
            
            #line 195 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            break;
        case RelationshipType.ManyToOne:

            
            #line default
            #line hidden
            this.Write("            builder.HasMany(x => x.");
            
            #line 199 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n                .WithOne(x => x.");
            
            #line 200 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 201 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            if (UseForeignKeys)
            {

            
            #line default
            #line hidden
            this.Write("                .HasForeignKey(");
            
            #line 205 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetForeignKeyLambda(associationEnd)));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 206 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("                .Map(m => m.MapKey(\"");
            
            #line 211 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Id\"))\r\n");
            
            #line 212 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            }

            if (associationEnd.OtherEnd().MinMultiplicity != "0")
            {

            
            #line default
            #line hidden
            this.Write("                .IsRequired()\r\n                .OnDelete(DeleteBehavior.Cascade)\r" +
                    "\n");
            
            #line 220 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write("                ;\r\n\r\n");
            
            #line 225 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
          break;
        case RelationshipType.ManyToMany:
            IssueManyToManyWarning(associationEnd);

            
            #line default
            #line hidden
            this.Write("            builder.Ignore(x => x.");
            
            #line 229 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n                ;\r\n\r\n");
            
            #line 232 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\EFMapping\EFMappingTemplate.tt"

            break;
    }
}

            
            #line default
            #line hidden
            this.Write("        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFramework.Templates.EFMapping
{
    using Intent.MetaModel.Domain;
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class EFMappingTemplate : IntentRoslynProjectItemTemplateBase<IClass>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\n");
            
            #line 15 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
//Some initial validation
    foreach (var associationEnd in Model.AssociatedClasses)
    {
        var association = associationEnd.Association;
 
        //if there is more than 1 parent association && there are any which are not 0..1->1 (this is a manual inheritance mapping)
        var multipleCompositions = Model.AssociatedClasses.Where(ae => ae.Association.AssociationType == AssociationType.Composition && ae.Association.TargetEnd.Class == Model);
        if (multipleCompositions.Count() > 1)
        {
            throw new Exception(string.Format("Unsupported Mapping - {0} each have a Compositional relationship with {1}.", multipleCompositions.Select(x => x.Class.Name).Aggregate((x, y) => x + ", " + y), Model.Name));
        }

        if (!association.TargetEnd.IsNavigable)
        {
            throw new Exception(string.Format("Unsupported Source Needs to be Navigable to Target relationship  {0} on {1} ", association.ToString(), association.TargetEnd.Class.Name));
        }

        //Unsupported Associations
        if ((association.AssociationType == AssociationType.Aggregation ) && ( association.RelationshipString() == "1->0..1"))
        {
            throw new Exception(string.Format("Unsupported Aggregation relationship  {0} - this relationship implies composition", association.ToString()));
        }
        if ((association.AssociationType == AssociationType.Aggregation ) && ( association.RelationshipString() == "1->1"))
        {
            throw new Exception(string.Format("Unsupported Aggregation relationship  {0} - this relationship implies composition", association.ToString()));
        }
        if ((association.AssociationType == AssociationType.Aggregation ) && ( association.RelationshipString() == "1->*"))
        {
            throw new Exception(string.Format("Unsupported Aggregation relationship {0}, this relationship implies Composition", association.ToString()));
        }
        if ((association.AssociationType == AssociationType.Composition ) && ( association.RelationshipString() == "0..1->0..1"))
        {
            throw new Exception(string.Format("Unsupported Composition relationship {0}", association.ToString()));
        }
        if ((association.AssociationType == AssociationType.Composition ) && ( association.RelationshipString() == "0..1->*"))
        {
            throw new Exception(string.Format("Unsupported Composition relationship {0}, this relationship implies aggregation", association.ToString()));
        }
        if ((association.AssociationType == AssociationType.Composition ) && ( association.RelationshipString().StartsWith("*->")))
        {
            throw new Exception(string.Format("Unsupported Composition relationship {0}, this relationship implies aggregation", association.ToString()));
        }
        //Naviagability Requirement
        if ((association.AssociationType == AssociationType.Composition ) && ( association.RelationshipString() == "0..1->1") && (!association.SourceEnd.IsNavigable))
        {
            throw new Exception(string.Format("Unsupported. IsNavigable from Composition Required for Composition relationship {0}", association.ToString()));
        }
    }


            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Data.Entity.ModelConfiguration;\r\nusing System.Data.En" +
                    "tity.Infrastructure.Annotations;\r\nusing System.ComponentModel.DataAnnotations.Sc" +
                    "hema;\r\n");
            
            #line 69 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 73 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class ");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Mapping : EntityTypeConfiguration<");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n    \r\n        public ");
            
            #line 78 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Mapping()\r\n        {\r\n");
            
            #line 80 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
    if (Model.ParentClass == null || Model.ParentClass.GetStereotypeProperty<string>("InheritanceMapping", "Type") != "TPH")
    {
            
            #line default
            #line hidden
            this.Write("            this.ToTable(\"");
            
            #line 82 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
    }
    if (Model.GetStereotypeProperty<string>("InheritanceMapping", "Type") == "TPH")
    {
        foreach (var subClass in Model.ChildClasses)
        {

            
            #line default
            #line hidden
            this.Write("            this.Map<");
            
            #line 89 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subClass.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(">(m => m.Requires(\"DbSpecialization\").HasValue((int)");
            
            #line 89 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Specialization.");
            
            #line 89 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subClass.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 90 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
      }
    }
	bool mapPk = true;
    //Key Mapping
    if (Model.ParentClass != null && Model.ParentClass.GetStereotypeProperty<string>("InheritanceMapping", "Type") == "TPH")    
    {
		mapPk = false;
        //No Key mapping required
    } 

	var addedImplicitKey = false;
    if (Model.ParentClass == null && !Model.Attributes.Any(x => x.HasStereotype("Primary Key"))) {
        addedImplicitKey = true;
            
            #line default
            #line hidden
            this.Write("            builder.HasKey(x => x.Id);\r\n            builder.Property(x => x.Id).H" +
                    "asColumnName(\"Id\");\r\n");
            
            #line 105 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
  }
    if (Model.ParentClass != null) {
            
            #line default
            #line hidden
            this.Write("            builder.HasBaseType<");
            
            #line 107 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ParentClass.Name));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 108 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
  }  
    foreach (var attribute in Model.Attributes)
    {
        if (attribute.Name.ToLower() == "id" && addedImplicitKey)
        {
                throw new Exception(string.Format("Surrogate Key is implicit for class {0}. Either remove the 'id' attribute, or disable the 'Implicit Surrogate Key' option for this template", Model.Name));
	    }
        if (attribute.HasStereotype("Primary Key")) {
            
            #line default
            #line hidden
            this.Write("            builder.HasKey(x => x.");
            
            #line 116 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 117 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
		}
            
            #line default
            #line hidden
            this.Write("            this.Property(x => x.");
            
            #line 118 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 118 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

		if (!string.IsNullOrEmpty(attribute.GetStereotypeProperty<string>("Index", "UniqueKey")))
		{
            
            #line default
            #line hidden
            this.Write("                .HasColumnAnnotation(\"Index\", new IndexAnnotation(new []\r\n       " +
                    "             {\r\n");
            
            #line 123 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
			foreach(var index in attribute.Stereotypes.Where(x => x.Name == "Index")) { 
            
            #line default
            #line hidden
            this.Write("                        new IndexAttribute(\"");
            
            #line 124 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("_");
            
            #line 124 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(index.GetProperty("UniqueKey", "Unique1")));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 124 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(index.GetProperty("Order", "1")));
            
            #line default
            #line hidden
            this.Write(") { IsUnique = ");
            
            #line 124 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(index.GetProperty("IsUnique", "false")));
            
            #line default
            #line hidden
            this.Write(" },\r\n");
            
            #line 125 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

			}
            
            #line default
            #line hidden
            this.Write("                    }))");
            
            #line 127 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

        }
        if (!attribute.IsNullable){
            
            #line default
            #line hidden
            this.Write("\r\n                .IsRequired()");
            
            #line 131 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

        }

        if (attribute.Type.Name == "string" )
        {
            var maxLength = attribute.GetStereotypeProperty<int?>("StringOptions", "MaxLength") ?? attribute.GetStereotypeProperty<int?>("Text", "MaxLength");     // (Text for backwards compatibility with RichDomain)
            if (maxLength.HasValue){
        
            
            #line default
            #line hidden
            this.Write("\r\n                .HasMaxLength(");
            
            #line 140 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(maxLength.Value));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 140 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

            }
            var isUnicode = attribute.GetStereotypeProperty<bool>("StringOptions", "IsUnicode", false);    
            if (isUnicode){
        
            
            #line default
            #line hidden
            this.Write("\r\n                .IsUnicode()");
            
            #line 146 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

            }
        }

        var decimalPrecision = attribute.GetStereotypeProperty<int?>("Numeric", "Precision");
        var decimalScale = attribute.GetStereotypeProperty<int?>("Numeric", "Scale");
        if (decimalPrecision.HasValue && decimalScale.HasValue){
            
            #line default
            #line hidden
            this.Write("\r\n                .HasPrecision(");
            
            #line 154 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decimalPrecision));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 154 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decimalScale));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 154 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

        }


        if (HasTypeOverride(attribute))
        { 
            
            #line default
            #line hidden
            this.Write("                .HasColumnType(\"");
            
            #line 160 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeOverride(attribute)));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 161 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t;\r\n\r\n");
            
            #line 164 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 165 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
    foreach (var associationEnd in Model.AssociatedClasses)
    {

		if (associationEnd != associationEnd.Association.TargetEnd)
        {
			continue;
        }

        switch (associationEnd.Relationship())
        {
            case RelationshipType.OneToOne :
                MapOneToOne(associationEnd);
                break;
            case RelationshipType.OneToMany :
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 179 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("this.{0}(x => x.{1})", associationEnd.MinMultiplicity != "0" ? "HasRequired" : "HasOptional", associationEnd.Name().ToPascalCase())));
            
            #line default
            #line hidden
            this.Write("\r\n                .WithMany(");
            
            #line 180 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().IsNavigable ? "x => x." + associationEnd.OtherEnd().Name().ToPascalCase() : ""));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 181 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				if (UseForeignKeys) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t.HasForeignKey(x => x.");
            
            #line 182 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().GetStereotypeProperty("Foreign Key", "Column Name", associationEnd.Name().ToPascalCase() + "Id")));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 183 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				} else { 
            
            #line default
            #line hidden
            this.Write("                .Map(m => m.MapKey(\"");
            
            #line 184 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Id\"))\r\n");
            
            #line 185 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				} 
            
            #line default
            #line hidden
            this.Write("                ;\r\n\r\n");
            
            #line 188 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
                  break;
            case RelationshipType.ManyToOne :
            
            #line default
            #line hidden
            this.Write("            this.HasMany(x => x.");
            
            #line 190 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n                .");
            
            #line 191 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0}({1})", associationEnd.OtherEnd().MinMultiplicity != "0" ? "WithRequired" : "WithOptional", "x => x." + associationEnd.OtherEnd().Name().ToPascalCase())));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 192 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				if (UseForeignKeys) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t.HasForeignKey(x => x.");
            
            #line 193 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.GetStereotypeProperty("Foreign Key", "Column Name", associationEnd.OtherEnd().Name().ToPascalCase() + "Id")));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 194 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				} else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t.Map(m => m.MapKey(\"");
            
            #line 195 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Id\"))\r\n");
            
            #line 196 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				} 
            
            #line default
            #line hidden
            
            #line 197 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				if(associationEnd.Association.AssociationType == AssociationType.Composition) {  
            
            #line default
            #line hidden
            this.Write("\t\t\t\t.WillCascadeOnDelete()\r\n");
            
            #line 199 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
				} 
            
            #line default
            #line hidden
            this.Write("                ;\r\n\r\n");
            
            #line 202 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
                  break;
            case RelationshipType.ManyToMany :
            
            #line default
            #line hidden
            this.Write("            this.HasMany(x => x.");
            
            #line 204 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n                .WithMany(");
            
            #line 205 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().IsNavigable ? "x => x." + associationEnd.OtherEnd().Name().ToPascalCase() : ""));
            
            #line default
            #line hidden
            this.Write(")\r\n                .Map(m => \r\n                    {\r\n                        m.T" +
                    "oTable(\"");
            
            #line 208 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().Class.Name.ToPascalCase() + associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\");\r\n                        m.MapLeftKey(\"");
            
            #line 209 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.OtherEnd().Class.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Id\");\r\n                        m.MapRightKey(\"");
            
            #line 210 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Id\");\r\n                    });\r\n\r\n");
            
            #line 213 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
                  break;
        }       
    }

            
            #line default
            #line hidden
            this.Write("        }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 220 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"

public void MapOneToOne(IAssociationEnd associationEnd)
{
    var parent = associationEnd.Association.SourceEnd;
    var child = associationEnd.Association.TargetEnd;

    string hasClause = associationEnd.MinMultiplicity != "0" ? "HasRequired" : "HasOptional";
    string withClause = "With" + (associationEnd.OtherEnd().MinMultiplicity != "0" ? "Required" : "Optional") + ((associationEnd.MinMultiplicity != "0") == (associationEnd.OtherEnd().MinMultiplicity != "0") ?  DeterminePrinciple(associationEnd)  : "");    

        
        #line default
        #line hidden
        
        #line 228 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write("            ");

        
        #line default
        #line hidden
        
        #line 229 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("this.{0}(x => x.{1})", hasClause, associationEnd.Name().ToPascalCase())));

        
        #line default
        #line hidden
        
        #line 229 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write("\r\n            ");

        
        #line default
        #line hidden
        
        #line 230 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(string.Format(".{0}({1})", withClause, associationEnd.OtherEnd().IsNavigable ? "x => x." + associationEnd.OtherEnd().Name().ToPascalCase(): "" )));

        
        #line default
        #line hidden
        
        #line 230 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 231 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
  if ((associationEnd.Association.AssociationType == AssociationType.Composition && associationEnd.Association.RelationshipString() == "0..1->1")
            || (associationEnd.Association.AssociationType == AssociationType.Aggregation && associationEnd.Association.RelationshipString() == "0..1->1")
        )
    {
        
        #line default
        #line hidden
        
        #line 234 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write("            .Map(m => m.MapKey(\"");

        
        #line default
        #line hidden
        
        #line 235 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase() + "Id"));

        
        #line default
        #line hidden
        
        #line 235 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write("\"))\r\n");

        
        #line default
        #line hidden
        
        #line 236 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
    }
        
        #line default
        #line hidden
        
        #line 237 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
	if(associationEnd.Association.AssociationType == AssociationType.Composition) {  
        
        #line default
        #line hidden
        
        #line 237 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write("\t\t\t.WillCascadeOnDelete()\r\n");

        
        #line default
        #line hidden
        
        #line 239 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
	} 
        
        #line default
        #line hidden
        
        #line 239 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
this.Write("            ;\r\n");

        
        #line default
        #line hidden
        
        #line 241 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\EFMapping\EFMappingTemplate.tt"
    
}

public string DeterminePrinciple(IAssociationEnd associationEnd)
{
    if (associationEnd.Association.AssociationType == AssociationType.Composition )
    {
        return "Principal";
    }
    if (associationEnd.Association.AssociationType == AssociationType.Aggregation )
    {
        return "Dependent";
    }
    return "";
}



        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}

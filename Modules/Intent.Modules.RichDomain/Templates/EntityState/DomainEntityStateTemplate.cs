﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.RichDomain.Templates.EntityState
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
    
    #line 1 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class DomainEntityStateTemplate : IntentRoslynProjectItemTemplateBase<Class>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 14 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing Intent.Framework.Domain" +
                    ";\r\nusing Intent.Framework.Core;\r\nusing Intent.CodeGen;\r\n\r\n[assembly: DefaultInte" +
                    "ntManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 23 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 25 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  var orphanableAssociations = GetOrphanableAssociations(Model);
    foreach (var a in orphanableAssociations)
    {
            
            #line default
            #line hidden
            this.Write("    [IndependantOrphanableAttribute(typeof(");
            
            #line 28 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(a.Association.ChildEnd.Class.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("), \"");
            
            #line 28 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(a.Association.RelationshipString()));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 29 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  }

            
            #line default
            #line hidden
            
            #line 30 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassAnnotations(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n    public ");
            
            #line 31 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsAbstract ? "abstract " : ""));
            
            #line default
            #line hidden
            this.Write("partial class ");
            
            #line 31 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 31 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBaseClass(Model) + GetInterfaces(Model)));
            
            #line default
            #line hidden
            this.Write(", IVisitable");
            
            #line 31 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
        
    if (orphanableAssociations.Any())
    {

            
            #line default
            #line hidden
            this.Write(", IIndependantOrphanable, ICanBeOrphaned");
            
            #line 34 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

    }
    bool checkMultiplcity = Model.Associations.Where( a => a.HasConstrianableMultiplicity).Count() > 0;
    if (checkMultiplcity)
    {

            
            #line default
            #line hidden
            this.Write(", IEnforcedMultiplicity");
            
            #line 39 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

    }
            
            #line default
            #line hidden
            this.Write("    {\r\n\r\n        protected ");
            
            #line 43 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("() : base( true)\r\n        {\r\n        }\r\n\r\n        public ");
            
            #line 47 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(bool ormLoading) : base(ormLoading)\r\n        {");
            
            #line 48 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorWithOrmLoadingParameter(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 49 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

            if (Model.IsAggregateRoot() && !Model.IsSubClass()) 
            {

            
            #line default
            #line hidden
            this.Write("            CreateDateTime = DateTime.UtcNow;\r\n");
            
            #line 54 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
          }
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 57 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  foreach (var attribute in Model.Attributes)
    {
        if (attribute.IsAssociationAttribute)
            continue;    
        AddAttribute(attribute);
    }
    foreach (var association in Model.Associations)
    {

    if (association.OtherAssociationEnd().Multiplicity == Multiplicity.Many && association.Multiplicity == Multiplicity.One)
    {
            
            #line default
            #line hidden
            this.Write("        public Guid");
            
            #line 68 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.IsMandatory() ? "" : "?"));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 68 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.IdentifierName()));
            
            #line default
            #line hidden
            this.Write(" { get;  set; }\r\n");
            
            #line 69 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
        if (!association.Navigable)
        { 
            
            #line default
            #line hidden
            this.Write("        public virtual ");
            
            #line 71 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.Type("")));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 71 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 72 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
        } 
            
            #line default
            #line hidden
            
            #line 73 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  }        
    if (!association.Navigable)
        continue;
    
    if (association.Association.AssociationType ==  AssociationType.Aggregation && association.Association.ChildEnd == association && association.Association.RelationshipString() == "0..1->1" )
        continue;

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 80 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.Type("")));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 80 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.Name().ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(";\r\n        public virtual ");
            
            #line 81 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.Type("")));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 81 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get\r\n            {\r\n");
            
            #line 85 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
    if (association.IsCollection() && association.HasConstrianableMultiplicity) 
    {
        AddCheckConstraint(association);
    }
    string associationReturn;
    if (association.IsCollection())
    {
        associationReturn = String.Format("{0} ?? ({0} = new HashSet<{1}>())", association.Name().ToPrivateMember(), association.Class.Name + "");
    }
    else
    {
        associationReturn = association.Name().ToPrivateMember();
    }

            
            #line default
            #line hidden
            this.Write("            \r\n                return ");
            
            #line 99 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationReturn));
            
            #line default
            #line hidden
            this.Write(";\r\n            }\r\n            set\r\n            {    \r\n");
            
            #line 103 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
    if (association.HasConstrianableMultiplicity) 
    {
            
            #line default
            #line hidden
            this.Write("                if (!OrmLoading)\r\n                {\r\n");
            
            #line 107 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

        AddCheckConstraint(association);
            
            #line default
            #line hidden
            this.Write("                }\r\n");
            
            #line 110 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  }
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 111 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(association.Name().ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n            }\r\n        }\r\n");
            
            #line 114 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
    }
            
            #line default
            #line hidden
            
            #line 114 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PublicProperties(Model)));
            
            #line default
            #line hidden
            
            #line 114 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

    if (Model.IsAggregateRoot() && !Model.IsSubClass()) 
    {

            
            #line default
            #line hidden
            this.Write("        public DateTime? CreateDateTime { get; set; }\r\n        public DateTime? U" +
                    "pdateDateTime { get; set; }\r\n        public string UpdatedBy { get; set; }\r\n    " +
                    "    public byte[] Version { get; set; }\r\n\r\n");
            
            #line 123 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 124 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
     if (orphanableAssociations.Any())
    {
            
            #line default
            #line hidden
            this.Write("        \r\n        public bool IsOrphan() \r\n        {\r\n            return ");
            
            #line 129 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(orphanableAssociations.First().Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" == null;\r\n        }\r\n");
            
            #line 131 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
    } 

            
            #line default
            #line hidden
            this.Write("        \r\n        void IVisitable.Accept(IVisitor v)\r\n        {\r\n            v.Vi" +
                    "sit(this);\r\n        }\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 141 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
 

public void AddCheckConstraint(AssociationEnd associationEnd)
{
    string checkFunc = null;
    if (associationEnd.MaxMultiplicity == "1" && associationEnd.MinMultiplicity == "1")
    {
        checkFunc = associationEnd.Name().ToPascalCase() + " != null";
    }
    else if (associationEnd.MaxMultiplicity == "*")
    {
        checkFunc = associationEnd.Name().ToPascalCase() + ".Count >= " + associationEnd.MinMultiplicity;
    }
    else 
    {
        checkFunc = string.Format("{0}.Count >= {1} && {0}.Count <= {2}", associationEnd.Name().ToPascalCase(), associationEnd.MinMultiplicity, associationEnd.MaxMultiplicity) ;
    }

        
        #line default
        #line hidden
        
        #line 158 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("                RequiredMultiplcityChecks[\"");

        
        #line default
        #line hidden
        
        #line 159 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));

        
        #line default
        #line hidden
        
        #line 159 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("\"] = () => ");

        
        #line default
        #line hidden
        
        #line 159 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(checkFunc));

        
        #line default
        #line hidden
        
        #line 159 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(" ;\r\n");

        
        #line default
        #line hidden
        
        #line 160 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

}

public string GetBaseClass(Class umlClass) {
    if (umlClass.ParentClass != null)
        return umlClass.ParentClass.Name + "";

    if (umlClass.IsEntity())
        return umlClass.Stereotypes.GetTagValue<string>("AggregateRoot", "BaseType") ?? "EntityBase";

    return "Object";
}

public string GetInterfaces(Class umlClass) {
    if (umlClass.IsAggregateRoot())
    {
        return ", IAggregateRoot, IVersionedEntity, IEntity";
    }
    if (umlClass.IsEntity())
    {
        return ", IEntity";
    }
    return "";
}

public string GetBaseDataInterfaces(Class umlClass) 
{
    List<string> result = new List<string>();        

    if (umlClass.IsSubClass())
        result.Add("I" + umlClass.ParentClass.Name.ToPascalCase() + "Data");

    if (umlClass.IsAggregateRoot())
        result.Add("IAggregateRoot");

    if (umlClass.IsEntity())
        result.Add("IEntity");

    return string.Join(",", result);
}

public void AddAttribute(UmlAttribute attribute)
{
	if (attribute.Stereotypes.Any(x => x.Name == "Calculated")) {
		return;
    }

        
        #line default
        #line hidden
        
        #line 206 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(PropertyFieldAnnotations(attribute)));

        
        #line default
        #line hidden
        
        #line 207 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("        private ");

        
        #line default
        #line hidden
        
        #line 207 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.DomainType()));

        
        #line default
        #line hidden
        
        #line 207 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 207 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));

        
        #line default
        #line hidden
        
        #line 207 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(";");

        
        #line default
        #line hidden
        
        #line 207 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAnnotations(attribute)));

        
        #line default
        #line hidden
        
        #line 207 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("\r\n        public ");

        
        #line default
        #line hidden
        
        #line 208 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.DomainType()));

        
        #line default
        #line hidden
        
        #line 208 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 208 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));

        
        #line default
        #line hidden
        
        #line 208 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(" \r\n        {\r\n            get { return ");

        
        #line default
        #line hidden
        
        #line 210 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));

        
        #line default
        #line hidden
        
        #line 210 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("; }\r\n            set\r\n            {\r\n");

        
        #line default
        #line hidden
        
        #line 213 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
    if (attribute.Stereotypes.GetTagValue("Text", "TrimAutomatically", false)) {
        
        #line default
        #line hidden
        
        #line 213 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("                value = value?.Truncate(");

        
        #line default
        #line hidden
        
        #line 214 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Stereotypes.GetTagValue("Text", "MaxLength", 8000)));

        
        #line default
        #line hidden
        
        #line 214 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 215 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  }
        
        #line default
        #line hidden
        
        #line 215 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(PropertySetterBefore(attribute)));

        
        #line default
        #line hidden
        
        #line 215 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 216 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  if (attribute.Type == "date")
    {
        if (attribute.IsMandatory)
        {
        
        #line default
        #line hidden
        
        #line 219 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("                ");

        
        #line default
        #line hidden
        
        #line 220 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));

        
        #line default
        #line hidden
        
        #line 220 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(" = value.Date;\r\n");

        
        #line default
        #line hidden
        
        #line 221 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

        }
        else
        {
        
        #line default
        #line hidden
        
        #line 224 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("                ");

        
        #line default
        #line hidden
        
        #line 225 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));

        
        #line default
        #line hidden
        
        #line 225 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(" = (value == null) ? value : value.Value.Date;\r\n");

        
        #line default
        #line hidden
        
        #line 226 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
      }
    }
    else
    {
        
        #line default
        #line hidden
        
        #line 229 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("                ");

        
        #line default
        #line hidden
        
        #line 230 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));

        
        #line default
        #line hidden
        
        #line 230 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(" = value;\r\n");

        
        #line default
        #line hidden
        
        #line 231 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
  }
        
        #line default
        #line hidden
        
        #line 231 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(PropertySetterAfter(attribute)));

        
        #line default
        #line hidden
        
        #line 232 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"
this.Write("            }\r\n        }\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 235 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.RichDomain\Templates\EntityState\DomainEntityStateTemplate.tt"

}

private List<AssociationEnd> GetOrphanableAssociations(Class model)
{
    List<AssociationEnd> result = new List<AssociationEnd>();
    foreach (var a in model.Associations)
    {
        if (a.Association.AssociationType == AssociationType.Composite && a.Association.RelationshipString() == "1->1" && a == a.Association.ChildEnd)
        {
            result.Add(a);
        }
        if (a.Association.AssociationType == AssociationType.Composite && a.Association.RelationshipString() == "1->*" && a == a.Association.ChildEnd)
        {
            result.Add(a);
        }
    }
    return result;
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}

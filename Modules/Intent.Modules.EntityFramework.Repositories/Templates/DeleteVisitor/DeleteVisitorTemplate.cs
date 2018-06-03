﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFramework.Repositories.Templates.DeleteVisitor
{
    using Intent.MetaModel.Domain;
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class DeleteVisitorTemplate : IntentRoslynProjectItemTemplateBase<IEnumerable<IClass>>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\nusing System;\r\nusing Intent.Framework.Core;\r\nusing Intent.Framework.EntityFr" +
                    "amework.Interceptors;\r\nusing System.Collections.Generic;\r\n");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\nusing Intent.CodeGen;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamesp" +
                    "ace ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@" : ICompositionDeleteVisitor
    {
        private readonly IList<object> _toDelete;

        public IList<object> ToDelete
        {
            get
            {
                return _toDelete;
            }
        }

        public void Reset()
        {
            _toDelete.Clear();
        }

        public ");
            
            #line 43 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n            _toDelete = new List<object>();\r\n        }\r\n\r\n        " +
                    "public void Visit(IVisitable visitable)\r\n        {\r\n            Visit((dynamic)v" +
                    "isitable);\r\n        }\r\n\r\n");
            
            #line 53 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
 foreach (var model in Model) {

            
            #line default
            #line hidden
            this.Write("        public void Visit(");
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetClassName(model)));
            
            #line default
            #line hidden
            this.Write(" state)\r\n        {\r\n");
            
            #line 57 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
 
        if (model.ParentClass != null)
        {

            
            #line default
            #line hidden
            this.Write("            Visit((");
            
            #line 61 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetClassName(model.ParentClass)));
            
            #line default
            #line hidden
            this.Write(") state);\r\n");
            
            #line 62 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
 
        }

        foreach(var associationEnd in model.AssociatedClasses)
        {
            if (associationEnd.Association.AssociationType ==  AssociationType.Composition && associationEnd.OtherEnd() == associationEnd)
            {
                if (associationEnd.Multiplicity == Multiplicity.Many) {

            
            #line default
            #line hidden
            this.Write("            foreach (IVisitable item in state.");
            
            #line 71 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Types.Get(associationEnd)));
            
            #line default
            #line hidden
            this.Write(")\r\n            {\r\n                item.Accept(this);\r\n            }\r\n");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
              }
                else
                {
            
            #line default
            #line hidden
            this.Write("            if (state.");
            
            #line 78 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Types.Get(associationEnd)));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n            {\r\n                ((IVisitable)state.");
            
            #line 80 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Types.Get(associationEnd)));
            
            #line default
            #line hidden
            this.Write(").Accept(this);\r\n            }\r\n");
            
            #line 82 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
                }
            }
        }

            
            #line default
            #line hidden
            this.Write("            _toDelete.Add(state);\r\n        }\r\n\r\n");
            
            #line 89 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\DeleteVisitor\DeleteVisitorTemplate.tt"
 }
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

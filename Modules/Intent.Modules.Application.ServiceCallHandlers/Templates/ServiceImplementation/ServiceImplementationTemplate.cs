﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Application.ServiceCallHandlers.Templates.ServiceImplementation
{
    using Intent.SoftwareFactory.Templates;
    using Intent.MetaModel.Service;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ServiceImplementationTemplate : IntentRoslynProjectItemTemplateBase<IServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 14 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"


            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\nusing System.Linq;\r\nusing System.Collections.Generic;\r\n");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NormalizeNamespace(GetServiceInterfaceName())));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        private readonly IServiceProvider _serviceProvider;\r\n\r\n        p" +
                    "ublic ");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IServiceProvider serviceProvider)\r\n        { \r\n            _serviceProvider = se" +
                    "rviceProvider;\r\n        }\r\n\r\n");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
    foreach (var o in Model.Operations)
    {


            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationReturnType(o)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationDefinitionParameters(o)));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            var sch = (");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NormalizeNamespace(GetHandlerClassName(o))));
            
            #line default
            #line hidden
            this.Write(")_serviceProvider.GetService(typeof(");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NormalizeNamespace(GetHandlerClassName(o))));
            
            #line default
            #line hidden
            this.Write("));\r\n            ");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"

        if (o.ReturnType != null)
        {

            
            #line default
            #line hidden
            this.Write("return ");
            
            #line 44 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("sch.Handle(");
            
            #line 46 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationCallParameters(o)));
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n\r\n");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.ServiceCallHandlers\Templates\ServiceImplementation\ServiceImplementationTemplate.tt"
        
    }

            
            #line default
            #line hidden
            this.Write("\r\n        #region IDisposable Members\r\n\r\n        public void Dispose()\r\n        {" +
                    "\r\n            //dispose all resources\r\n        }\r\n\r\n        #endregion\r\n    }\r\n}" +
                    "");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

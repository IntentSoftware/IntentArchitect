﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Packages.Typescript.ServiceAgent.AngularJs.Templates.ServiceProxy
{
    using Intent.MetaModel.Service;
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using Intent.Packages.Typescript.ServiceAgent.Contracts;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class TypescriptWebApiClientServiceProxyTemplate : IntentTypescriptProjectItemTemplateBase<ServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 15 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"


            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 18 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n\r\n    export class ");
            
            #line 20 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" {\r\n        \r\n        static $inject = [\'$http\', \'Config\'];\r\n        constructor(" +
                    "\r\n            public $http: ng.IHttpService,\r\n            public config: any) {\r" +
                    "\n        }\r\n\r\n");
            
            #line 28 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
        foreach (var o in Model.Operations)
        {

            if (o.ReturnType != null)
            {


            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 35 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 35 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetMethodDefinitionParameters(o)));
            
            #line default
            #line hidden
            this.Write("): ng.IHttpPromise<");
            
            #line 35 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ConvertType(o.ReturnType.TypeReference)));
            
            #line default
            #line hidden
            this.Write(">\r\n        {\r\n            var baseUrl = this.config[\"");
            
            #line 37 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApiBasePathConfigKey));
            
            #line default
            #line hidden
            this.Write("\"];\r\n            var url = baseUrl + \"/api/");
            
            #line 38 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToLower().Replace("service","")));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 38 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("\";\r\n            return this.$http.post<");
            
            #line 39 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ConvertType(o.ReturnType.TypeReference)));
            
            #line default
            #line hidden
            this.Write(">(url, { ");
            
            #line 39 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetMethodCallParameters(o)));
            
            #line default
            #line hidden
            this.Write(" });\r\n        }\r\n\r\n");
            
            #line 42 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 47 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 47 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetMethodDefinitionParameters(o)));
            
            #line default
            #line hidden
            this.Write("): ng.IHttpPromise<void>\r\n        {\r\n            var baseUrl = this.config[\"");
            
            #line 49 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApiBasePathConfigKey));
            
            #line default
            #line hidden
            this.Write("\"];\r\n            var url = baseUrl + \"/api/");
            
            #line 50 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToLower().Replace("service","")));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 50 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("\";\r\n            return this.$http.post<void>(url, { ");
            
            #line 51 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetMethodCallParameters(o)));
            
            #line default
            #line hidden
            this.Write(" });\r\n        }\r\n\r\n");
            
            #line 54 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    angular.module(\"App\").service(\"");
            
            #line 59 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Proxy\", ");
            
            #line 59 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.Typescript.ServiceAgent.AngularJs\Templates\ServiceProxy\TypescriptWebApiClientServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Proxy);\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }
    
    #line default
    #line hidden
}

﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AspNet.WebApi.Templates.OwinWebApiConfig
{
    using Intent.Modules.Common.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class OwinWebApiConfigTemplate : CSharpTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"




            
            #line default
            #line hidden
            this.Write("using Newtonsoft.Json;\r\nusing Newtonsoft.Json.Serialization;\r\nusing Owin;\r\nusing " +
                    "System.Web.Http;\r\n");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
    public static class WebApiConfig
    {
        [IntentManaged(Mode.Fully)]
        public static void Configure(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            // Use camel case for JSON data.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Adds ""Z"" to the end of serialized DateTime, so that clients are aware that the received time is UTC
            config.Formatters.JsonFormatter.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: ""DefaultApi"",
                routeTemplate: ""api/{controller}/{id}"",
                defaults: new { id = RouteParameter.Optional }
            );

			AddCustomConfiguration(config);

");
            
            #line 51 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"

    foreach (var item in ConfigureItems)
    {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 56 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("            app.UseWebApi(config);\r\n        }\r\n\r\n\t\t[IntentManaged(Mode.Ignore)]\r\n" +
                    "\t\tpublic static void AddCustomConfiguration(HttpConfiguration config) \r\n\t\t{\r\n\r\n\t" +
                    "\t}\r\n\r\n");
            
            #line 68 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\OwinWebApiConfig\OwinWebApiConfigTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Methods()));
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

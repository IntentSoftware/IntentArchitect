﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.HttpServiceProxy.Templates.AddressResolverImplementation
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
    
    #line 1 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.HttpServiceProxy\Templates\AddressResolverImplementation\HttpServiceProxyAddressResolverImplementationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class HttpServiceProxyAddressResolverImplementationTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\nusing System;\r\nusing System.Configuration;\r\nusing Intent.CodeGen;\r\n\r\n[assemb" +
                    "ly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.HttpServiceProxy\Templates\AddressResolverImplementation\HttpServiceProxyAddressResolverImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 22 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.HttpServiceProxy\Templates\AddressResolverImplementation\HttpServiceProxyAddressResolverImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 22 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.HttpServiceProxy\Templates\AddressResolverImplementation\HttpServiceProxyAddressResolverImplementationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetAddressResolverInterfaceName()));
            
            #line default
            #line hidden
            this.Write(@"
    {
        public Uri Resolve(string targetApplicationName, string basePath)
        {
            var serviceName = ConfigurationManager.AppSettings[$""WebApiEndpointBaseUrl.{targetApplicationName}""];
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                throw new Exception($""No configuration entry defined. Please add the following to the config file's appSetting section: <add key=\""WebApiEndpointBaseUrl.{targetApplicationName}\"" value=\""INSERT_URL_HERE\"" />"");
            }

            return new Uri(new Uri(serviceName), basePath);
        }
    }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

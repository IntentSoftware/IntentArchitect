﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Packages.AngularJs.Auth.ImplicitAuth.Templates.SilentRenewCallbackView
{
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
    
    #line 1 "C:\Dev\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\SilentRenewCallbackView\SilentRenewCallbackViewTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class SilentRenewCallbackViewTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\SilentRenewCallbackView\SilentRenewCallbackViewTemplate.tt"




            
            #line default
            #line hidden
            this.Write(@"<!DOCTYPE html>
<html>
<head>
    <title></title>
    <meta charset=""utf-8"" />
</head>
<body>
    <script>
        //console.debug(""Renewing Token"");
        if (window.parent && window !== window.parent) {
            var hash = window.location.hash;
            if (hash) {
                window.parent.postMessage(hash, location.protocol + ""//"" + location.host);
            }
        }
    </script>
</body>
</html>");
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

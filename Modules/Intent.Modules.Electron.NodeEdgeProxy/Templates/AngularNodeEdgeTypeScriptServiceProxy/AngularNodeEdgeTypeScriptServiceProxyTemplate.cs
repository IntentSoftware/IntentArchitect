﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Electron.NodeEdgeProxy.Templates.AngularNodeEdgeTypeScriptServiceProxy
{
    using Intent.SoftwareFactory.MetaModels.Class;
    using Intent.MetaModel.Service;
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using Intent.Modules.Typescript.ServiceAgent.Contracts;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class AngularNodeEdgeTypeScriptServiceProxyTemplate : IntentProjectItemTemplateBase<ServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\nnamespace ");
            
            #line 16 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n\r\n    export class ");
            
            #line 18 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(@"Proxy {
        private readonly edgeProxy: IEdgeProxy;

        static $inject = [""$q"", ""Config"", ""Edge""];
        constructor(
            private readonly $q: ng.IQService,
            private readonly config: any,
            edge: IEdge) {

            try {
                this.edgeProxy = edge.func({
                    assemblyFile: this.config[""edge_assembly_path""] + """);
            
            #line 29 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssemblyName));
            
            #line default
            #line hidden
            this.Write(".dll\",\r\n                    typeName: \"");
            
            #line 30 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeName));
            
            #line default
            #line hidden
            this.Write("\",\r\n                    methodName: \"Invoke\"\r\n                });\r\n            } " +
                    "catch (e) {\r\n                console.error(e);\r\n            }\r\n        }\r\n\r\n");
            
            #line 38 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
        foreach (var o in Model.Operations)
        {

            if (o.ReturnType != null)
            {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 44 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 44 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetMethodDefinitionParameters(o)));
            
            #line default
            #line hidden
            this.Write("): ng.IPromise<");
            
            #line 44 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ConvertType(o.ReturnType.TypeReference)));
            
            #line default
            #line hidden
            this.Write("> {\r\n            try {\r\n                var data = {\r\n                    operati" +
                    "onName: \"");
            
            #line 47 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name));
            
            #line default
            #line hidden
            this.Write("\",\r\n                    payload: JSON.stringify({\r\n");
            
            #line 49 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"

                    for (var i=0; i<o.Parameters.Count; i++)
                    {
                        var p = o.Parameters[i];
                        var conditionalComma = i+1 != o.Parameters.Count ? "," : "";
                        

            
            #line default
            #line hidden
            this.Write("                        ");
            
            #line 56 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 56 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            
            #line 56 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(conditionalComma));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 57 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"

                    }

            
            #line default
            #line hidden
            this.Write("                    })\r\n                };\r\n\r\n                return this.$q((res" +
                    "olve: (data: ");
            
            #line 63 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ConvertType(o.ReturnType.TypeReference)));
            
            #line default
            #line hidden
            this.Write(@") => void, reject: (reason: any) => void) => {
                    this.edgeProxy(data, (error, result: string) => {
                        if (error) {
                            reject(error);
                            return;
                        }

                        resolve(JSON.parse(result).response);
                    });
                });
            } catch (e) {
                console.error(e);
                return this.$q.reject(e);
            }
        }

");
            
            #line 79 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 84 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 84 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetMethodDefinitionParameters(o)));
            
            #line default
            #line hidden
            this.Write("): ng.IPromise<void> {\r\n            try {\r\n                var data = {\r\n        " +
                    "            operationName: \"");
            
            #line 87 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.Name));
            
            #line default
            #line hidden
            this.Write("\",\r\n                    payload: JSON.stringify({\r\n");
            
            #line 89 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"

                    for (var i=0; i<o.Parameters.Count; i++)
                    {
                        var p = o.Parameters[i];
                        var conditionalComma = i+1 != o.Parameters.Count ? "," : "";
                        

            
            #line default
            #line hidden
            this.Write("                        ");
            
            #line 96 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 96 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            
            #line 96 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(conditionalComma));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 97 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"

                    }

            
            #line default
            #line hidden
            this.Write(@"                    })
                };

                return this.$q((resolve: (data: any) => void, reject: (reason: any) => void) => {
                    this.edgeProxy(data, (error: any) => {
                        if (error) {
                            reject(error);
                            return;
                        }

                        resolve(null);
                    });
                });
            } catch (e) {
                console.error(e);
                return this.$q.reject(e);
            }
        }

");
            
            #line 119 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    angular.module(\"App\").service(\"");
            
            #line 124 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Proxy\", ");
            
            #line 124 "C:\Dev\Intent.OpenSource\Modules\Intent.Modules.Electron.NodeEdgeProxy\Templates\AngularNodeEdgeTypeScriptServiceProxy\AngularNodeEdgeTypeScriptServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Proxy);\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.Templates;
using Intent.ModuleBuilder.Api;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiMetadataProviderExtensions
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class ApiMetadataProviderExtensionsTemplate : CSharpTemplateBase<IList<ElementSettingsModel>>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.ModuleBuilder.Templates.Api.ApiMetadataProviderExtensions";

        public ApiMetadataProviderExtensionsTemplate(IOutputTarget project, IList<ElementSettingsModel> model) : base(TemplateId, project, model)
        {
        }

        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: "ApiMetadataProviderExtensions",
                @namespace: Model.First().ParentModule.ApiNamespace);
        }

        private string GetClassName(ElementSettingsModel elementSettings)
        {
            return GetTypeName(ApiElementModel.ApiElementModelTemplate.TemplateId, elementSettings);
        }
    }
}
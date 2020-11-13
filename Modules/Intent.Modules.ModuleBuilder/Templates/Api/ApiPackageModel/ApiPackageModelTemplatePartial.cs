using System.Collections.Generic;
using Intent.Engine;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.Templates;
using Intent.Modules.ModuleBuilder.Api;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiPackageModel
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class ApiPackageModelTemplate : CSharpTemplateBase<PackageSettingsModel>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "ModuleBuilder.Templates.Api.ApiPackageModel";

        public ApiPackageModelTemplate(IOutputTarget project, PackageSettingsModel model) : base(TemplateId, project, model)
        {
        }

        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: $"{Model.Name.ToCSharpIdentifier()}Model",
                @namespace: $"{OutputTarget.GetNamespace()}");
        }

        private string FormatForCollection(string name, bool asCollection)
        {
            return asCollection ? $"IList<{name}>" : name;
        }

        private string GetCreationOptionName(ElementCreationOptionModel option)
        {
            if (option.GetOptionSettings().ApiModelName() != null)
            {
                return option.GetOptionSettings().ApiModelName();
            }
            var name = option.Name.Replace("Add ", "").Replace("New ", "").ToCSharpIdentifier();
            return option.GetOptionSettings().AllowMultiple() ? name.ToPluralName() : name;
        }

    }
}
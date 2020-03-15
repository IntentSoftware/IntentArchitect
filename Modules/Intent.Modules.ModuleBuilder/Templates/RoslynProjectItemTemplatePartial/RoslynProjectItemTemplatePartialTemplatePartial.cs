using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.VisualStudio;
using Intent.Modules.ModuleBuilder.Api;
using Intent.Modules.ModuleBuilder.Helpers;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;
using static Intent.Modules.ModuleBuilder.Helpers.TemplateHelper;

namespace Intent.Modules.ModuleBuilder.Templates.RoslynProjectItemTemplatePartial
{
    partial class RoslynProjectItemTemplatePartialTemplate : IntentRoslynProjectItemTemplateBase<ICSharpTemplate>, IHasTemplateDependencies
    {
        public const string TemplateId = "Intent.ModuleBuilder.RoslynProjectItemTemplate.Partial";

        public RoslynProjectItemTemplatePartialTemplate(string templateId, IProject project, ICSharpTemplate model) : base(templateId, project, model)
        {
            AddNugetDependency(NugetPackages.IntentModulesCommon);
            AddNugetDependency(NugetPackages.IntentRoslynWeaverAttributes);
            if (!string.IsNullOrWhiteSpace(GetModeler()?.NuGetDependency))
            {
                AddNugetDependency(new NugetPackageInfo(GetModeler().NuGetDependency, GetModeler().NuGetVersion));
            }
        }

        public IList<string> FolderBaseList => new[] { "Templates" }.Concat(Model.GetFolderPath(false).Where((p, i) => (i == 0 && p.Name != "Templates") || i > 0).Select(x => x.Name)).ToList();
        public string FolderPath => string.Join("/", FolderBaseList);
        public string FolderNamespace => string.Join(".", FolderBaseList);

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetadata(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetadata DefineRoslynDefaultFileMetadata()
        {
            return new RoslynDefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "${Model.Name}Partial",
                fileExtension: "cs",
                defaultLocationInProject: "${FolderPath}/${Model.Name}",
                className: "${Model.Name}",
                @namespace: "${Project.Name}.${FolderNamespace}.${Model.Name}"
            );
        }

        public string GetTemplateId()
        {
            return $"{Project.ApplicationName()}.{FolderNamespace}.{Model.Name}";
        }

        public override void BeforeTemplateExecution()
        {
            Project.Application.EventDispatcher.Publish("TemplateRegistrationRequired", new Dictionary<string, string>()
            {
                { "TemplateId", GetTemplateId() },
                { "TemplateType", "C# Template" },
                { "Module Dependency", GetModeler().ModuleDependency },
                { "Module Dependency Version", GetModeler().ModuleVersion },
                { "ModelId", Model.Id }
            });
        }

        private IModelerReference GetModeler()
        {
            return Model.GetFileTemplateSettings().Modeler() != null ? new ModelerReference(Model.GetFileTemplateSettings().Modeler()) : null;
        }

        private string GetModelType()
        {
            var modelType = Model.GetFileTemplateSettings().ModelType() != null ? new ModelerModelType(Model.GetFileTemplateSettings().ModelType()) : null;
            if (Model.GetFileTemplateSettings().CreationMode().IsFileperModel())
            {
                return modelType?.InterfaceName ?? "object";
            }

            return modelType == null ? "object" : $"IList<{modelType.InterfaceName}>";
        }

        //private bool HasDeclaresUsings()
        //{
        //    return Model.GetStereotypeProperty<bool>("Template Settings", "Declare Usings");
        //}

        //private bool HasTemplateDependencies()
        //{
        //    return Model.HasStereotype("Template Dependency");
        //}

        private bool HasDecorators()
        {
            return !string.IsNullOrEmpty(Model.GetExposedDecoratorContractType());
        }

        //private IReadOnlyCollection<TemplateDependencyInfo> GetTemplateDependencyInfos()
        //{
        //    return new TemplateDependencyInfo[0];
        //    //return TemplateHelper.GetTemplateDependencyInfos(this, Model, _templateModels);
        //}

        private string GetConfiguredInterfaces()
        {
            var interfaceList = new List<string>();

            //if (HasDeclaresUsings())
            //{
            //    interfaceList.Add("IDeclareUsings");
            //}

            //if (HasTemplateDependencies())
            //{
            //    interfaceList.Add("IHasTemplateDependencies");
            //}

            if (!string.IsNullOrEmpty(Model.GetExposedDecoratorContractType()))
            {
                interfaceList.Add($"IHasDecorators<{Model.GetExposedDecoratorContractType()}>");
            }

            return interfaceList.Any() ? (", " + string.Join(", ", interfaceList)) : string.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace ModuleTests.ModuleBuilderTests.Templates.Dependencies.DependantB
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    partial class DependantB : IntentProjectItemTemplateBase<IClass>, IHasTemplateDependencies
    {
        public const string TemplateId = "ModuleBuilderTests.DependantB";

        public DependantB(IProject project, IClass model) : base(TemplateId, project, model)
        {
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: "${Model.Name}",
                fileExtension: "txt", // Change to desired file extension.
                defaultLocationInProject: "DependantB"
            );
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully, Signature = Mode.Fully)]
        IEnumerable<ITemplateDependancy> IHasTemplateDependencies.GetTemplateDependencies()
        {
            var templateDependencies = new List<ITemplateDependancy>();
            templateDependencies.AddRange(GetCustomTemplateDependencies());
            return templateDependencies;
        }


        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        private IEnumerable<ITemplateDependancy> GetCustomTemplateDependencies()
        {
            return new ITemplateDependancy[]
            {
            };
        }
    }
}
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
[assembly: IntentTemplate("Intent.ModuleBuilder.RoslynProjectItemTemplate.Partial", Version = "1.0")]

namespace ModuleTests.ModuleBuilderTests.Templates.Other.ListModelTemplate
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    partial class ListModelTemplate : IntentRoslynProjectItemTemplateBase<IList<IClass>>
    {
        public const string TemplateId = "ModuleBuilderTests.ListModelTemplate";

        public ListModelTemplate(IProject project, IList<IClass> model) : base(TemplateId, project, model)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "ListModel",
                fileExtension: "cs",
                defaultLocationInProject: "",
                className: "ListModel",
                @namespace: "${Project.Name}"
            );
        }



    }
}
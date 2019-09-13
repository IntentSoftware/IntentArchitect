﻿using Intent.Modules.Common.Templates;
using Intent.Engine;
using Intent.Templates;

namespace Intent.Modules.VisualStudio.Projects.Templates.ConsoleApp.Program
{
    partial class ConsoleAppProgramTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
        public const string Identifier = "Intent.VisualStudio.Projects.ConsoleApp.Program";

        public ConsoleAppProgramTemplate(IProject project)
            : base(Identifier, project, null)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetadata(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetadata DefineRoslynDefaultFileMetadata()
        {
            return new RoslynDefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"Program",
                fileExtension: "cs",
                defaultLocationInProject: "",
                className: $"Program",
                @namespace: "${Project.Name}"
                );
        }
    }
}

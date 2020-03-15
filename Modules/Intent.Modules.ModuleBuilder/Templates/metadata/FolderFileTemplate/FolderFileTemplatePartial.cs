using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.ModuleBuilder.Api;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Templates.metadata.FolderFileTemplate
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class FolderFileTemplate : IntentProjectItemTemplateBase<IFolder>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "ModuleBuilder.Templates.metadata.FolderFileTemplate";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully, Body = Mode.Ignore)]
        public FolderFileTemplate(IProject project, IFolder model) : base(TemplateId, project, model)
        {
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override ITemplateFileConfig DefineDefaultFileMetadata()
        {
            return new DefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: "${Model.Name}",
                fileExtension: "xml",
                defaultLocationInProject: $"metadata/FolderPath/Elements/{Folder.SpecializationType}"
            );
        }

    }
}
﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Intent.Modelers.Services;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.SoftwareFactory;
using Intent.Engine;
using Intent.Templates;

namespace Intent.Modules.Application.Contracts.Mappings.Templates.MappingProfile
{
    [Description("Intent Applications Contract Mapping Profile Template")]
    public class MappingProfileTemplateRegistrations : ListModelTemplateRegistrationBase<IDTOModel>
    {
        private readonly ApiMetadataProvider _metadataManager;

        public MappingProfileTemplateRegistrations(ApiMetadataProvider metadataManager)
        {
            _metadataManager = metadataManager;

            FilterExpression = "model.MappedClass != null";
        }

        public override string TemplateId => MappingProfileTemplate.IDENTIFIER;

        public override ITemplate CreateTemplateInstance(IProject project, IList<IDTOModel> models)
        {
            return new MappingProfileTemplate(project, models);
        }

        public override IList<IDTOModel> GetModels(IApplication application)
        {
            return _metadataManager.GetDTOs(application.Id).ToList();
        }
    }
}

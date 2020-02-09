﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Intent.Engine;
using Intent.Modelers.Domain.Api;
using Intent.Modules.Common.Registrations;
using Intent.Templates;

namespace Intent.Modules.EntityFrameworkCore.Templates.DbContext
{
    [Description(DbContextTemplate.Identifier)]
    public class DbContextTemplateRegistration : ListModelTemplateRegistrationBase<IClass>
    {
        private readonly IMetadataManager _metadataManager;

        public DbContextTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => DbContextTemplate.Identifier;

        public override ITemplate CreateTemplateInstance(IProject project, IList<IClass> models)
        {
            return new DbContextTemplate(models, project, project.Application.EventDispatcher);
        }

        public override IList<IClass> GetModels(Engine.IApplication application)
        {
            return _metadataManager.GetDomainClasses(application.Id).ToList();
        }
    }
}

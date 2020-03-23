﻿using Intent.Templates;
using System;
using System.ComponentModel;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Services;
using Intent.Modelers.Services.Api;
using Intent.Registrations;
using IApplication = Intent.Engine.IApplication;

namespace Intent.Modules.Application.ServiceCallHandlers.Templates.ServiceCallHandler
{
    [Description(ServiceCallHandlerImplementationTemplate.Identifier)]
    public class ServiceCallHandlerImplementationTemplateRegistrations : IProjectTemplateRegistration
    {
        private readonly ApiMetadataProvider _metadataProvider;

        public ServiceCallHandlerImplementationTemplateRegistrations(ApiMetadataProvider metadataProvider)
        {
            _metadataProvider = metadataProvider;
        }

        public string TemplateId => ServiceCallHandlerImplementationTemplate.Identifier;


        private ITemplate CreateTemplateInstance(IProject project, IServiceModel service, IOperation operationModel)
        {
            return new ServiceCallHandlerImplementationTemplate(project, service, operationModel);
        }

        public void DoRegistration(ITemplateInstanceRegistry registry, IApplication applicationManager)
        {
            var serviceModels = _metadataProvider.GetServices(applicationManager.Id);
            foreach (var serviceModel in serviceModels)
            {
                foreach (var operationModel in serviceModel.Operations)
                {
                    registry.Register(TemplateId, (project) => CreateTemplateInstance(project, serviceModel, operationModel));
                }
            }
        }
    }
}


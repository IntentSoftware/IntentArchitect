﻿using System.ComponentModel;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.Templates.Registrations;

namespace Intent.Modules.Autofac.Templates.AutofacConfig
{
    [Description(AutofacConfigTemplate.Identifier)]
    public class AutofacConfigTemplateRegistration : NoModelTemplateRegistrationBase
    {
        public override string TemplateId => AutofacConfigTemplate.Identifier;

        public override ITemplate CreateTemplateInstance(IProject project)
        {
            return new AutofacConfigTemplate(project, project.Application.EventDispatcher);
        }
    }
}
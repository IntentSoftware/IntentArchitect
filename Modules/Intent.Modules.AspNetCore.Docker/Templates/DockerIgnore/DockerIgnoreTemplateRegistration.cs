﻿using System.ComponentModel;
using Intent.Modules.Common.Registrations;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.Templates.Registrations;

namespace Intent.Modules.AspNetCore.Docker.Templates.DockerIgnore
{
    [Description(DockerIgnoreTemplate.Identifier)]
    public class DockerIgnoreTemplateRegistration : NoModelTemplateRegistrationBase
    {
        public override string TemplateId => DockerIgnoreTemplate.Identifier;

        public override ITemplate CreateTemplateInstance(IProject project)
        {
            return new DockerIgnoreTemplate(project);
        }
    }
}
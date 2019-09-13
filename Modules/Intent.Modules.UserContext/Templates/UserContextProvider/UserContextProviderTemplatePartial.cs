﻿using Intent.Modules.Constants;
using Intent.Modules.UserContext.Templates.UserContextInterface;
using Intent.Engine;
using Intent.Eventing;
using Intent.Templates;
using System.Collections.Generic;
using Intent.Modules.Common;
using Intent.Modules.Common.Plugins;
using Intent.Modules.Common.Templates;
using Intent.Modules.UserContext.Templates.UserContextProviderInterface;

namespace Intent.Modules.UserContext.Templates.UserContextProvider
{
    partial class UserContextProviderTemplate : IntentRoslynProjectItemTemplateBase<object>, ITemplate, IHasTemplateDependencies, IBeforeTemplateExecutionHook
    {
        public const string Identifier = "Intent.UserContext.UserContextProvider";

        private readonly IApplicationEventDispatcher _eventDispatcher;

        public UserContextProviderTemplate(IProject project, IApplicationEventDispatcher eventDispatcher)
            : base (Identifier, project, null)
        {
            _eventDispatcher = eventDispatcher;
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetadata(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetadata DefineRoslynDefaultFileMetadata()
        {
            return new RoslynDefaultFileMetadata(
                       overwriteBehaviour: OverwriteBehaviour.Always,
                       fileName: $"UserContextProvider",
                       fileExtension: "cs",
                       defaultLocationInProject: "Providers",
                       className: "UserContextProvider",
                       @namespace: "${Project.ProjectName}"
                );
        }

        public IEnumerable<ITemplateDependency> GetTemplateDependencies()
        {
            return new List<ITemplateDependency>
            {
                TemplateDependency.OnTemplate(UserContextInterfaceTemplate.Identifier),
            };
        }

        public void BeforeTemplateExecution()
        {
            var userContextProviderInterface = Project.FindTemplateInstance<IHasClassDetails>(UserContextProviderInterfaceTemplate.Identifier);
            var contractTemplate = Project.FindTemplateInstance<IHasClassDetails>(UserContextInterfaceTemplate.Identifier);
            _eventDispatcher.Publish(ContainerRegistrationEvent.EventId, new Dictionary<string, string>()
            {
                { "InterfaceType", $"{userContextProviderInterface.FullTypeName()}<{contractTemplate.FullTypeName()}>" },
                { "ConcreteType",  this.FullTypeName() }
            });
        }
    }
}

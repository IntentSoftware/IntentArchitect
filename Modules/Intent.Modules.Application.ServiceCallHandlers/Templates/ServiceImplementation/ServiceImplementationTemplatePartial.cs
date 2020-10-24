﻿using Intent.Modules.Application.Contracts.Templates.DTO;
using Intent.Modules.Application.Contracts.Templates.ServiceContract;
using Intent.Modules.Application.ServiceCallHandlers.Templates.ServiceCallHandler;
using Intent.Templates;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Services.Api;
using Intent.Modules.Application.Contracts;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp;
using Intent.Modules.Common.Plugins;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.VisualStudio;
using Intent.Modules.Constants;

namespace Intent.Modules.Application.ServiceCallHandlers.Templates.ServiceImplementation
{
    partial class ServiceImplementationTemplate : IntentRoslynProjectItemTemplateBase<ServiceModel>, ITemplate, IHasTemplateDependencies, IHasNugetDependencies, ITemplateBeforeExecutionHook, ITemplatePostCreationHook
    {
        public const string Identifier = "Intent.Application.ServiceCallHandlers.ServiceImplementation";
        public ServiceImplementationTemplate(IProject project, ServiceModel model)
            : base(Identifier, project, model)
        {
        }

        public override void OnCreated()
        {
            base.OnCreated();
            Types.AddClassTypeSource(CSharpTypeSource.Create(ExecutionContext, DTOTemplate.IDENTIFIER, "List<{0}>"));
        }

        //public IEnumerable<ITemplateDependency> GetTemplateDependencies()
        //{
        //    return new[]
        //    {
        //        TemplateDependency.OnModel(ServiceContractTemplate.IDENTIFIER, Model)
        //    }
        //    .Union(Model.Operations.Select(x => TemplateDependency.OnModel(ServiceCallHandlerImplementationTemplate.Identifier, x)).ToArray());
        //}

        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.CommonServiceLocator,
            }
            .Union(base.GetNugetDependencies())
            .ToArray();
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetadata(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetadata DefineRoslynDefaultFileMetadata()
        {
            return new RoslynDefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "${Model.Name}",
                fileExtension: "cs",
                defaultLocationInProject: "ServiceImplementation",
                className: "${Model.Name}",
                @namespace: "${Project.ProjectName}"

                );
        }

        public override void BeforeTemplateExecution()
        {
            ExecutionContext.EventDispatcher.Publish(ContainerRegistrationEvent.EventId, new Dictionary<string, string>()
            {
                { "InterfaceType", GetServiceInterfaceName()},
                { "ConcreteType", $"{Namespace}.{ClassName}" },
                { "InterfaceTypeTemplateId", ServiceContractTemplate.IDENTIFIER },
                { "ConcreteTypeTemplateId", Identifier }
            });
        }

        private string GetOperationDefinitionParameters(OperationModel o)
        {
            if (!o.Parameters.Any())
            {
                return "";
            }
            return o.Parameters.Select(x => $"{GetTypeName(x.TypeReference)} {x.Name}").Aggregate((x, y) => x + ", " + y);
        }

        private string GetOperationCallParameters(OperationModel o)
        {
            if (!o.Parameters.Any())
            {
                return "";
            }
            return o.Parameters.Select(x => $"{x.Name}").Aggregate((x, y) => x + ", " + y);
        }

        private string GetOperationReturnType(OperationModel o)
        {
            if (o.TypeReference.Element == null)
            {
                return o.IsAsync() ? "async Task" : "void";
            }
            return o.IsAsync() ? $"async Task<{GetTypeName(o.TypeReference)}>" : GetTypeName(o.TypeReference);
        }

        public string GetServiceInterfaceName()
        {
            var serviceContractTemplate = GetTemplateClassName(TemplateDependency.OnModel<ServiceModel>(ServiceContractTemplate.IDENTIFIER, x => x.Id == Model.Id));
            return serviceContractTemplate;
        }

        private string GetHandlerClassName(OperationModel o)
        {
            var serviceContractTemplate = GetTemplateClassName(TemplateDependency.OnModel<OperationModel>(ServiceCallHandlerImplementationTemplate.Identifier, x => x.Id == o.Id));
            return serviceContractTemplate;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Modelers.Domain.Api;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("ModuleBuilder.Templates.Api.ApiMetadataPackageExtensions", Version = "1.0")]

namespace Intent.Modelers.Domain.Api
{
    public static class ApiMetadataPackageExtensions
    {
        public static IList<DomainPackageModel> GetDomainPackageModels(this IDesigner designer)
        {
            return designer.GetPackagesOfType(DomainPackageModel.SpecializationTypeId)
                .Select(x => new DomainPackageModel(x))
                .ToList();
        }


    }
}
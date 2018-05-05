using Intent.MetaModel.Common;
using Intent.MetaModel.DTO;
using Intent.Modules.Application.Contracts.Templates.DTO;
using Intent.Modules.Constants;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaData;
using Intent.SoftwareFactory.Templates;
using System.Linq;

namespace Intent.Modules.Application.Contracts
{
    public static class CSharpTypeReferenceExtensions
    {
        public static string GetQualifiedName<T>(this ITypeReference typeInfo, T template, string templateIdentifier = DTOTemplate.IDENTIFIER)
            where T: IProjectItemTemplate, IRequireTypeResolver
        {
            var result = typeInfo.Name;
            if (typeInfo.Type == ReferenceType.ClassType)
            {
                var templateInstance = template.Project.Application.FindTemplateInstance<IHasClassDetails>(TemplateDependancy.OnModel<DTOModel>(templateIdentifier, x => x.Id == typeInfo.Id));
                if (templateInstance != null)
                {
                    return $"{templateInstance.Namespace}.{templateInstance.ClassName}";
                }
            }
            else if (typeInfo.Stereotypes.Any(x => x.Name == StandardStereotypes.CSharpType))
            {
                return typeInfo.GetStereotypeProperty<string>(StandardStereotypes.CSharpType, "TypeName") + (typeInfo.IsNullable && typeInfo.GetStereotypeProperty(StandardStereotypes.CSharpType, "IsPrimitive", false) ? "?" : "");
            }
            else if (typeInfo.GetStereotypeProperty<string>(StandardStereotypes.NamespaceProvider, "Namespace") != null)
            {
                return $"{typeInfo.GetStereotypeProperty<string>(StandardStereotypes.NamespaceProvider, "Namespace")}.{typeInfo.Name}";
            }
            else if (typeInfo.Folder?.GetStereotypeProperty<string>(StandardStereotypes.NamespaceProvider, "Namespace") != null)
            {
                return $"{typeInfo.Folder.GetStereotypeProperty<string>(StandardStereotypes.NamespaceProvider, "Namespace")}.{typeInfo.Name}";
            }

            return template.Types.Get(typeInfo);
        }
    }
}
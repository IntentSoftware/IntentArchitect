using System;
using System.Collections.Generic;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using System.Linq;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("ModuleBuilder.Templates.Api.ApiModelImplementationTemplate", Version = "1.0")]
[assembly: DefaultIntentManaged(Mode.Merge)]

namespace Intent.Modules.ModuleBuilder.Api
{
    internal class CreationOption : ICreationOption
    {
        private readonly IElement _element;
        public const string SpecializationType = "Creation Option";

        public CreationOption(IElement element)
        {
            if (element.SpecializationType != SpecializationType)
            {
                throw new ArgumentException($"Invalid element [{element}]");
            }

            _element = element;

            TargetSpecializationType = _element.TypeReference.Element.Name;
            Text = element.Name;
            Shortcut = element.TypeReference.Element.GetStereotypeProperty<string>("Default Creation Options", "Shortcut");
            DefaultName = element.TypeReference.Element.GetStereotypeProperty<string>("Default Creation Options", "Default Name") ?? $"New{element.TypeReference.Element.Name.Replace(" ", "")}";
            Icon = IconModel.CreateIfSpecified(element.TypeReference.Element.GetStereotype("Icon (Full)"));
            Type = element.TypeReference.Element;
            AllowMultiple = element.GetStereotypeProperty("Creation Options", "Allow Multiple", true);
        }

        public string Id => _element.Id;
        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;
        public string Name => _element.Name;
        public string TargetSpecializationType { get; }

        public string Text { get; }

        public string Shortcut { get; }

        public string DefaultName { get; }

        public IconModel Icon { get; }

        public IElement Type { get; }

        public bool AllowMultiple { get; }

        public override string ToString()
        {
            return $"{nameof(SpecializationType)} = '{SpecializationType}', " +
                   $"{nameof(Text)} = '{Text}'";
        }


        protected bool Equals(CreationOption other)
        {
            return Equals(_element, other._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CreationOption)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }
    }
}
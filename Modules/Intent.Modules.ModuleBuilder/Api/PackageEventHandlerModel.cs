using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.RoslynWeaver.Attributes;
using Intent.Modules.Common;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.ModuleBuilder.Api
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class PackageEventHandlerModel : ScriptModel, IMetadataModel, IHasStereotypes, IHasName
    {
        public new const string SpecializationType = "Package Event Handler";
        public new const string SpecializationTypeId = "e59f6c30-69ba-427c-9a73-33d69e44f765";

        public PackageEventHandlerModel(IElement element) : base(element, SpecializationType)
        {
        }

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(PackageEventHandlerModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PackageEventHandlerModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }
    }
}
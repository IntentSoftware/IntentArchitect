using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Intent.Metadata.Models;
using Intent.Modules.Modelers.Domain.Api;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]
[assembly: DefaultIntentManaged(Mode.Merge)]

namespace Intent.Modelers.Domain.Api
{
    public static class GeneralizationAssociationExtensions
    {
    }

    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class ClassModel : IHasStereotypes, IMetadataModel
    {
        private IList<AssociationEndModel> _associatedElements;
        protected readonly IElement _element;
        private readonly ICollection<ClassModel> _childClasses = new List<ClassModel>();
        private readonly ClassModel _parent;

        public ClassModel(IElement element)
        {
            //if (classCache == null)
            //{
            //    classCache = new Dictionary<string, ClassModel>();
            //}
            _element = element;
            //classCache.Add(_element.UniqueKey(), this);
            Folder = Api.Folder.SpecializationType.Equals(_element.ParentElement?.SpecializationType, StringComparison.OrdinalIgnoreCase) ? new Folder(_element.ParentElement) : null;

            //var generalizedFrom = _element.AssociatedElements
            //    .Where(x => "Generalization".Equals(x.Association.SpecializationType, StringComparison.OrdinalIgnoreCase) &&
            //                x.Association.SourceEnd.Element.Id == _element.Id)
            //    .ToArray();
            //if (generalizedFrom.Length > 1)
            //{
            //    throw new Exception($"[{_element.Name} - {_element.Id}] is generalized from more than one class.");
            //}

            //var parent = this.Generalizations().SingleOrDefault()?.Element;
            //if (parent != null)
            //{
            //    _parent = classCache.ContainsKey(parent.UniqueKey()) ? classCache[parent.UniqueKey()] : new ClassModel(parent, classCache);
            //    _parent._childClasses.Add(this);
            //}

            _associatedElements = this.AssociatedToClasses()
                .Concat(this.AssociatedFromClasses().Where(x => x.OtherEnd().Element.Id != Id))
                .ToList();
            //_associatedElements = element.AssociatedElements
            //    .Where(x => "Composition".Equals(x.Association.SpecializationType, StringComparison.OrdinalIgnoreCase)
            //    || "Aggregation".Equals(x.Association.SpecializationType, StringComparison.OrdinalIgnoreCase))
            //    .Where(end => !(end.Association.TargetEnd.Element.Equals(end.Association.SourceEnd.Element) && end == end.Association.SourceEnd))
            //    .Select(x =>
            //    {
            //        var association = new Association(x.Association, classCache);
            //        return Equals(association.TargetEnd.Class, this) && !association.IsSelfReference() ? association.SourceEnd : association.TargetEnd;
            //    })
            //    .ToList();
        }

        public string UniqueKey => $"{_element.Application.Id}_{Id}";

        [IntentManaged(Mode.Fully)]
        public string Id => _element.Id;

        [IntentManaged(Mode.Fully)]
        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;
        public IFolder Folder { get; }

        [IntentManaged(Mode.Fully)]
        public string Name => _element.Name;
        public bool IsAbstract => _element.IsAbstract;
        public IEnumerable<string> GenericTypes => _element.GenericTypes.Select(x => x.Name);
        public ClassModel ParentClass => this.Generalizations().Select(x => new ClassModel(x.Element)).SingleOrDefault();
        public IEnumerable<ClassModel> ChildClasses => this.Specializations().Select(x => new ClassModel(x.Element)).ToList();
        public bool IsMapped => _element.IsMapped;
        public string Comment => _element.Comment;
        public IElementMapping MappedClass => _element.MappedElement;
        public IElementApplication Application => _element.Application;

        [IntentManaged(Mode.Fully)]
        public IList<AttributeModel> Attributes => _element.ChildElements
            .Where(x => x.SpecializationType == AttributeModel.SpecializationType)
            .Select(x => new AttributeModel(x))
            .ToList();

        [IntentManaged(Mode.Fully)]
        public IList<OperationModel> Operations => _element.ChildElements
            .Where(x => x.SpecializationType == OperationModel.SpecializationType)
            .Select(x => new OperationModel(x))
            .ToList();


        public IEnumerable<AssociationEndModel> AssociatedClasses
        {
            get => _associatedElements;
            set => _associatedElements = (IList<AssociationEndModel>)value;
        }

        public static bool operator ==(ClassModel lhs, ClassModel rhs)
        {
            // Check for null.
            if (ReferenceEquals(lhs, null))
            {
                if (ReferenceEquals(rhs, null))
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles the case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(ClassModel lhs, ClassModel rhs)
        {
            return !(lhs == rhs);
        }

        [IntentManaged(Mode.Fully)]
        public bool Equals(ClassModel other)
        {
            return Equals(_element, other._element);
        }

        [IntentManaged(Mode.Fully)]
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ClassModel)obj);
        }

        [IntentManaged(Mode.Fully)]
        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }


        public const string SpecializationType = "Class";

        [IntentManaged(Mode.Fully)]
        public override string ToString()
        {
            return _element.ToString();
        }

        [IntentManaged(Mode.Fully)]
        public IElement InternalElement => _element;
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Intent.IArchitect.Agent.Persistence.Model.Common
{
    [XmlRoot("settings")]
    public class DesignerSettingsPersistable
    {
        public const string FileExtension = "designer.settings";

        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlArray("packageSettings")]
        [XmlArrayItem("packageSetting")]
        public List<PackageSettingsPersistable> PackageSettings { get; set; } = new List<PackageSettingsPersistable>();

        [XmlArray("elementSettings")]
        [XmlArrayItem("elementSetting")]
        public List<ElementSettingPersistable> ElementSettings { get; set; }

        [XmlArray("associationSettings")]
        [XmlArrayItem("associationSetting")]
        public List<AssociationSettingsPersistable> AssociationSettings { get; set; }

        [XmlArray("elementExtensions")]
        [XmlArrayItem("elementExtension")]
        public List<ElementSettingExtensionPersistable> ElementExtensions { get; set; }

        [XmlElement("stereotypeSettings")]
        public StereotypeSettingsPersistable StereotypeSettings { get; set; }
    }

    public class StereotypeSettingsPersistable
    {
        [XmlAttribute("specializationType")]
        public string SpecializationType { get; set; }

        [XmlArray("targetTypeOptions")]
        [XmlArrayItem("option")]
        public List<StereotypeTargetTypeOption> TargetTypeOptions { get; set; }
    }

    public class StereotypeTargetTypeOption
    {
        [XmlAttribute("specializationType")]
        public string SpecializationType { get; set; }

        [XmlAttribute("displayText")]
        public string DisplayText { get; set; }

        public override string ToString()
        {
            return $"{nameof(SpecializationType)} = '{SpecializationType}', " +
                   $"{nameof(DisplayText)} = '{DisplayText}'";
        }
    }

    public class TypeReferenceSettingPersistable
    {
        [XmlElement("isRequired")]
        public bool IsRequired { get; set; } = true;

        [XmlArray("targetTypes")]
        [XmlArrayItem("type")]
        public string[] TargetTypes { get; set; }

        [XmlElement("defaultTypeId")]
        public string DefaultTypeId { get; set; }

        [XmlElement("allowIsNavigable")]
        public bool AllowIsNavigable { get; set; } = true;

        [XmlElement("allowIsNullable")]
        public bool AllowIsNullable { get; set; } = true;

        [XmlElement("allowIsCollection")]
        public bool AllowIsCollection { get; set; } = true;

        [XmlElement("isNavigableDefault")]
        public bool IsNavigableDefault { get; set; } = true;

        [XmlElement("isNullableDefault")]
        public bool IsNullableDefault { get; set; }

        [XmlElement("isCollectionDefault")]
        public bool IsCollectionDefault { get; set; }
    }

    public class TypeOrderPersistable
    {
        private string _order;

        [XmlText]
        public string Type { get; set; }

        [XmlAttribute("order")]
        public string Order
        {
            get => _order;
            set => _order = int.TryParse(value, out var o) ? o.ToString() : null;
        }

        public override string ToString()
        {
            return $"{nameof(Type)} = '{Type}', " +
                   $"{nameof(Order)} = '{Order}'";
        }
    }

    public class PackageSettingsPersistable
    {
        private List<TypeOrderPersistable> _typeOrder;

        [XmlAttribute("type")]
        public string SpecializationType { get; set; }

        [XmlAttribute("typeId")]
        public string SpecializationTypeId { get; set; }

        [XmlArray("requiredPackages")]
        [XmlArrayItem("package")]
        public string[] RequiredPackages { get; set; } = new string[0];

        [XmlArray("creationOptions")]
        [XmlArrayItem("option")]
        public List<ElementCreationOption> CreationOptions { get; set; }

        [XmlArray("typeOrder")]
        [XmlArrayItem("type")]
        public List<TypeOrderPersistable> TypeOrder
        {
            get => _typeOrder;
            set
            {
                if (value == null)
                {
                    _typeOrder = null;
                    return;
                }

                _typeOrder = value;
                foreach (var typeOrder in value.ToList().Where(x => !string.IsNullOrWhiteSpace(x.Order)))
                {
                    _typeOrder.Remove(typeOrder);
                    _typeOrder.Insert(Math.Max(Math.Min(int.Parse(typeOrder.Order), _typeOrder.Count), 0), typeOrder);
                }
                UpdateTypesOrdering();
            }
        }

        public void AddType(TypeOrderPersistable typeOrder)
        {
            TypeOrder.Add(typeOrder);
            UpdateTypesOrdering();
        }

        private void UpdateTypesOrdering()
        {
            _typeOrder = TypeOrder.Select((x, index) => new TypeOrderPersistable()
            {
                Type = x.Type,
                Order = !string.IsNullOrWhiteSpace(x.Order) ? x.Order : index.ToString()
            }).OrderBy(x => int.Parse(x.Order)).ThenBy(x => x.Type).ToList();
        }
    }

    public class ElementCreationOption
    {
        [XmlAttribute("order")]
        public string Order { get; set; }

        [XmlAttribute("type")]
        public ElementType Type { get; set; }

        [XmlElement("specializationType")]
        public string SpecializationType { get; set; }

        [XmlElement("specializationTypeId")]
        public string SpecializationTypeId { get; set; }

        [XmlElement("text")]
        public string Text { get; set; }

        [XmlElement("shortcut")]
        public string Shortcut { get; set; }

        [XmlElement("defaultName")]
        public string DefaultName { get; set; }

        [XmlElement("icon")]
        public IconModelPersistable Icon { get; set; }

        [XmlElement("allowMultiple")]
        public bool AllowMultiple { get; set; } = true;

        public override string ToString()
        {
            return $"{nameof(SpecializationType)} = '{SpecializationType}', " +
                   $"{nameof(Text)} = '{Text}'";
        }
    }

    public enum ElementType
    {
        [XmlEnum("n/a")]
        NotApplicable = -1,
        [XmlEnum("element")]
        Element = 0,
        [XmlEnum("association")]
        Association = 1,
        [XmlEnum("stereotype-definition")]
        StereotypeDefinition = 2
    }
}
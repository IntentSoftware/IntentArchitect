﻿using System.Xml.Serialization;

namespace Intent.IArchitect.Agent.Persistence.Model.Common
{
    public class AssociationSettingsPersistable
    {
        [XmlElement("specializationType")]
        public string SpecializationType { get; set; }

        [XmlElement("icon")]
        public IconModelPersistable Icon { get; set; }

        [XmlElement("sourceEnd")]
        public AssociationEndSettingsPersistable SourceEnd { get; set; }

        [XmlElement("targetEnd")]
        public AssociationEndSettingsPersistable TargetEnd { get; set; }

        public override string ToString()
        {
            return $"{nameof(SpecializationType)} = '{SpecializationType}'";
        }
    }

    public class AssociationEndSettingsPersistable
    {
        [XmlArray("targetTypes")]
        [XmlArrayItem("type")]
        public string[] TargetTypes { get; set; }

        [XmlElement("isNavigableEnabled")]
        public bool? IsNavigableEnabled { get; set; }

        [XmlElement("isNullableEnabled")]
        public bool? IsNullableEnabled { get; set; }

        [XmlElement("isCollectionEnabled")]
        public bool? IsCollectionEnabled { get; set; }

        [XmlElement("isNavigableDefault")]
        public bool? IsNavigableDefault { get; set; }

        [XmlElement("isNullableDefault")]
        public bool? IsNullableDefault { get; set; }

        [XmlElement("isCollectionDefault")]
        public bool? IsCollectionDefault { get; set; }
    }
}
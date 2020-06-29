﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Intent.IArchitect.Common.Types;

namespace Intent.IArchitect.Agent.Persistence.Model.Common
{
    [XmlRoot("config")]
    public class ApplicationDesignerPersistable
    {
        public const string FileExtension = "designer.config";

        //public static ApplicationDesignerPersistable Create(ApplicationDesignerSettingsPersistable installation, string filePath)
        //{
        //    return new ApplicationDesignerPersistable
        //    {
        //        Id = installation.Target,
        //        Name = installation.Name,
        //        Icon = installation.Icon,
        //        Order = installation.DisplayOrder,
        //        LoadStartPage = false,
        //        AbsolutePath = filePath
        //    };
        //}
        public ApplicationDesignerPersistable(string id, string name, int order, IconModelPersistable icon, bool loadStartPage)
        {
            Id = id;
            Name = name;
            Order = order;
            Icon = icon;
            LoadStartPage = loadStartPage;
        }

        //[XmlElement("icon")]
        //[XmlIgnore]
        //public IconModelPersistable Icon => Designer.Icon;
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        //[XmlAttribute("location")]
        //public string RelativeLocation { get; set; }

        [XmlElement("order")]
        public int Order { get; set; }

        private IconModelPersistable _icon;
        [XmlElement("icon")]
        public IconModelPersistable Icon
        {
            get
            {
                if (_icon != null)
                {
                    return _icon;
                }

                return (_icon = new IconModelPersistable { Type = IconType.FontAwesome, Source = "question-circle" });
            }
            set => _icon = value;
        }

        [XmlElement("loadStartPage")]
        public bool LoadStartPage { get; set; }

        [XmlArray("designerReferences")]
        [XmlArrayItem("designerReference")]
        public List<DesignerSettingsReference> DesignerReferences { get; set; } = new List<DesignerSettingsReference>();


        [XmlArray("packageReferences")]
        [XmlArrayItem("packageReference")]
        public List<PackageReferenceModel> PackageReferences { get; set; } = new List<PackageReferenceModel>();

    }

    public class DesignerSettingsReference
    {
        //private string _relativePath;
        //private string _absolutePath;

        public static DesignerSettingsReference Create(string id, string name, string module)
        {
            return new DesignerSettingsReference
            {
                Id = id,
                Name = name,
                Module = module,
            };
        }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("module")]
        public string Module { get; set; }

        //[XmlElement("path")]
        //public string RelativePath
        //{
        //    get => _relativePath;
        //    set => _relativePath = value.EnsureUsesForwardSlashPathSeparator();
        //}

        //[XmlIgnore]
        //public string AbsolutePath
        //{
        //    get => _absolutePath;
        //    set => _absolutePath = value.EnsureUsesForwardSlashPathSeparator();
        //}
    }

    public class PackageReferenceModel //: IEquatable<PackageReferenceModel>
    {
        private string _absolutePath;
        private string _relativePath;

        [XmlAttribute("packageId")]
        public string PackageId { get; set; }

        [XmlAttribute("include")]
        public string Name { get; set; }

        [XmlAttribute("isExternal")]
        public bool IsExternal { get; set; }

        [XmlElement("module")]
        public string Module { get; set; }

        //[XmlElement("path")]
        //public string RelativePath
        //{
        //    get => _relativePath;
        //    set => _relativePath = value.EnsureUsesForwardSlashPathSeparator();
        //}

        //[XmlIgnore]
        //public string AbsolutePath
        //{
        //    get => _absolutePath;
        //    set => _absolutePath = value.EnsureUsesForwardSlashPathSeparator();
        //}

        //public override string ToString()
        //{
        //    return $"{Name} - \"{AbsolutePath}\"";
        //}

        //public bool Equals(PackageReferenceModel other)
        //{
        //    if (ReferenceEquals(null, other)) return false;
        //    if (ReferenceEquals(this, other)) return true;
        //    return string.Equals(RelativePath, other.RelativePath);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(null, obj)) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (obj.GetType() != this.GetType()) return false;
        //    return Equals((PackageReferenceModel)obj);
        //}

        //public override int GetHashCode()
        //{
        //    return (RelativePath != null ? RelativePath.GetHashCode() : 0);
        //}
    }
}

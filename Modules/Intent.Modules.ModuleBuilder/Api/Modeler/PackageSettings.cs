﻿using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;

namespace Intent.Modules.ModuleBuilder.Api.Modeler
{
    public class PackageSettings
    {
        public const string SpecializationType = "Package Settings";

        public PackageSettings(IElement element)
        {
            if (element.SpecializationType != SpecializationType)
            {
                throw new ArgumentException($"Invalid element [{element}]");
            }

            CreationOptions = element.ChildElements.SingleOrDefault(x => x.SpecializationType == "Creation Options")?.Attributes.Select(x => new CreationOption(x)).ToList();
        }

        public IList<CreationOption> CreationOptions { get; set; }
        public IList<TypeOrder> TypeOrder { get; set; }
    }
}
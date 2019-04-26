﻿using System.ComponentModel;
using Intent.Modules.Common.Registrations;
using Intent.Modules.Entities.Templates.DomainEntityInterface;
using Intent.Engine;
using Intent.Registrations;

namespace Intent.Modules.Entities.Keys.Decorators
{
    [Description(SurrogatePrimaryKeyInterfaceDecorator.Identifier)]
    public class SurrogatePrimaryKeyInterfaceDecoratorRegistration : DecoratorRegistration<DomainEntityInterfaceDecoratorBase>
    {
        public override string DecoratorId => SurrogatePrimaryKeyInterfaceDecorator.Identifier;

        public override object CreateDecoratorInstance(IApplication application)
        {
            return new SurrogatePrimaryKeyInterfaceDecorator();
        }
    }
}

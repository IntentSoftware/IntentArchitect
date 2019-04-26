﻿using System.ComponentModel;
using Intent.Modules.Common.Registrations;
using Intent.Modules.Entities.Templates.DomainEntityState;
using Intent.Engine;
using Intent.Registrations;

namespace Intent.Modules.Entities.Keys.Decorators
{
    [Description(SurrogatePrimaryKeyEntityStateDecorator.Identifier)]
    public class SurrogatePrimaryKeyEntityStateDecoratorRegistration : DecoratorRegistration<DomainEntityStateDecoratorBase>
    {
        public override string DecoratorId => SurrogatePrimaryKeyEntityStateDecorator.Identifier;

        public override object CreateDecoratorInstance(IApplication application)
        {
            return new SurrogatePrimaryKeyEntityStateDecorator();
        }
    }
}

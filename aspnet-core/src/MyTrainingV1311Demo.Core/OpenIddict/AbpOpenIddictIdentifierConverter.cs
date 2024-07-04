﻿using Abp.Dependency;
using System;

namespace MyTrainingV1311Demo.OpenIddict
{
    public class AbpOpenIddictIdentifierConverter : ITransientDependency
    {
        public virtual Guid FromString(string identifier)
        {
            return string.IsNullOrEmpty(identifier) ? default : Guid.Parse(identifier);
        }

        public virtual string ToString(Guid identifier)
        {
            return identifier.ToString("D");
        }
    }

}

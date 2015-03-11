using System;
using FluentNHibernate.Automapping;

namespace Symentesis.Tools.Sqlite
{
    public class StoreConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "Symentesis.Entitties";
        }
    }
}
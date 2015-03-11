using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Mapping;
using Symentesis.Entitties;

namespace Symentesis.Tools.Nhibernate
{
    public class HistorialOverrride : IAutoMappingOverride<Historial>
    {
        public void Override(AutoMapping<Historial> mapping)
        {
//            mapping.HasOne(x => x.Paciente).Cascade.All();
        }
    }
}
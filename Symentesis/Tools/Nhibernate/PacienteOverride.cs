using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Mapping;
using Symentesis.Entitties;

namespace Symentesis.Tools.Nhibernate
{
    public class PacienteOverride : IAutoMappingOverride<Paciente>
    {
        public void Override(AutoMapping<Paciente> mapping)
        {
        }
    }
}

using System;
using Symentesis.Tools;

namespace Symentesis.Entitties
{
    public class Historial
    {
        public virtual Guid Id { get; set; }
        public virtual Guid Doctor { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual Activity Accion { get; set; }
        public virtual string Detalles { get; set; }
    }
}

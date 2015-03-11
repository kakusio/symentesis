using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;

namespace Symentesis.Entitties
{
    public class Paciente
    {
        public virtual Guid Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Cedula { get; set; }
        public virtual DateTime FechaNacimiento { get; set; }
        public virtual string Ocupacion { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Genero { get; set; }
        public virtual string Foto { get; set; }
//        public virtual List<History> HistorialAcciones { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using NHibernate;
using Symentesis.Entitties;

namespace Symentesis.Tools.Sqlite
{
    public class DataFactory
    {
        public static void InicialData()
        {
            SessionFactory.Instance.ResetDataBase();
            var session = SessionFactory.Instance.GetSession();

            var pacientes = InicialPacientes(session);
            var historiales = InicialHistoriales(session, pacientes);
        }

        private static IEnumerable<Historial> InicialHistoriales(ISession session, IEnumerable<Paciente> pacientes)
        {
            var pList = pacientes as IList<Paciente> ?? pacientes.ToList();
            var historiales = new List<Historial>
            {
                new Historial
                {
                    Paciente = pList.FirstOrDefault(),
                    Detalles = "yolo"
                },
                new Historial
                {
                    Paciente = pList.FirstOrDefault(),
                    Detalles = "yolo"
                },
                new Historial
                {
                    Paciente = pList.FirstOrDefault(),
                    Detalles = "yolo"
                }
            };
            historiales.ForEach(historial => session.Save(historial));
            session.Flush();

            var queryOver = session.QueryOver<Historial>();
            return queryOver.List<Historial>().ToList();
        }

        private static IEnumerable<Paciente> InicialPacientes(ISession session)
        {
            // Create a Product...
            var pasientes = new List<Paciente>
            {
                new Paciente {
                    Nombre = "Some C# Book",
                    Apellido = "Books"
                },
                new Paciente {
                    Nombre = "Some ruby Book",
                    Apellido = "Books"
                },
                new Paciente {
                    Nombre = "Some java Book",
                    Apellido = "Books"
                }
            };
            pasientes.ForEach(paciente => session.Save(paciente));
            session.Flush();

            var queryOver = session.QueryOver<Paciente>();
            return queryOver.List<Paciente>().ToList();
        } 
    }
}
using System.Windows;
using Symentesis.Entitties;
using Symentesis.Tools.Sqlite;

namespace Symentesis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataFactory.InicialData();
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var session = SessionFactory.Instance.GetSession();
            var pacientes = session.QueryOver<Paciente>().List();
            DataGridListaPacientes.ItemsSource = pacientes;
        }
    }
}

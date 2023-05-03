using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using To_Do_WPF.To_Do_App;

namespace To_Do_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository repository = Repository.Instance;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = repository.TasksList;
        }

        private void openAddWindow_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addEditWindow = new AddEditWindow();
            addEditWindow.Show();
        }

        private void openEditWindow_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

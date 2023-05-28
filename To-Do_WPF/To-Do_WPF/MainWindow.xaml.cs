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
            AllTasks.ItemsSource = repository.GetTasksList();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(AllTasks.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Category");
            view.GroupDescriptions.Add(groupDescription);
        }

        private ICommand _OpenEditWindowCommand = null;
        public ICommand OpenEditWindowCommand
        => _OpenEditWindowCommand ??= new OpenEditWindowCommand();

        private void openAddWindow_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addEditWindow = new AddEditWindow();
            addEditWindow.Show();
        }

        private void Task_Completed(object sender, RoutedEventArgs e)
        {
            var task = (MyTask)((CheckBox)e.Source).DataContext;
            task.Category = Category.Completed;
            repository.GetTasksList().Remove(task);
            repository.GetTasksList().Add(task);
            task.IsCompleted = true;
            repository.SaveTasksAsJson();
        }

        private void Task_Not_Completed(object sender, RoutedEventArgs e)
        {
            var task = (MyTask)((CheckBox)e.Source).DataContext;
            task.Category = repository.SelectCategory(task.Date);
            repository.GetTasksList().Remove(task);
            repository.GetTasksList().Add(task);
            task.IsCompleted = false;
            repository.SaveTasksAsJson();
        }

        

        void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var task = (MyTask)((ListViewItem)e.Source).DataContext;
            MessageBox.Show($"{task.Note}");
        }
    }
}

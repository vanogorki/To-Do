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
using System.Windows.Shapes;
using To_Do_WPF.To_Do_App;

namespace To_Do_WPF
{
    /// <summary>
    /// Interaction logic for AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {
        Repository repository = Repository.Instance;

        public AddEditWindow()
        {
            InitializeComponent();
        }

        private void addTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            repository.TasksList.Add(new myTask
            {
                Name = addTaskName.Text,
                Date = addTaskDate.SelectedDate.Value.Date.ToShortDateString(),
                Time = addTaskTime.Text.ToString(),
                Reminder = default,
                IsCompleted = false,
                Note = addTaskNote.Text,
            });
            repository.SaveTasksAsJson();
        }
    }
}

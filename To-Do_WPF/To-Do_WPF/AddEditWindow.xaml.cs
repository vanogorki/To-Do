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
using Xceed.Wpf.Toolkit;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public AddEditWindow(object task)
        {
            InitializeComponent();
            MyTask editTask = task as MyTask;
            addTaskName.Text = editTask.Name;
            addTaskDate.SelectedDate = editTask.Date;
            addTaskTime.Text = editTask.Time;
            addTaskNote.Text = editTask.Note;
        }

        private void addTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            var previousTask = repository.TasksList.FirstOrDefault(x => x.Category > SelecetCategory(addTaskDate.SelectedDate));
            repository.TasksList.Insert(previousTask != null ? repository.TasksList.IndexOf(previousTask) : 0, new MyTask
            {
                Id = Guid.NewGuid(),
                Name = addTaskName.Text,
                Date = addTaskDate.SelectedDate,
                Category = SelecetCategory(addTaskDate.SelectedDate),
                Time = addTaskTime.Text,
                Note = addTaskNote.Text
            });
            repository.SaveTasksAsJson();
        }

        private Category SelecetCategory(DateTime? date)
        {
            if (date == DateTime.Now.Date)
            {
                return Category.Today;
            }
            else if (date > DateTime.Now.Date && date <= DateTime.Now.Date.AddDays(7))
            {
                return Category.Week;
            }
            else return Category.Someday;
        }
    }
}

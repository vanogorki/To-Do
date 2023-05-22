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
        MyTask SelectedTask { get; set; }
        public AddEditWindow() 
        {
            InitializeComponent();
        }
        public AddEditWindow(object task)
        {
            InitializeComponent();
            SelectedTask = task as MyTask;
            addTaskName.Text = SelectedTask.Name;
            addTaskDate.SelectedDate = SelectedTask.Date;
            addTaskTime.Text = SelectedTask.Time;
            addTaskNote.Text = SelectedTask.Note;
        }

        private void addTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            if (addTaskName.Text == "")
            {
                System.Windows.MessageBox.Show("Name can't be empty!", "Error!");
                return;
            }
            if (SelectedTask != null)
            {
                repository.TasksList.Remove(SelectedTask);
                var previousTask1 = repository.TasksList.FirstOrDefault(x => x.Category > SelecetCategory(addTaskDate.SelectedDate));
                repository.TasksList.Insert(previousTask1 != null ? repository.TasksList.IndexOf(previousTask1) : 0, new MyTask
                {
                    Id = Guid.NewGuid(),
                    Name = addTaskName.Text,
                    Date = addTaskDate.SelectedDate,
                    Category = SelecetCategory(addTaskDate.SelectedDate),
                    Time = addTaskTime.Text,
                    Note = addTaskNote.Text,
                    IsCompleted = false
                });
                repository.SaveTasksAsJson();
                this.Close();
                return;
            }
            var previousTask = repository.TasksList.FirstOrDefault(x => x.Category > SelecetCategory(addTaskDate.SelectedDate));
            repository.TasksList.Insert(previousTask != null ? repository.TasksList.IndexOf(previousTask) : 0, new MyTask
            {
                Id = Guid.NewGuid(),
                Name = addTaskName.Text,
                Date = addTaskDate.SelectedDate,
                Category = SelecetCategory(addTaskDate.SelectedDate),
                Time = addTaskTime.Text,
                Note = addTaskNote.Text,
                IsCompleted = false
            });
            repository.SaveTasksAsJson();
            this.Close();
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

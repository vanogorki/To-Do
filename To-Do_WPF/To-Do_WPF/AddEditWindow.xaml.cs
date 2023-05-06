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

        private void addTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            repository.TasksList.Add(new myTask
            {
                Name = addTaskName.Text,
                Date = addTaskDate.SelectedDate,
                Category = SelecetCategory(addTaskDate.SelectedDate).ToString(),
                Time = addTaskTime.Text,
                Note = addTaskNote.Text
            });
            repository.SaveTasksAsJson();
        }

        private myTask.category SelecetCategory(DateTime? date)
        {
            if (date == DateTime.Now.Date)
            {
                return myTask.category.Today;
            }
            else if (date > DateTime.Now.Date && date <= DateTime.Now.Date.AddDays(7))
            {
                return myTask.category.Week;
            }
            else return myTask.category.Someday;
        }

        private void addTaskRemider_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

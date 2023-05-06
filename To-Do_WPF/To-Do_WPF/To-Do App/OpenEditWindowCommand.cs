using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace To_Do_WPF.To_Do_App
{
    public class OpenEditWindowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }


        public bool CanExecute(object? parameter)
            => (parameter as myTask) != null;

        public void Execute(object? parameter)
        {
            AddEditWindow addEditWindow = new AddEditWindow();
            addEditWindow.Show();
        }
    }
}

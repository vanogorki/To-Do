using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace To_Do_WPF.To_Do_App
{
    public class MyTask : ObservableObject
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public Category Category { get; set; }
        public string? Time { get; set; }
        public string? Note { get; set; }
        
    }
    public enum Category
    {
        Today,
        Week,
        Someday,
        Completed
    }
}

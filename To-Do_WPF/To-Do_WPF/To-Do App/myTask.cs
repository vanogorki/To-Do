using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace To_Do_WPF.To_Do_App
{
    public class myTask
    {
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Category { get; set; }
        public string? Time { get; set; }
        public string? Note { get; set; }
        public enum category
        {
            Today,
            Week,
            Someday,
            Completed
        }
    }
}

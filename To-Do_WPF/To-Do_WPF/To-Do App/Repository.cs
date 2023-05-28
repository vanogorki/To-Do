using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using To_Do_WPF.To_Do_App;

namespace To_Do_WPF.To_Do_App
{
    public sealed class Repository
    {
        private static Repository instance = null;
        private ObservableCollection<MyTask> Tasks = null;

        private Repository() { }

        public static Repository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Repository();
                }
                return instance;
            }
        }
        public ObservableCollection<MyTask> GetTasksList()
        {
            if (Tasks != null)
            {
                return Tasks;
            }
            Tasks = new ObservableCollection<MyTask>(JsonConvert.DeserializeObject<List<MyTask>>(File.ReadAllText("Tasks.json")).OrderBy(x => x.Category));
            foreach (var task in Tasks)
            {
                if (task.Category != Category.Completed)
                {
                    task.Category = SelectCategory(task.Date);
                }
            }
            return Tasks;
        }
        public void SaveTasksAsJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = System.Text.Json.JsonSerializer.Serialize(GetTasksList(), options);
            File.WriteAllText("Tasks.json", json);
        }
        public Category SelectCategory(DateTime? date)
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



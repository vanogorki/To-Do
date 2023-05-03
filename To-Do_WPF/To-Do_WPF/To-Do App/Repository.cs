using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace To_Do_WPF.To_Do_App
{
    public sealed class Repository
    {
        private static Repository instance = null;

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
        public List<myTask> TasksList = JsonConvert.DeserializeObject<List<myTask>>(File.ReadAllText("Tasks.json"));
        public void SaveTasksAsJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = System.Text.Json.JsonSerializer.Serialize(TasksList, options);
            File.WriteAllText("Tasks.json", json);
        }
    }
}

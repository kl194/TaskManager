using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class SimpleTasksView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string DueDate { get; set; }

        public SimpleTasksView() { }

        public SimpleTasksView(string data)
        {
            string[] values = data.Split('|');
            Id = int.Parse(values[0]);
            Name = values[1];
            Subject = values[2];
            DueDate = values[3];
        }
    }

}

using System;

namespace TaskManager
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Subject { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
        public DateTime? DueDate { get; set; }
        public int Color { get; set; }
        public int Status { get; set; }

        public Tasks() { }

        public Tasks(string data)
        {
            string[] values = data.Split('|');
            Id = values.Length > 0 ? int.Parse(values[0]) : 0;
            Name = values.Length > 1 ? values[1] : "";
            Subject = values.Length > 2 ? int.Parse(values[2]) : 0;
            Description = values.Length > 3 ? values[3] : "";
            CreatedAt = values.Length > 4 ? values[4] : "";
            if (DateTime.TryParse(values[5], out DateTime parsedDate))
            {
                DueDate = parsedDate;
            }
            else
            {
                DueDate = null;
            }
            Color = values.Length > 6 ? int.Parse(values[6]) : 0;
            Status = values.Length > 7 ? int.Parse(values[7]) : 0;
        }
    }
}

namespace TaskManager
{
    public class TasksView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
        public string DueDate { get; set; }
        public string Color { get; set; }
        public int Status { get; set; }

        public TasksView() { }

        public TasksView(string data)
        {
            string[] values = data.Split('|');
            Id = int.Parse(values[0]);
            Name = values[1];
            Subject = values[2];
            Description = values[3];
            CreatedAt = values[4];
            DueDate = values[5];
            Color = values[6];
            Status = int.Parse(values[7]);
        }
    }

}

namespace TaskManager
{
    public class Subjects
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public Subjects() { }
        public Subjects(string data)
        {
            string[] values = data.Split('|');
            Id = int.Parse(values[0]);
            SubjectName = values[1];
        }
    }
}

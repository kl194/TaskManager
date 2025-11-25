using System.Collections.Generic;

namespace TaskManager
{
    public class DataLoader
    {
        #region LoadMain
        public static List<TasksView> LoadTodoView(string dbPath)
        {
            var database = new ClassDataBase();
            var todoView = new List<TasksView>();

            string query = "SELECT id, name, subject, description, created_at, due_date, color, state FROM v_Tasks WHERE state = 1";

            database.Execute<TasksView>(dbPath, query, ref todoView);

            return todoView;
        }
        public static List<TasksView> LoadInProcessView(string dbPath)
        {
            var database = new ClassDataBase();
            var inProcessView = new List<TasksView>();

            string query = "SELECT id, name, subject, description, created_at, due_date, color, state FROM v_Tasks WHERE state = 2";

            database.Execute<TasksView>(dbPath, query, ref inProcessView);

            return inProcessView;
        }
        public static List<TasksView> LoadCompleteView(string dbPath)
        {
            var database = new ClassDataBase();
            var completeView = new List<TasksView>();

            string query = "SELECT id, name, subject, description, created_at, due_date, color, state FROM v_Tasks WHERE state = 3";

            database.Execute<TasksView>(dbPath, query, ref completeView);

            return completeView;
        }
        public static List<Colors> GetColors(string dbPath)
        {
            var db = new ClassDataBase();
            var colors = new List<Colors>();

            string query = "SELECT id, colorname FROM colors;";
            db.Execute<Colors>(dbPath, query, ref colors);

            return colors;
        }
        public static List<Subjects> GetSubjects(string dbPath)
        {
            var db = new ClassDataBase();
            var subjects = new List<Subjects>();

            string query = "SELECT * FROM subjects;";
            db.Execute<Subjects>(dbPath, query, ref subjects);

            return subjects;
        }
        #endregion
        #region LoadSimplified
        public static List<SimpleTasksView> LoadSimpleTodoView(string dbPath)
        {
            var database = new ClassDataBase();
            var todoView = new List<SimpleTasksView>();

            string query = "SELECT id, name, subject, due_date FROM v_Tasks WHERE state = 1";

            database.Execute<SimpleTasksView>(dbPath, query, ref todoView);

            return todoView;
        }
        public static List<SimpleTasksView> LoadSimpleInProcessView(string dbPath)
        {
            var database = new ClassDataBase();
            var inProcessView = new List<SimpleTasksView>();

            string query = "SELECT id, name, subject, due_date FROM v_Tasks WHERE state = 2";

            database.Execute<SimpleTasksView>(dbPath, query, ref inProcessView);

            return inProcessView;
        }
        public static List<SimpleTasksView> LoadSimpleCompleteView(string dbPath)
        {
            var database = new ClassDataBase();
            var completeView = new List<SimpleTasksView>();

            string query = "SELECT id, name, subject, due_date FROM v_Tasks WHERE state = 3";

            database.Execute<SimpleTasksView>(dbPath, query, ref completeView);

            return completeView;
        }
        #endregion
        public static List<Tasks> LoadTask(string dbPath, int Id)
        {
            var database = new ClassDataBase();
            var tasks = new List<Tasks>();

            string query = $"SELECT id, name, subject, description, created_at, due_date, color, state FROM Tasks WHERE id = {Id}";

            database.Execute<Tasks>(dbPath, query, ref tasks);

            return tasks;
        }
    }
}

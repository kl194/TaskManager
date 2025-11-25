using System;

namespace TaskManager
{
    public class DataWriter
    {
        #region Insert
        public static int InsertTask(string dbPath, string name, int subjectId, string description, DateTime? dueDate, int colorId)
        {
            ClassDataBase db = new ClassDataBase();

            string safeName = name.Replace("'", "''");
            string safeDescription = (description ?? "").Replace("'", "''");

            string dueDateStr = dueDate.HasValue ? $"'{dueDate.Value:yyyy-MM-dd HH:mm:ss}'" : "NULL";

            string query = $@"INSERT INTO Tasks (name, subject, description, due_date, color) 
            VALUES ('{safeName}', {subjectId + 1}, '{safeDescription}', {dueDateStr}, {colorId});";

            return db.ExecuteNonQuery(dbPath, query);
        }
        public static int InsertColor(string dbPath, string colorName)
        {
            ClassDataBase db = new ClassDataBase();

            string safeColorName = colorName.Replace("'", "''");

            string query = $@"INSERT INTO colors (colorname)
            VALUES ('{safeColorName}');";

            return db.ExecuteNonQuery(dbPath, query);
        }
        public static int InsertSubject(string dbPath, string subjectName)
        {
            ClassDataBase db = new ClassDataBase();

            string safeSubjectName = subjectName.Replace("'", "''");

            string query = $@"INSERT INTO subjects (subjectname)
            VALUES ('{safeSubjectName}');";

            return db.ExecuteNonQuery(dbPath, query);
        }
        #endregion
        #region Update
        public static int UpdateTask(string dbPath, int Id, string Name, int Subject, string Description, DateTime? dueDate, int color, int status)
        {
            ClassDataBase db = new ClassDataBase();

            string safeName = Name.Replace("'", "''");

            string DueDateStr = dueDate.HasValue ? $"'{dueDate.Value:yyyy-MM-dd HH:mm:ss}'" : "NULL";

            string query = $@"UPDATE Tasks
            SET name = '{Name}', subject = {Subject + 1}, description = '{Description}', due_date = {DueDateStr}, color = {color}, state = {status}
            WHERE id = {Id};";

            return db.ExecuteNonQuery(dbPath, query);
        }
        #endregion
    }
}

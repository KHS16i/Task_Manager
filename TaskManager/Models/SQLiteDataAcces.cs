using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.Models
{
    public class SQLiteDataAcces
    {
        private const string DB_NAME = "task_manager.db";
        private readonly string cs = @"URI=file:" + Application.StartupPath + "\\task_manager.db";
        SQLiteDataReader dr;


        public static void CreateDB()
        {
            if (!System.IO.File.Exists(DB_NAME))
            {
                SQLiteConnection.CreateFile(DB_NAME);

                try
                {
                    using (var cnx = new SQLiteConnection(@"Data Source =" + DB_NAME))
                    {
                        cnx.Open();
                        string query = "CREATE TABLE Task (Id INTEGER PRIMARY KEY AUTOINCREMENT, Description VARCHAR(50), State VARCHAR(10), Priority VARCHAR(10), Notes VARCHAR(100), CommitmentDate DATETIME)";

                        using (var command = new SQLiteCommand(query, cnx))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"Error creando la base de datos: {e.Message}");
                }
            }
        }

        public List<Task> GetAllTasks()
        {
            List<Task> tasks = new List<Task>();

            using (var con = new SQLiteConnection(cs))
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = "SELECT Id, Description, State, Priority, Notes, CommitmentDate " +
                        "FROM Task ORDER BY CommitmentDate ASC";

                    try
                    {
                        con.Open();
                        using (dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                tasks.Add(new Task(dr));
                            }
                        }
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine($"Error obteniendo las Tareas: {e.Message}");
                    }

                    return tasks;
                }
            }
        }

        public List<Task> GetFilteredTasks(DateTime commitmentDate, string state, string priority)
        {
            List<Task> tasks = new List<Task>();

            using (var con = new SQLiteConnection(cs))
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = "SELECT Id, Description, State, Priority, Notes, CommitmentDate FROM Task " +
                                      "WHERE (CommitmentDate = @CommitmentDate) AND (State = @State) AND (Priority = @Priority) " +
                                      "ORDER BY CommitmentDate ASC";

                    cmd.Parameters.AddWithValue("@CommitmentDate", commitmentDate);
                    cmd.Parameters.AddWithValue("@State", state);
                    cmd.Parameters.AddWithValue("@Priority", priority);

                    try
                    {
                        con.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                tasks.Add(new Task(dr));
                            }
                        }
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine($"Error obteniendo las Tareas: {e.Message}");
                    }

                    return tasks;
                }
            }
        }

        public bool InsertTask(Task input)
        {
            using (var con = new SQLiteConnection(cs))
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = "INSERT INTO Task (Description, State, Priority, Notes, CommitmentDate) " +
                        "VALUES (@Description, @State, @Priority, @Notes, @CommitmentDate)";

                    cmd.Parameters.AddWithValue("@Description", input.Description);
                    cmd.Parameters.AddWithValue("@State", input.State);
                    cmd.Parameters.AddWithValue("@Priority", input.Priority);
                    cmd.Parameters.AddWithValue("@Notes", input.Notes);
                    cmd.Parameters.AddWithValue("@CommitmentDate", input.CommitmentDate);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine($"Error insertando la Tarea: {e.Message}");
                        return false;
                    }
                }
            }
        }

        public bool EditTask(Task input)
        {
            using (var con = new SQLiteConnection(cs))
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = "UPDATE Task " +
                        "SET Description = @Description, " +
                        "State = @State, " +
                        "Priority = @Priority, " +
                        "Notes = @Notes, " +
                        "CommitmentDate = @CommitmentDate " +
                        "WHERE Id = @Id";

                    cmd.Parameters.AddWithValue("@Id", input.Id);
                    cmd.Parameters.AddWithValue("@Description", input.Description);
                    cmd.Parameters.AddWithValue("@State", input.State);
                    cmd.Parameters.AddWithValue("@Priority", input.Priority);
                    cmd.Parameters.AddWithValue("@Notes", input.Notes);
                    cmd.Parameters.AddWithValue("@CommitmentDate", input.CommitmentDate);

                    try
                    {
                        cmd.Prepare();
                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine($"Error insertando la Tarea: {e.Message}");
                        return false;
                    }
                }
            }
        }

        public bool DeleteTask(int Id)
        {
            using (var con = new SQLiteConnection(cs))
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = "DELETE FROM Task WHERE Id = @Id";

                    cmd.Parameters.AddWithValue("@Id", Id);

                    try
                    {
                        cmd.Prepare();
                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine($"Error eliminando la Tarea: {e.Message}");
                        return false;
                    }
                }
            }
        }
    }
}

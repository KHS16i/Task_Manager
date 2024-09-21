using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Models;
namespace TaskManager.Views
{
    [POCOViewModel]
    public class TaskMaintenanceViewModel
    {
        #region GLOBAL VARIABLES

        SQLiteDataAcces sqlite = new SQLiteDataAcces();
        public List<Task> tasks = new List<Task>();

        #endregion

        public TaskMaintenanceViewModel()
        {
            //Creacion de la Base de Datos
            SQLiteDataAcces.CreateDB();

            //tasks = sqlite.GetAllTasks();
        }

        public List<Task> GetAll()
        {
            return sqlite.GetAllTasks();
        }

        public List<Task> GetFiltered(DateTime date, string state, string priority)
        {
            return sqlite.GetFilteredTasks(date, state, priority);
        }

        public bool Create(Task task)
        {
            return sqlite.InsertTask(task);
        }

        public bool Edit(Task task)
        {
            return sqlite.EditTask(task);
        }

        public bool Delete(int Id)
        {
            return sqlite.DeleteTask(Id);
        }
    }
}
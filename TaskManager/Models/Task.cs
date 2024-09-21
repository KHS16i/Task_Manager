using System;
using System.ComponentModel;
using System.Data;


namespace TaskManager.Models
{
    public class Task
    {
        private int _id;
        private string _description, _state, _priority, _notes;
        private DateTime _commitmentDate;

        public Task()
        {
        }

        public Task(IDataReader reader)
        {
            _id = Convert.ToInt32(reader["Id"]);
            _description = reader["Description"].ToString();
            _state = reader["State"].ToString();
            _priority = reader["Priority"].ToString();
            _notes = reader["Notes"].ToString();
            _commitmentDate = Convert.ToDateTime(reader["CommitmentDate"]);
        }

        public Task(string description, string state, string priority, string notes, DateTime commitmentDate)
        {
            _description = description;
            _state = state;
            _priority = priority;
            _notes = notes;
            _commitmentDate = commitmentDate;
        }

        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public string State { get => _state; set => _state = value; }
        public string Priority { get => _priority; set => _priority = value; }
        public string Notes { get => _notes; set => _notes = value; }
        public DateTime CommitmentDate { get => _commitmentDate; set => _commitmentDate = value; }
    }
}

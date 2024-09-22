using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaskManager.Helpers;
using TaskManager.Models;

namespace TaskManager.Views
{
    public partial class TaskMaintenance : DevExpress.XtraEditors.XtraUserControl
    {
        #region GLOBAL VARIABLES

        TaskMaintenanceViewModel taskViewModel = new TaskMaintenanceViewModel();
        Task task = new Task();

        #endregion


        #region EVENTS

        public TaskMaintenance()
        {
            InitializeComponent();
        }

        private void TaskMaintenance_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                ShowError(AppTexts.WarningMessageEmptyDesc);
                txtDesc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cbPriority.Text))
            {
                ShowError(AppTexts.WarningMessageEmptyPriority);
                cbPriority.Focus();
                return;
            }

            if (!dtComDate.Text.Contains("/")) // Verificar si la fecha es válida
            {
                ShowError(AppTexts.WarningMessageEmptyDate);
                dtComDate.Focus();
                return;
            }

            task.Description = txtDesc.Text;
            task.State = cbState.SelectedItem.ToString(); //Regla de Negocio
            task.Priority = cbPriority.Text;
            task.Notes = txtNotes.Text;
            task.CommitmentDate = Convert.ToDateTime(dtComDate.Text);

            if (taskViewModel.Create(task))
            {
                ShowInfo(AppTexts.InfoMessageTaskAdded);
            }
            else
            {
                ShowError(AppTexts.ErrorMessageCreateTask);
            }
            resetForm();
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAgregar.Enabled = false;
            cbState.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTasks.Rows[e.RowIndex];

                task.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                task.Description = selectedRow.Cells["Description"].Value?.ToString();
                task.State = selectedRow.Cells["State"].Value?.ToString();
                task.Priority = selectedRow.Cells["Priority"].Value?.ToString();
                task.Notes = selectedRow.Cells["Notes"].Value?.ToString();
                task.CommitmentDate = Convert.ToDateTime(selectedRow.Cells["CommitmentDate"].Value);

                loadFormToEdit();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                ShowError(AppTexts.WarningMessageEmptyDesc);
                txtDesc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cbPriority.Text))
            {
                ShowError(AppTexts.WarningMessageEmptyPriority);
                cbPriority.Focus();
                return;
            }

            if (!dtComDate.Text.Contains("/")) // Verificar si la fecha es válida
            {
                ShowError(AppTexts.WarningMessageEmptyDate);
                dtComDate.Focus();
                return;
            }

            if (task.State.Equals("PENDIENTE") || task.State.Equals("EN PROCESO"))
            {
                task.Description = txtDesc.Text;
                task.State = cbState.Text;
                task.Priority = cbPriority.Text;
                task.Notes = txtNotes.Text;
                task.CommitmentDate = Convert.ToDateTime(dtComDate.Text);

                if (taskViewModel.Edit(task))
                {
                    resetForm();

                    btnAgregar.Enabled = true;
                    cbState.Enabled = false;

                    ShowInfo(AppTexts.InfoMessageTaskEdited);
                }
                else
                {
                    ShowError(AppTexts.ErrorMessageCreateTask);
                }
            }
            else
            {
                ShowError(AppTexts.ErrorMessageCantUpdateForState);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AskYesNo(AppTexts.WarningMessageDeleteTask))
            {
                if (!task.State.Equals("EN PROCESO"))
                {
                    if (taskViewModel.Delete(task.Id))
                    {
                        resetForm();

                        btnAgregar.Enabled = true;
                        cbState.Enabled = false;

                        ShowInfo(AppTexts.InfoMessageTaskDeleted);
                    }
                    else
                    {
                        ShowError(AppTexts.ErrorMessageDeleteTask);
                    }
                }
                else
                {
                    ShowError(AppTexts.ErrorMessageCantDeleteForState);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTasks.DataSource = taskViewModel.GetFiltered(Convert.ToDateTime(dtSearch.Text), cbStateSearch.Text, cbPriorSearch.Text);
        }

        #endregion


        #region METHODS

        public void loadDgv()
        {
            dgvTasks.AutoGenerateColumns = false;
            dgvTasks.DataSource = taskViewModel.GetAll();

            dgvTasks.Columns[0].DataPropertyName = "Id";
            dgvTasks.Columns[1].DataPropertyName = "Description";
            dgvTasks.Columns[2].DataPropertyName = "State";
            dgvTasks.Columns[3].DataPropertyName = "Priority";
            dgvTasks.Columns[4].DataPropertyName = "Notes";
            dgvTasks.Columns[5].DataPropertyName = "CommitmentDate";

            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.RowHeadersVisible = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAgregar.Enabled = true;

            txtDesc.Focus();
            cbState.Enabled = false;
            cbState.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            dtComDate.Text = DateTime.Today.ToShortDateString();
            dtComDate.Properties.MinValue = DateTime.Today;


            dtSearch.Text = DateTime.Today.ToShortDateString();
            cbStateSearch.SelectedIndex = 0;
            cbPriorSearch.SelectedIndex = 0;
        }

        public void resetForm()
        {
            txtDesc.Text = string.Empty;
            cbState.Enabled = false;
            txtNotes.Text = string.Empty;
            cbState.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            dtComDate.Text = DateTime.Today.ToShortDateString();
            dgvTasks.ClearSelection();
            loadDgv();
        }

        public void loadFormToEdit()
        {
            txtDesc.Text = task.Description;
            cbState.SelectedItem = task.State;
            cbPriority.SelectedItem = task.Priority;
            txtNotes.Text = task.Notes;
            dtComDate.Text = task.CommitmentDate.ToShortDateString();
        }



        #endregion


        #region MessagesBox

        public void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarning(string message, string title = "Advertencia")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowInfo(string message, string title = "Información")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowQuestion(string message, string title = "Pregunta")
        {
            MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void ShowExclamation(string message, string title = "Advertencia")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool AskYesNo(string message, string title = "Pregunta")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public void ShowOKCancel(string message, string title = "Confirmación")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        #endregion

        
    }
}

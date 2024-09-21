namespace TaskManager.Views
{
    partial class TaskMaintenance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskMaintenance));
            this.dtComDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommitmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.cbPriorSearch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbStateSearch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtSearch = new DevExpress.XtraEditors.DateEdit();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtComDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtComDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriorSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtComDate
            // 
            this.dtComDate.EditValue = null;
            this.dtComDate.Location = new System.Drawing.Point(732, 109);
            this.dtComDate.Name = "dtComDate";
            this.dtComDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtComDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtComDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtComDate.Size = new System.Drawing.Size(302, 32);
            this.dtComDate.TabIndex = 15;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(197, 48);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(302, 32);
            this.txtDesc.TabIndex = 2;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(356, 175);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(416, 67);
            this.txtNotes.TabIndex = 25;
            this.txtNotes.Text = "";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineColor = System.Drawing.Color.Gray;
            this.separatorControl1.Location = new System.Drawing.Point(71, 377);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(963, 19);
            this.separatorControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 22);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Descripción";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(71, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 22);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Estado";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(570, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(145, 22);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Fecha Compromiso";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(570, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 22);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Prioridad";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(280, 197);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 22);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Notas";
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.separatorControl2);
            this.groupControl1.Controls.Add(this.separatorControl3);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.dtSearch);
            this.groupControl1.Controls.Add(this.cbStateSearch);
            this.groupControl1.Controls.Add(this.cbPriorSearch);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnAgregar);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(71, 259);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(963, 98);
            this.groupControl1.TabIndex = 27;
            this.groupControl1.Text = "Acciones";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(890, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDelete.Size = new System.Drawing.Size(52, 51);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(832, 33);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEdit.Size = new System.Drawing.Size(52, 51);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregar.ImageOptions.SvgImage")));
            this.btnAgregar.Location = new System.Drawing.Point(661, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAgregar.Size = new System.Drawing.Size(145, 60);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Nueva Tarea";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(16, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnRefresh.Size = new System.Drawing.Size(52, 51);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbPriority
            // 
            this.cbPriority.EditValue = "";
            this.cbPriority.Location = new System.Drawing.Point(732, 48);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Properties.AutoComplete = false;
            this.cbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPriority.Properties.DropDownRows = 3;
            this.cbPriority.Properties.Items.AddRange(new object[] {
            "BAJA",
            "MEDIA",
            "ALTA"});
            this.cbPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPriority.Size = new System.Drawing.Size(302, 32);
            this.cbPriority.TabIndex = 28;
            // 
            // cbState
            // 
            this.cbState.EditValue = "";
            this.cbState.Location = new System.Drawing.Point(197, 109);
            this.cbState.Name = "cbState";
            this.cbState.Properties.AutoComplete = false;
            this.cbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbState.Properties.DropDownRows = 3;
            this.cbState.Properties.Items.AddRange(new object[] {
            "PENDIENTE",
            "EN PROCESO",
            "FINALIZADA"});
            this.cbState.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbState.Size = new System.Drawing.Size(302, 32);
            this.cbState.TabIndex = 29;
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToOrderColumns = true;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.State,
            this.Priority,
            this.Notes,
            this.CommitmentDate});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTasks.GridColor = System.Drawing.Color.DimGray;
            this.dgvTasks.Location = new System.Drawing.Point(71, 432);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(963, 383);
            this.dgvTasks.TabIndex = 30;
            this.dgvTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // State
            // 
            this.State.HeaderText = "Estado";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 125;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Prioridad";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 125;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notas";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 125;
            // 
            // CommitmentDate
            // 
            this.CommitmentDate.HeaderText = "Fecha Compromiso";
            this.CommitmentDate.MinimumWidth = 6;
            this.CommitmentDate.Name = "CommitmentDate";
            this.CommitmentDate.ReadOnly = true;
            this.CommitmentDate.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnSearch.Location = new System.Drawing.Point(590, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSearch.Size = new System.Drawing.Size(52, 51);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(TaskManager.Views.TaskMaintenanceViewModel);
            // 
            // cbPriorSearch
            // 
            this.cbPriorSearch.EditValue = "";
            this.cbPriorSearch.Location = new System.Drawing.Point(425, 43);
            this.cbPriorSearch.Name = "cbPriorSearch";
            this.cbPriorSearch.Properties.AutoComplete = false;
            this.cbPriorSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPriorSearch.Properties.DropDownRows = 3;
            this.cbPriorSearch.Properties.Items.AddRange(new object[] {
            "BAJA",
            "MEDIA",
            "ALTA"});
            this.cbPriorSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPriorSearch.Size = new System.Drawing.Size(159, 32);
            this.cbPriorSearch.TabIndex = 35;
            // 
            // cbStateSearch
            // 
            this.cbStateSearch.EditValue = "";
            this.cbStateSearch.Location = new System.Drawing.Point(260, 43);
            this.cbStateSearch.Name = "cbStateSearch";
            this.cbStateSearch.Properties.AutoComplete = false;
            this.cbStateSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStateSearch.Properties.DropDownRows = 3;
            this.cbStateSearch.Properties.Items.AddRange(new object[] {
            "PENDIENTE",
            "EN PROCESO",
            "FINALIZADA"});
            this.cbStateSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStateSearch.Size = new System.Drawing.Size(159, 32);
            this.cbStateSearch.TabIndex = 36;
            // 
            // dtSearch
            // 
            this.dtSearch.EditValue = null;
            this.dtSearch.Location = new System.Drawing.Point(95, 43);
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSearch.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtSearch.Size = new System.Drawing.Size(159, 32);
            this.dtSearch.TabIndex = 37;
            // 
            // separatorControl3
            // 
            this.separatorControl3.AutoSizeMode = true;
            this.separatorControl3.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl3.LineColor = System.Drawing.Color.Gray;
            this.separatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl3.Location = new System.Drawing.Point(66, 34);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(19, 50);
            this.separatorControl3.TabIndex = 38;
            // 
            // separatorControl2
            // 
            this.separatorControl2.AutoSizeMode = true;
            this.separatorControl2.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl2.LineColor = System.Drawing.Color.Gray;
            this.separatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl2.Location = new System.Drawing.Point(637, 34);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(19, 50);
            this.separatorControl2.TabIndex = 39;
            // 
            // TaskMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtComDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.separatorControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskMaintenance";
            this.Size = new System.Drawing.Size(1095, 856);
            this.Load += new System.EventHandler(this.TaskMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtComDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtComDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPriorSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.TextEdit txtDesc;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtComDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox txtNotes;
        private DevExpress.XtraEditors.ComboBoxEdit cbPriority;
        private DevExpress.XtraEditors.ComboBoxEdit cbState;
        private System.Windows.Forms.DataGridView dgvTasks;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommitmentDate;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit dtSearch;
        private DevExpress.XtraEditors.ComboBoxEdit cbStateSearch;
        private DevExpress.XtraEditors.ComboBoxEdit cbPriorSearch;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
    }
}

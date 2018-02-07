using System.Windows.Forms;

namespace BindingSource_Example_1.Presentation.Projects
{
    partial class ProjectManagerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label updateDateLabel;
            System.Windows.Forms.Label creatationDateLabel;
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creatationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewProject = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_First = new System.Windows.Forms.Button();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Previous = new System.Windows.Forms.Button();
            this.bt_Last = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_refreshData = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            updateDateLabel = new System.Windows.Forms.Label();
            creatationDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(23, 69);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(23, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // updateDateLabel
            // 
            updateDateLabel.AutoSize = true;
            updateDateLabel.Location = new System.Drawing.Point(23, 202);
            updateDateLabel.Name = "updateDateLabel";
            updateDateLabel.Size = new System.Drawing.Size(71, 13);
            updateDateLabel.TabIndex = 9;
            updateDateLabel.Text = "Update Date:";
            // 
            // creatationDateLabel
            // 
            creatationDateLabel.AutoSize = true;
            creatationDateLabel.Location = new System.Drawing.Point(23, 172);
            creatationDateLabel.Name = "creatationDateLabel";
            creatationDateLabel.Size = new System.Drawing.Size(84, 13);
            creatationDateLabel.TabIndex = 1;
            creatationDateLabel.Text = "Creatation Date:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(113, 69);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(533, 89);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(113, 32);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(487, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(BindingSource_Example_1.Entities.Project);
            // 
            // updateDateDateTimePicker
            // 
            this.updateDateDateTimePicker.Enabled = false;
            this.updateDateDateTimePicker.Location = new System.Drawing.Point(113, 198);
            this.updateDateDateTimePicker.Name = "updateDateDateTimePicker";
            this.updateDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.updateDateDateTimePicker.TabIndex = 10;
            // 
            // creatationDateDateTimePicker
            // 
            this.creatationDateDateTimePicker.Enabled = false;
            this.creatationDateDateTimePicker.Location = new System.Drawing.Point(113, 168);
            this.creatationDateDateTimePicker.Name = "creatationDateDateTimePicker";
            this.creatationDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creatationDateDateTimePicker.TabIndex = 2;
            // 
            // dataGridViewProject
            // 
            this.dataGridViewProject.AutoGenerateColumns = false;
            this.dataGridViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn});
            this.dataGridViewProject.DataSource = this.projectBindingSource;
            this.dataGridViewProject.Location = new System.Drawing.Point(26, 288);
            this.dataGridViewProject.Name = "dataGridViewProject";
            this.dataGridViewProject.Size = new System.Drawing.Size(852, 139);
            this.dataGridViewProject.TabIndex = 11;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 300;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            this.updateDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // bt_First
            // 
            this.bt_First.Location = new System.Drawing.Point(26, 243);
            this.bt_First.Name = "bt_First";
            this.bt_First.Size = new System.Drawing.Size(75, 23);
            this.bt_First.TabIndex = 12;
            this.bt_First.Text = "First";
            this.bt_First.UseVisualStyleBackColor = true;
            this.bt_First.Click += new System.EventHandler(this.bt_First_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.Location = new System.Drawing.Point(107, 243);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(75, 23);
            this.bt_Next.TabIndex = 13;
            this.bt_Next.Text = "Next";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_Previous
            // 
            this.bt_Previous.Location = new System.Drawing.Point(188, 243);
            this.bt_Previous.Name = "bt_Previous";
            this.bt_Previous.Size = new System.Drawing.Size(75, 23);
            this.bt_Previous.TabIndex = 14;
            this.bt_Previous.Text = "Previous";
            this.bt_Previous.UseVisualStyleBackColor = true;
            this.bt_Previous.Click += new System.EventHandler(this.bt_Previous_Click);
            // 
            // bt_Last
            // 
            this.bt_Last.Location = new System.Drawing.Point(269, 243);
            this.bt_Last.Name = "bt_Last";
            this.bt_Last.Size = new System.Drawing.Size(75, 23);
            this.bt_Last.TabIndex = 15;
            this.bt_Last.Text = "Last";
            this.bt_Last.UseVisualStyleBackColor = true;
            this.bt_Last.Click += new System.EventHandler(this.bt_Last_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.projectBindingSource;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(767, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "Id";
            // 
            // bt_refreshData
            // 
            this.bt_refreshData.Location = new System.Drawing.Point(793, 172);
            this.bt_refreshData.Name = "bt_refreshData";
            this.bt_refreshData.Size = new System.Drawing.Size(75, 23);
            this.bt_refreshData.TabIndex = 17;
            this.bt_refreshData.Text = "Refresh";
            this.bt_refreshData.UseVisualStyleBackColor = true;
            this.bt_refreshData.Click += new System.EventHandler(this.bt_refreshData_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(664, 30);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 18;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(664, 67);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 19;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_new
            // 
            this.bt_new.Location = new System.Drawing.Point(664, 106);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 23);
            this.bt_new.TabIndex = 20;
            this.bt_new.Text = "New";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(664, 135);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 21;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(664, 167);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 22;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 516);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_refreshData);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_Last);
            this.Controls.Add(this.bt_Previous);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.bt_First);
            this.Controls.Add(this.dataGridViewProject);
            this.Controls.Add(creatationDateLabel);
            this.Controls.Add(this.creatationDateDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(updateDateLabel);
            this.Controls.Add(this.updateDateDateTimePicker);
            this.Name = "ProjectManagerForm";
            this.Text = "ProjectManagerForm";
            this.Load += new System.EventHandler(this.ProjectManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker updateDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker creatationDateDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Button bt_First;
        private Button bt_Next;
        private Button bt_Previous;
        private Button bt_Last;
        private ComboBox comboBox1;
        private Button bt_refreshData;
        private Button bt_Delete;
        private Button bt_Update;
        private Button bt_new;
        private Button bt_save;
        private Button bt_cancel;
    }
}
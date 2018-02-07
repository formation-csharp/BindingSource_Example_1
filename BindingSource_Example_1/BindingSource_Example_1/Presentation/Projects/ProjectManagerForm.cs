using BindingSource_Example_1.Entities;
using BindingSource_Example_1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSource_Example_1.Presentation.Projects
{
    public partial class ProjectManagerForm : Form
    {
        public ProjectManagerForm()
        {
            InitializeComponent();

            //  this.dataGridViewProject.DataSource = this.bindingSourceProject;
            //  this.dataGridViewProject.AutoGenerateColumns = false;

           this.projectBindingSource.AddingNew += ProjectBindingSource_AddingNew;


        }

        private void ProjectBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {

            Project new_project = new Project();
            new ProjectService().Add(new_project);
            this.RefreshData();


           // Project project = new Project();
           // new ProjectService().Add(project);

           //// e.NewObject = project;
        }

        private void ProjectManagerForm_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {

           //  this.dataGridViewProject.DataSource = this.projectBindingSource;
            this.projectBindingSource.DataSource = new ProjectService().GetData();
            this.projectBindingSource.ResetBindings(true);
           
        }

        private void bt_First_Click(object sender, EventArgs e)
        {
            this.projectBindingSource.MoveFirst();
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            this.projectBindingSource.MoveNext();
        }

        private void bt_Last_Click(object sender, EventArgs e)
        {
            this.projectBindingSource.MoveLast();

        }

        private void bt_Previous_Click(object sender, EventArgs e)
        {
            this.projectBindingSource.MovePrevious();
        }

        private void bt_refreshData_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            this.projectBindingSource.Remove(this.projectBindingSource.Current);
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            // Solution 1 
            // l'objet bindingSource Update automatiquement la class


            // Solution 2 : 
            Project project = this.projectBindingSource.Current as Project;
            project.Title = titleTextBox.Text;
            project.Description = descriptionTextBox.Text;
            new ProjectService().Update(project);


        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            // Solution 1
            //Project new_project = new Project();
            //new ProjectService().Add(new_project);
            //this.RefreshData();


            // Solution 2 
            this.projectBindingSource.AddNew();
            


        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            this.projectBindingSource.EndEdit();
           
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.projectBindingSource.CancelEdit();

        }
    }
}

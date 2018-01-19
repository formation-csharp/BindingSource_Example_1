using BindingSource_Example_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingSource_Example_1.Services
{
    public class ProjectService
    {
        private static List<Project> ListProjects = new List<Project>();

        static ProjectService()
        {
            ListProjects.Add(new Project("Projet1", "Description1"));
            ListProjects.Add(new Project("Projet2", "Description2"));
            ListProjects.Add(new Project("Projet3", "Description3"));

        }

        public List<Project> GetData()
        {
            return ListProjects;
        }

        public  void Update(Project project)
        {
           // Code of Update method

        }
    }
}

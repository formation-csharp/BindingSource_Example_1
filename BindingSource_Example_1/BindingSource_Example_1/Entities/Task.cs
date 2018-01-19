using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingSource_Example_1.Entities
{
    public class Task
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public Project Project { set; get; }
    }
}

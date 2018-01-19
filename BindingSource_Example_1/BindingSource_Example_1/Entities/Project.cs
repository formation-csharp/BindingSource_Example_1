using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingSource_Example_1.Entities
{
    public class Project
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public DateTime CreatationDate { set; get; }
        public DateTime UpdateDate { set; get; }

    }
}

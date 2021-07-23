using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstWorkflow.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}

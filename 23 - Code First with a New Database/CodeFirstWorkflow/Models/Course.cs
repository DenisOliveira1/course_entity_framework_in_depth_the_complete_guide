using CodeFirstWorkflow.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstWorkflow.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public EnumCourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }

    }
}

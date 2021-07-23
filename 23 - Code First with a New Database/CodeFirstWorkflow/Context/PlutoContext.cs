using CodeFirstWorkflow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CodeFirstWorkflow.Context
{
    public class PlutoConext : DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public PlutoConext() : base("name=DefaultConnection")
        {

        }
    }

}

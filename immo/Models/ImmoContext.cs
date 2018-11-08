using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using immo.Models;

namespace EF6Console
{
    public class ImmoContext : DbContext
    {
        public ImmoContext() : base()
        {

        }

        public DbSet<Annonce> Annonce { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
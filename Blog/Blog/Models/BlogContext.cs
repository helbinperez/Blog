using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Blog.Models
{
    //Para utilizar Identity
    //Paso #1: agregar Identity al Context 
    public partial class BlogContext : IdentityDbContext
    {
        public BlogContext()
        {
        }

        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RSFHOUK\\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            //Paso #4 Despues que agrego la migracion (Add-Miggration AddingIdentity). 
            //Agrego base.OnModelCreating(modelBuilder)
            base.OnModelCreating(modelBuilder);

           
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace POSWebAppl.Models.DB_Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Agent_Profile> Agent_Profile { get; set; }
        public virtual DbSet<Customer_Profile> Customer_Profile { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent_Profile>()
                .Property(e => e.Agent_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Agent_Profile>()
                .Property(e => e.Working_Area)
                .IsUnicode(false);

            modelBuilder.Entity<Agent_Profile>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Agent_Profile>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Profile>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Profile>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Profile>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Profile>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Customer_Profile>()
                .Property(e => e.STATE)
                .IsUnicode(false);
        }
    }
}

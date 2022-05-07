using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PapagotiTool.Model
{
    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }

        public virtual DbSet<Floor> Floors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Floor>()
                .Property(e => e.FloorName)
                .IsUnicode(false);
        }
    }
}

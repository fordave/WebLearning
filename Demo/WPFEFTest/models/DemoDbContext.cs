namespace WPFEFTest.models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

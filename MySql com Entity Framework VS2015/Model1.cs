namespace MySql_com_Entity_Framework_VS2015
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<mydemoproduct> mydemoproducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mydemoproduct>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}

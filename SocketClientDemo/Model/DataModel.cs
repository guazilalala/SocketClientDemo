namespace SocketClientDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
    //        modelBuilder.Entity<Model.Devices>()
    //.Property(u => u.ID)
    //.HasColumnName("ID");
        }
        public DbSet<Model.Devices> Devices { get; set; }
    }
}

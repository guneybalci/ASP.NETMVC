namespace Card.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CardContext : DbContext
    {
        public CardContext()
            : base("name=Card")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

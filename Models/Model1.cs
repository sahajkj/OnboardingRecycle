using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnboardingRecycle.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classification>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Classification>()
                .HasMany(e => e.Items)
                .WithMany(e => e.Classifications)
                .Map(m => m.ToTable("Item_Class").MapLeftKey("class_id").MapRightKey("item_id"));

            modelBuilder.Entity<Item>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.method)
                .IsUnicode(false);
        }
    }
}

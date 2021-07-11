namespace Democcccc.Models
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

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<movy> movies { get; set; }
        public virtual DbSet<movies_cmsoon> movies_cmsoon { get; set; }
        public virtual DbSet<tickest_mv> tickest_mv { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<movy>()
                .Property(e => e.MoveID)
                .IsUnicode(false);

            modelBuilder.Entity<movy>()
                .Property(e => e.MovieName)
                .IsUnicode(false);

            modelBuilder.Entity<movy>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<movy>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<movy>()
                .Property(e => e.trailler)
                .IsUnicode(false);

            modelBuilder.Entity<movy>()
                .Property(e => e.duration)
                .IsUnicode(false);

            modelBuilder.Entity<movies_cmsoon>()
                .Property(e => e.MoveID)
                .IsUnicode(false);

            modelBuilder.Entity<movies_cmsoon>()
                .Property(e => e.MovieName)
                .IsUnicode(false);

            modelBuilder.Entity<movies_cmsoon>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<movies_cmsoon>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tickest_mv>()
                .Property(e => e.IdTickets)
                .IsUnicode(false);

            modelBuilder.Entity<tickest_mv>()
                .Property(e => e.MoveID)
                .IsUnicode(false);

            modelBuilder.Entity<tickest_mv>()
                .Property(e => e.Tt_amout)
                .IsUnicode(false);

            modelBuilder.Entity<tickest_mv>()
                .Property(e => e.pay_day)
                .IsUnicode(false);
        }
    }
}

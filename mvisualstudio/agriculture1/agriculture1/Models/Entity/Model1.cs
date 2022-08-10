using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace agriculture1.Models.Entity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model17")
        {
        }

        public virtual DbSet<adviser> adviser { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<dealerr> dealerr { get; set; }
        public virtual DbSet<medicine> medicine { get; set; }
        public virtual DbSet<orders> orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<adviser>()
                .Property(e => e.advisername)
                .IsUnicode(false);

            modelBuilder.Entity<adviser>()
                .Property(e => e.advisersurname)
                .IsUnicode(false);

            modelBuilder.Entity<adviser>()
                .Property(e => e.adviseraddress)
                .IsUnicode(false);

            modelBuilder.Entity<adviser>()
                .Property(e => e.advisercomment)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.cusname)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.cussurname)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.cusadress)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customermail)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customerpassword)
                .IsUnicode(false);

            modelBuilder.Entity<dealerr>()
                .Property(e => e.dealername)
                .IsUnicode(false);

            modelBuilder.Entity<dealerr>()
                .Property(e => e.dealeraddress)
                .IsUnicode(false);

            modelBuilder.Entity<dealerr>()
                .Property(e => e.dealerphone)
                .IsUnicode(false);

            modelBuilder.Entity<dealerr>()
                .Property(e => e.dealeradviser)
                .IsUnicode(false);

            modelBuilder.Entity<medicine>()
                .Property(e => e.medname)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.ordercusname)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.ordercussurname)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.ordermedname)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.orderdealername)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.orderadvisername)
                .IsUnicode(false);

            modelBuilder.Entity<orders>()
                .Property(e => e.ordernumber)
                .IsUnicode(false);
        }
    }
}

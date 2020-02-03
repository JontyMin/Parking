namespace Park.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class db_Park : DbContext
    {
        public db_Park()
            : base("name=db_Park")
        {
        }

        public virtual DbSet<CardRecord> CardRecord { get; set; }
        public virtual DbSet<ParkingLot> ParkingLot { get; set; }
        public virtual DbSet<v_Parking> v_Parking { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardRecord>()
                .Property(e => e.CardID)
                .IsUnicode(false);

            modelBuilder.Entity<ParkingLot>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<v_Parking>()
                .Property(e => e.CardID)
                .IsUnicode(false);

            modelBuilder.Entity<v_Parking>()
                .Property(e => e.Position)
                .IsUnicode(false);
        }
    }
}

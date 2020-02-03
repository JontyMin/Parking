namespace Park.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParkingLot")]
    public partial class ParkingLot
    {
        [Key]
        public int PLID { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        public int State { get; set; }
    }
}

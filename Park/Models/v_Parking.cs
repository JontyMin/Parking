namespace Park.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_Parking
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CRID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CardID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime StartTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EndTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PLID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Position { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int State { get; set; }
    }
}

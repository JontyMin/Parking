namespace Park.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardRecord")]
    public partial class CardRecord
    {
        [Key]
        public int CRID { get; set; }

        [Required]
        [StringLength(50)]
        public string CardID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int PLID { get; set; }
    }
}

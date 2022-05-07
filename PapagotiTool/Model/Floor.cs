namespace PapagotiTool.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Floor")]
    public partial class Floor
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FloorName { get; set; }

        public double? Current { get; set; }

        public double? Energy { get; set; }

        public double? Frequency { get; set; }

        public double? Humidity { get; set; }

        public double? Power { get; set; }

        public double? Voltage { get; set; }

        public DateTime? Time { get; set; }
    }
}

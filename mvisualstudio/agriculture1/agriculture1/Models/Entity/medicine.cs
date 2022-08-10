namespace agriculture1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medicine")]
    public partial class medicine
    {
        [Key]
        public int medıd { get; set; }

        [StringLength(50)]
        public string medname { get; set; }

        public int? medprice { get; set; }
    }
}

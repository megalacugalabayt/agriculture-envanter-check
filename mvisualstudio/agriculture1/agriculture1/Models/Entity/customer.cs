namespace agriculture1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [Key]
        public int customerıd { get; set; }

        [StringLength(50)]
        public string cusname { get; set; }

        [StringLength(50)]
        public string cussurname { get; set; }

        [StringLength(500)]
        public string cusadress { get; set; }

        [StringLength(50)]
        public string customermail { get; set; }

        [StringLength(50)]
        public string customerpassword { get; set; }
    }
}

namespace agriculture1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dealerr")]
    public partial class dealerr
    {
        [Key]
        public int dealerıd { get; set; }

        [StringLength(50)]
        public string dealername { get; set; }

        [StringLength(50)]
        public string dealeraddress { get; set; }

        [StringLength(50)]
        public string dealerphone { get; set; }

        [StringLength(50)]
        public string dealeradviser { get; set; }
    }
}

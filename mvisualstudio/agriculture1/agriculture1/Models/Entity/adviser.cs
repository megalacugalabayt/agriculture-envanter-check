namespace agriculture1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("adviser")]
    public partial class adviser
    {
        [Key]
        public int adviserıd { get; set; }

        [StringLength(50)]
        public string advisername { get; set; }

        [StringLength(50)]
        public string advisersurname { get; set; }

        [StringLength(50)]
        public string adviseraddress { get; set; }

        [StringLength(50)]
        public string advisercomment { get; set; }

        public int? adviserphone { get; set; }
    }
}

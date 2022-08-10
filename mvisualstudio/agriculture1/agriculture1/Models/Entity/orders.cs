namespace agriculture1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class orders
    {
        [Key]
        public int orderıd { get; set; }

        [StringLength(50)]
        public string ordercusname { get; set; }

        [StringLength(50)]
        public string ordercussurname { get; set; }

        [StringLength(50)]
        public string ordermedname { get; set; }

        [StringLength(50)]
        public string orderdealername { get; set; }

        [StringLength(50)]
        public string orderadvisername { get; set; }

        [StringLength(50)]
        public string ordernumber { get; set; }
    }
}

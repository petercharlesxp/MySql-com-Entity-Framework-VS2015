namespace MySql_com_Entity_Framework_VS2015
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("acsm_4d3f887b066b686.mydemoproduct")]
    public partial class mydemoproduct
    {
        public int id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime Creationdate { get; set; }
    }
}

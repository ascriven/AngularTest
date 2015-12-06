namespace AngularTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuItem")]
    public partial class MenuItem
    {
        public int ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public decimal? Cost { get; set; }

        [Column(TypeName = "ntext")]
        public string ImageURL { get; set; }
    }
}

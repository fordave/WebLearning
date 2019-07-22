namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class district_city
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(6)]
        public string cityID { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(6)]
        public string father { get; set; }
    }
}

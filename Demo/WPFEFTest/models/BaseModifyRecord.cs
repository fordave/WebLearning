namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseModifyRecord")]
    public partial class BaseModifyRecord
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string TableCode { get; set; }

        [StringLength(200)]
        public string TableDescription { get; set; }

        [StringLength(50)]
        public string ColumnCode { get; set; }

        [StringLength(200)]
        public string ColumnDescription { get; set; }

        [StringLength(50)]
        public string RecordKey { get; set; }

        [StringLength(50)]
        public string OldKey { get; set; }

        [StringLength(200)]
        public string OldValue { get; set; }

        [StringLength(50)]
        public string NewKey { get; set; }

        [StringLength(200)]
        public string NewValue { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateOn { get; set; }

        [StringLength(20)]
        public string CreateUserId { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }
    }
}

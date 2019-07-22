namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BaseTableColumn
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string TableCode { get; set; }

        [StringLength(200)]
        public string ColumnCode { get; set; }

        [StringLength(50)]
        public string ColumnName { get; set; }

        public int IsPublic { get; set; }

        public int? ColumnAccess { get; set; }

        public int? ColumnEdit { get; set; }

        public int? ColumnDeney { get; set; }

        public int UseConstraint { get; set; }

        [StringLength(50)]
        public string DataType { get; set; }

        [StringLength(400)]
        public string TargetTable { get; set; }

        public int Enabled { get; set; }

        public int AllowEdit { get; set; }

        public int AllowDelete { get; set; }

        public int DeletionStateCode { get; set; }

        public int? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateOn { get; set; }

        [StringLength(20)]
        public string CreateUserId { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedOn { get; set; }

        [StringLength(20)]
        public string ModifiedUserId { get; set; }

        [StringLength(20)]
        public string ModifiedBy { get; set; }
    }
}

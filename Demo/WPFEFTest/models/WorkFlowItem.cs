namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkFlowItem
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string TargetTable { get; set; }

        public short IsTree { get; set; }

        [Required]
        [StringLength(50)]
        public string UseItemCode { get; set; }

        [Required]
        [StringLength(50)]
        public string UseItemName { get; set; }

        [Required]
        [StringLength(50)]
        public string UseItemValue { get; set; }

        public short Enabled { get; set; }

        public short AllowEdit { get; set; }

        public short AllowDelete { get; set; }

        public short DeletionStateCode { get; set; }

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

namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseComment")]
    public partial class BaseComment
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? Worked { get; set; }

        [Column(TypeName = "ntext")]
        public string Contents { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(400)]
        public string TargetURL { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? DeletionStateCode { get; set; }

        public int Enabled { get; set; }

        public int? SortCode { get; set; }

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

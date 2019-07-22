namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseMessage")]
    public partial class BaseMessage
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string FunctionCode { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(50)]
        public string ReceiverDepartmentId { get; set; }

        [StringLength(50)]
        public string ReceiverDepartmentName { get; set; }

        [StringLength(50)]
        public string ReceiverId { get; set; }

        [StringLength(50)]
        public string ReceiverRealname { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Contents { get; set; }

        public int IsNew { get; set; }

        public int ReadCount { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReadDate { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(400)]
        public string TargetURL { get; set; }

        [StringLength(50)]
        public string CreateDepartmentId { get; set; }

        [StringLength(50)]
        public string CreateDepartmentName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? DeletionStateCode { get; set; }

        public int Enabled { get; set; }

        public int? SortCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateOn { get; set; }

        [StringLength(50)]
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

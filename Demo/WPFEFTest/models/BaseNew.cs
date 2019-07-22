namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BaseNew
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string FolderId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(200)]
        public string Source { get; set; }

        [StringLength(500)]
        public string Introduction { get; set; }

        [StringLength(500)]
        public string Keywords { get; set; }

        [Column(TypeName = "text")]
        public string Contents { get; set; }

        public int ReadCount { get; set; }

        public int FileSize { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        public int? HomePage { get; set; }

        public int? SubPage { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [StringLength(20)]
        public string AuditStatus { get; set; }

        public int Enabled { get; set; }

        public int? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int DeletionStateCode { get; set; }

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

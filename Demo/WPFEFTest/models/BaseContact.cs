namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseContact")]
    public partial class BaseContact
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string ParentId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(400)]
        public string Contents { get; set; }

        [StringLength(40)]
        public string Priority { get; set; }

        public int? SendCount { get; set; }

        public int? ReadCount { get; set; }

        public int? ReplyCount { get; set; }

        public int? IsOpen { get; set; }

        [StringLength(40)]
        public string CommentUserId { get; set; }

        [StringLength(40)]
        public string CommentUserRealName { get; set; }

        public DateTime? CommentDate { get; set; }

        public int? DeletionStateCode { get; set; }

        public int? Enabled { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

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

namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseFolder")]
    public partial class BaseFolder
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string ParentId { get; set; }

        [Required]
        [StringLength(200)]
        public string FolderName { get; set; }

        [StringLength(40)]
        public string StateCode { get; set; }

        public int SortCode { get; set; }

        public int AllowEdit { get; set; }

        public int AllowDelete { get; set; }

        public int? IsPublic { get; set; }

        public int Enabled { get; set; }

        public int DeletionStateCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateOn { get; set; }

        [StringLength(40)]
        public string CreateUserId { get; set; }

        [StringLength(40)]
        public string CreateBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedOn { get; set; }

        [StringLength(40)]
        public string ModifiedUserId { get; set; }

        [StringLength(40)]
        public string ModifiedBy { get; set; }
    }
}

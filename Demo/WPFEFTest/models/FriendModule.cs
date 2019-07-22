namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FriendModule")]
    public partial class FriendModule
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(200)]
        public string ImagUrl { get; set; }

        [StringLength(50)]
        public string ImageIndex { get; set; }

        [StringLength(50)]
        public string SelectedImageIndex { get; set; }

        [StringLength(200)]
        public string NavigateUrl { get; set; }

        [StringLength(100)]
        public string Target { get; set; }

        [StringLength(100)]
        public string FormName { get; set; }

        [StringLength(100)]
        public string AssemblyName { get; set; }

        [StringLength(50)]
        public string PermissionItemCode { get; set; }

        [StringLength(500)]
        public string PermissionScopeTables { get; set; }

        public int? SortCode { get; set; }

        public int Enabled { get; set; }

        public int DeletionStateCode { get; set; }

        public int? IsMenu { get; set; }

        public int IsPublic { get; set; }

        public int Expand { get; set; }

        public int IsScope { get; set; }

        public int IsVisible { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastCall { get; set; }

        public int AllowEdit { get; set; }

        public int AllowDelete { get; set; }

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

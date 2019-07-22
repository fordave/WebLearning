namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FriendRole")]
    public partial class FriendRole
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string SystemId { get; set; }

        public int? OrganizeId { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(200)]
        public string RealName { get; set; }

        public int AllowEdit { get; set; }

        public int AllowDelete { get; set; }

        public int IsVisible { get; set; }

        public int? SortCode { get; set; }

        public int DeletionStateCode { get; set; }

        public int Enabled { get; set; }

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

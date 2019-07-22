namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseOrganizeScope")]
    public partial class BaseOrganizeScope
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ResourceCategory { get; set; }

        [StringLength(50)]
        public string ResourceId { get; set; }

        public int? PermissionId { get; set; }

        public short? AllData { get; set; }

        public short? Province { get; set; }

        public short? City { get; set; }

        public short? District { get; set; }

        public short? Street { get; set; }

        public short? UserCompany { get; set; }

        public short? UserSubCompany { get; set; }

        public short? UserDepartment { get; set; }

        public short? UserSubDepartment { get; set; }

        public short? UserWorkgroup { get; set; }

        public short OnlyOwnData { get; set; }

        public short? NotAllowed { get; set; }

        public short? ByDetails { get; set; }

        public short ContainChild { get; set; }

        public short Enabled { get; set; }

        public short DeletionStateCode { get; set; }

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

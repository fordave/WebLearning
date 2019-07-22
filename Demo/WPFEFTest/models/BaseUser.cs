namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUser")]
    public partial class BaseUser
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string UserFrom { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string IDCard { get; set; }

        [StringLength(100)]
        public string QuickQuery { get; set; }

        [StringLength(50)]
        public string SimpleSpelling { get; set; }

        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string SubCompanyId { get; set; }

        [StringLength(50)]
        public string SubCompanyName { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [StringLength(50)]
        public string SubDepartmentId { get; set; }

        [StringLength(50)]
        public string SubDepartmentName { get; set; }

        [StringLength(50)]
        public string WorkgroupId { get; set; }

        [StringLength(50)]
        public string WorkgroupName { get; set; }

        [StringLength(50)]
        public string WorkCategory { get; set; }

        public int? SecurityLevel { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Duty { get; set; }

        [StringLength(50)]
        public string Lang { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Birthday { get; set; }

        public int? Score { get; set; }

        public int? Fans { get; set; }

        [StringLength(200)]
        public string HomeAddress { get; set; }

        [StringLength(200)]
        public string Signature { get; set; }

        [StringLength(50)]
        public string Theme { get; set; }

        public short IsStaff { get; set; }

        public short IsVisible { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string AuditStatus { get; set; }

        public short? Enabled { get; set; }

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

        [StringLength(50)]
        public string PoliceID { get; set; }

        public virtual BaseUserContact BaseUserContact { get; set; }

        public virtual BaseUserLogOn BaseUserLogOn { get; set; }
    }
}

namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseStaff")]
    public partial class BaseStaff
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(100)]
        public string QuickQuery { get; set; }

        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string SubCompanyId { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string WorkgroupId { get; set; }

        [StringLength(50)]
        public string DutyId { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(50)]
        public string Age { get; set; }

        [StringLength(10)]
        public string Height { get; set; }

        [StringLength(10)]
        public string Weight { get; set; }

        [StringLength(50)]
        public string IdentificationCode { get; set; }

        [StringLength(50)]
        public string IDCard { get; set; }

        [StringLength(50)]
        public string Nation { get; set; }

        [StringLength(50)]
        public string Education { get; set; }

        [StringLength(200)]
        public string School { get; set; }

        [StringLength(50)]
        public string Major { get; set; }

        [StringLength(50)]
        public string Degree { get; set; }

        [StringLength(50)]
        public string TitleId { get; set; }

        [StringLength(50)]
        public string TitleDate { get; set; }

        [StringLength(50)]
        public string TitleLevel { get; set; }

        [StringLength(50)]
        public string WorkingDate { get; set; }

        [StringLength(50)]
        public string JoinInDate { get; set; }

        [StringLength(50)]
        public string OfficePostCode { get; set; }

        [StringLength(200)]
        public string OfficeAddress { get; set; }

        [StringLength(50)]
        public string OfficeFax { get; set; }

        [StringLength(50)]
        public string OfficePhone { get; set; }

        [StringLength(50)]
        public string HomePostCode { get; set; }

        [StringLength(50)]
        public string HomeAddress { get; set; }

        [StringLength(50)]
        public string HomeFax { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        [StringLength(50)]
        public string CarCode { get; set; }

        [StringLength(50)]
        public string RewarCard { get; set; }

        [StringLength(50)]
        public string MedicalCard { get; set; }

        [StringLength(50)]
        public string UnionMember { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string ShortNumber { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Extension { get; set; }

        [StringLength(200)]
        public string EmergencyContact { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string DimissionDate { get; set; }

        [StringLength(50)]
        public string DimissionCause { get; set; }

        [StringLength(50)]
        public string DimissionWhither { get; set; }

        [StringLength(100)]
        public string NativePlace { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string BankCode { get; set; }

        [StringLength(50)]
        public string BankUserName { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string CurrentProvince { get; set; }

        [StringLength(50)]
        public string CurrentCity { get; set; }

        [StringLength(50)]
        public string CurrentDistrict { get; set; }

        [StringLength(50)]
        public string Party { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(50)]
        public string WorkingProperty { get; set; }

        [StringLength(50)]
        public string Competency { get; set; }

        [StringLength(50)]
        public string Marriage { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Weddingday { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Divorce { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Childbirthday1 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Childbirthday2 { get; set; }

        public int? IsDimission { get; set; }

        [StringLength(50)]
        public string GraduationDate { get; set; }

        public int DeletionStateCode { get; set; }

        public int Enabled { get; set; }

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

namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseOrganize")]
    public partial class BaseOrganize
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(50)]
        public string ParentName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string StandardName { get; set; }

        [StringLength(50)]
        public string StandardCode { get; set; }

        [StringLength(100)]
        public string QuickQuery { get; set; }

        [StringLength(50)]
        public string SimpleSpelling { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(100)]
        public string OuterPhone { get; set; }

        [StringLength(100)]
        public string InnerPhone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Postalcode { get; set; }

        public int? ProvinceId { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        public int? CityId { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? DistrictId { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        public int? StreetId { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyCode { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string CostCenter { get; set; }

        [StringLength(50)]
        public string FinancialCenter { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        [StringLength(50)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        public int? Layer { get; set; }

        [StringLength(50)]
        public string JoiningMethods { get; set; }

        [StringLength(16)]
        public string Longitude { get; set; }

        [StringLength(16)]
        public string Latitude { get; set; }

        public short ContainChildNodes { get; set; }

        public short IsInnerOrganize { get; set; }

        public int? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public short? DeletionStateCode { get; set; }

        public short Enabled { get; set; }

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

        public int OrganizeType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EffectiveStartTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EffectiveEndTime { get; set; }

        public short EffectiveEnable { get; set; }
    }
}

namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseExportData")]
    public partial class BaseExportData
    {
        [StringLength(40)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyId { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyCode { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [Required]
        [StringLength(50)]
        public string DbCode { get; set; }

        [Required]
        [StringLength(50)]
        public string DataCategory { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [Required]
        [StringLength(200)]
        public string FileName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ProcessingStart { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ProcessingEnd { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ExportSql { get; set; }

        public short Permission { get; set; }

        public short ExportState { get; set; }

        [StringLength(50)]
        public string SeverAddress { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateOn { get; set; }

        [StringLength(40)]
        public string CreateUserId { get; set; }

        [StringLength(40)]
        public string CreateBy { get; set; }
    }
}

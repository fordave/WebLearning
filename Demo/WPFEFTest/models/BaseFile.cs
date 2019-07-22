namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseFile")]
    public partial class BaseFile
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string FolderId { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "image")]
        public byte[] Contents { get; set; }

        public int ReadCount { get; set; }

        public int FileSize { get; set; }

        public int Enabled { get; set; }

        public int DeletionStateCode { get; set; }

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

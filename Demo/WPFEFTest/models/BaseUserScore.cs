namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserScore")]
    public partial class BaseUserScore
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        public int? Score { get; set; }

        [StringLength(20)]
        public string FunctionCode { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(200)]
        public string Contents { get; set; }

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

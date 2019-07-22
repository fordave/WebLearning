namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BaseContactDetail
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string ContactId { get; set; }

        [StringLength(40)]
        public string Category { get; set; }

        [StringLength(40)]
        public string ReceiverId { get; set; }

        [StringLength(40)]
        public string ReceiverRealName { get; set; }

        public int IsNew { get; set; }

        public int NewComment { get; set; }

        [StringLength(40)]
        public string LastViewIP { get; set; }

        [StringLength(40)]
        public string LastViewDate { get; set; }

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

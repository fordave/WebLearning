namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserContact")]
    public partial class BaseUserContact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int EmailValiated { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public int? MobileValiated { get; set; }

        [StringLength(50)]
        public string ShortNumber { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Extension { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string WW { get; set; }

        [StringLength(50)]
        public string WeChat { get; set; }

        public int WeChatValiated { get; set; }

        [StringLength(50)]
        public string YiXin { get; set; }

        public int YiXinValiated { get; set; }

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

        public virtual BaseUser BaseUser { get; set; }
    }
}

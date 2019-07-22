namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseLog")]
    public partial class BaseLog
    {
        [Key]
        public int LogId { get; set; }

        [StringLength(50)]
        public string ProcessId { get; set; }

        [StringLength(200)]
        public string ProcessName { get; set; }

        [StringLength(50)]
        public string MethodId { get; set; }

        [StringLength(800)]
        public string MethodName { get; set; }

        [StringLength(200)]
        public string Parameters { get; set; }

        [Required]
        [StringLength(20)]
        public string UserId { get; set; }

        [StringLength(20)]
        public string UserRealName { get; set; }

        [Required]
        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(800)]
        public string UrlReferrer { get; set; }

        [StringLength(800)]
        public string WebUrl { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateOn { get; set; }
    }
}

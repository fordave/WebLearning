namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseException")]
    public partial class BaseException
    {
        [Key]
        [StringLength(40)]
        public string LogId { get; set; }

        [StringLength(50)]
        public string SystemCode { get; set; }

        public int? EventId { get; set; }

        [StringLength(64)]
        public string Category { get; set; }

        public int? Priority { get; set; }

        [StringLength(32)]
        public string Severity { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public DateTime? Timestamp { get; set; }

        [StringLength(32)]
        public string MachineName { get; set; }

        [StringLength(40)]
        public string IPAddress { get; set; }

        [StringLength(2000)]
        public string AppDomainName { get; set; }

        [StringLength(256)]
        public string ProcessId { get; set; }

        [StringLength(2000)]
        public string ProcessName { get; set; }

        [StringLength(2000)]
        public string ThreadName { get; set; }

        [StringLength(128)]
        public string Win32ThreadId { get; set; }

        [StringLength(2000)]
        public string Message { get; set; }

        [Column(TypeName = "ntext")]
        public string FormattedMessage { get; set; }

        [StringLength(20)]
        public string CreateUserId { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateOn { get; set; }
    }
}

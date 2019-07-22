namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserLogOn")]
    public partial class BaseUserLogOn
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string UserPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string OpenId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AllowStartTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AllowEndTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LockStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LockEndDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstVisit { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PreviousVisit { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastVisit { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ChangePasswordDate { get; set; }

        public int LogOnCount { get; set; }

        [StringLength(20)]
        public string Salt { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? OpenIdTimeout { get; set; }

        public short? MultiUserLogin { get; set; }

        public int ShowCount { get; set; }

        public int PasswordErrorCount { get; set; }

        public short UserOnLine { get; set; }

        public short CheckIPAddress { get; set; }

        [StringLength(50)]
        public string VerificationCode { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string MACAddress { get; set; }

        [StringLength(50)]
        public string Question { get; set; }

        [StringLength(200)]
        public string AnswerQuestion { get; set; }

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

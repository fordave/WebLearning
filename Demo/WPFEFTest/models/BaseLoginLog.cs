namespace WPFEFTest.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseLoginLog")]
    public partial class BaseLoginLog
    {
        public int Id { get; set; }

        public DateTime CreateOn { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string SystemCode { get; set; }

        [StringLength(50)]
        public string LoginStatus { get; set; }

        [StringLength(50)]
        public string MACAddress { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(200)]
        public string IPAddressName { get; set; }
    }
}

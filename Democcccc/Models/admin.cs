namespace Democcccc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookmymovie.admin")]
    public partial class admin
    {
        public int adminId { get; set; }

        [Required]
        [StringLength(10)]
        public string username { get; set; }

        [Required]
        [StringLength(15)]
        public string pass { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string email { get; set; }
    }
}

namespace Democcccc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookmymovie.customer")]
    public partial class customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cid { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Column(TypeName = "tinytext")]
        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "tinytext")]
        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public long Phno { get; set; }
    }
}

namespace Democcccc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookmymovie.movies")]
    public partial class movy
    {
        [Key]
        [StringLength(10)]
        public string MoveID { get; set; }

        [Required]
        [StringLength(30)]
        public string MovieName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Description { get; set; }

        public int? Ratings { get; set; }

        [Required]
        [StringLength(200)]
        public string img { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Required]
        [StringLength(200)]
        public string trailler { get; set; }

        [Required]
        [StringLength(30)]
        public string duration { get; set; }

        public int Room { get; set; }
    }
}

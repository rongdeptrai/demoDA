namespace Democcccc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookmymovie.movies_cmsoon")]
    public partial class movies_cmsoon
    {
        [Key]
        [StringLength(10)]
        public string MoveID { get; set; }

        [Required]
        [StringLength(30)]
        public string MovieName { get; set; }

        [Required]
        [StringLength(200)]
        public string img { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }
    }
}

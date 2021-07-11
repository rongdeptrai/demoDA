namespace Democcccc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookmymovie.tickest_mv")]
    public partial class tickest_mv
    {
        [Key]
        [StringLength(10)]
        public string IdTickets { get; set; }

        public int Cid { get; set; }

        [Required]
        [StringLength(10)]
        public string MoveID { get; set; }

        public int Room { get; set; }

        [Required]
        [StringLength(30)]
        public string Tt_amout { get; set; }

        [Required]
        [StringLength(30)]
        public string pay_day { get; set; }
    }
}

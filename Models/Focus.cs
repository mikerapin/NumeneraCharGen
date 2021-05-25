namespace NumeneraCharGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("numeneradb.foci")]
    public partial class Focus
    {
        [Key]
        public int Focus_id { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        public int? Might { get; set; }

        public int? Speed { get; set; }

        public int? Intellect { get; set; }

        [StringLength(150)]
        public string Power { get; set; }

        [StringLength(150)]
        public string Equipment { get; set; }

        [StringLength(50)]
        public string Page { get; set; }

        public string Description { get; set; }
    }
}

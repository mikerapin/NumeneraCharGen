namespace NumeneraCharGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("numeneradb.types")]
    public partial class Type
    {
        [Key]
        public int Type_id { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        public int? Might { get; set; }

        public int? Speed { get; set; }

        public int? Intellect { get; set; }

        public int? Might_edge { get; set; }

        public int? Speed_edge { get; set; }

        public int? Intellect_edge { get; set; }

        public int? Effort { get; set; }

        [StringLength(150)]
        public string Traits { get; set; }

        [StringLength(150)]
        public string Training { get; set; }

        [StringLength(150)]
        public string Inability { get; set; }

        [StringLength(150)]
        public string Equipment { get; set; }

        public int? Shins { get; set; }

        [StringLength(50)]
        public string Page { get; set; }

        public string Description { get; set; }
    }
}

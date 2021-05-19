namespace NumeneraCharGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("numeneradb.descriptors")]
    public partial class Descriptor
    {
        [Key]
        public int Descriptor_id { get; set; }

        [Required(ErrorMessage = "Descriptor Name is Required.")]
        [StringLength(45)]
        public string Name { get; set; }

        public int? Might { get; set; }

        public int? Speed { get; set; }

        public int? Intellect { get; set; }

        public int? Armor { get; set; }

        public int? Recovery { get; set; }

        [StringLength(150)]
        public string Training { get; set; }

        [StringLength(150)]
        public string Inability { get; set; }

        [StringLength(150)]
        public string Trait { get; set; }

        [StringLength(150)]
        public string Equipment { get; set; }

        public int? Shins { get; set; }

        [StringLength(50)]
        public string Page { get; set; }
    }
}

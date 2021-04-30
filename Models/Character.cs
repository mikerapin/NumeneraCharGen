namespace NumeneraCharGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("numeneradb.characters")]
    public partial class Character
    {
        [Key]
        public int Characrer_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? Descriptor_id { get; set; }

        public int? Type_id { get; set; }

        public int? Focus_id { get; set; }
    }
}

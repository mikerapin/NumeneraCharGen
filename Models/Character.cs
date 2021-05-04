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
        public int Character_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? Descriptor_id { get; set; }

        public int? Type_id { get; set; }

        public int? Focus_id { get; set; }

        [NotMapped]
        public List<Descriptor> DescriptorData { get; set; }

        [NotMapped]
        public List<Type> TypeData { get; set; }

        [NotMapped]
        public List<Focus> FocusData { get; set; }
    }
}

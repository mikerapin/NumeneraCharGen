namespace NumeneraCharGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("numeneradb.abilities")]
    public partial class Ability
    {
        [Key]
        [Column(Order = 0)]
        public int Ability_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Focus_id { get; set; }

        public int? Tier { get; set; }

        [StringLength(45)]
        public string Name { get; set; }

        [StringLength(45)]
        public string Cost { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public short Choice { get; set; }
    }
}

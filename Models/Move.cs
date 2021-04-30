namespace NumeneraCharGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("numeneradb.moves")]
    public partial class Move
    {
        [Key]
        [Column(Order = 0)]
        public int Moves_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type_id { get; set; }

        public int Tier { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Cost { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}

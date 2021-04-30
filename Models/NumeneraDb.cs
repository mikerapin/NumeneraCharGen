using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NumeneraCharGen.Models
{
    public partial class NumeneraDb : DbContext
    {
        public NumeneraDb() : base("name=NumeneraDb")
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Descriptor> Descriptors { get; set; }
        public virtual DbSet<Focus> Foci { get; set; }
        public virtual DbSet<Move> Moves { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

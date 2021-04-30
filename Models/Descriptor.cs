using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumeneraCharGen.Models
{
    public class Descriptor
    {
        public int Descriptor_Id { get; set; }
        public string Name { get; set; }
        public int Might { get; set; }
        public int Speed { get; set; }
        public int Intellect { get; set; }
        public int Armor { get; set; }
        public int Recovery { get; set; }
        public string Training { get; set; }
        public string Inability { get; set; }
        public string Trait { get; set; }
        public string Equipment { get; set; }
        public int Shins { get; set; }
        public string Page { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumeneraCharGen.Models
{
    public class Move
    {
        public int Move_Id { get; set; }
        public string Type_Id { get; set; }
        public int Tier { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
    }
}
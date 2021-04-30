using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumeneraCharGen.Models
{
    public class Ability
    {
        public int Ability_Id { get; set; }
        public int Focus_Id { get; set; }
        public int Tier { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public Boolean Choice { get; set; }
    }
}
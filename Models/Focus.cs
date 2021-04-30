using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumeneraCharGen.Models
{
    public class Focus
    {
        public int Focus_Id { get; set; }
        public string Name { get; set; }
        public int Might { get; set; }
        public int Speed { get; set; }
        public int Intellect { get; set; }
        public string Power { get; set; }
        public string Equipment { get; set; }
        public string Page { get; set; }
    }
}
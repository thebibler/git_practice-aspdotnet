using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Practice1.Models
{
    public class Franchise
    {
        public string ID { get; set; }
        public string TeamName { get; set; }
        public string Opponent { get; set; }
       
        public double? Score { get; set; }
        public string Stadium { get; set; }
        public string Coach { get; set; }
        public string Mascot { get; set; }
        public string TrophyID { get; set; }
    }
}

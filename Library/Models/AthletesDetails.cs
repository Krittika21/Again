using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class AthletesDetails
    {
        [Key]
        public int AthleteId { get; set; }
        public string Name { get; set; }
        public DateTime STTime { get; set; }
        public double CTDistance { get; set; }
        public string FitnessRating { get; set; }

    }
}

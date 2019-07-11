using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class TestDetails
    {
        [Key]
        public int ID { get; set; }
        public DateTime TestDate { get; set; }
        public virtual TestType TestType { get; set; }
        public int NoOfParticipants { get; set; }

        //public int AthleteId { get; set; }
        //[ForeignKey("AthleteId")]
        //public virtual AthletesDetails AThlete { get; set; }

        public ICollection<AthletesDetails> Athletes { get; set; }

        
    }
}

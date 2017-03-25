using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Consultation
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient{ get; set; }
        public int DocId { get; set; }
        public Provider Praticien { get; set; }
        public DateTime DateCreated { get; set; }
        public string Comments { get; set; }

       
       
    }
}

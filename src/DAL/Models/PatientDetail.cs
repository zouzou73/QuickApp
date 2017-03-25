using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PatientDetail
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Observation { get; set; }
        public string Icon { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
      
    }
}

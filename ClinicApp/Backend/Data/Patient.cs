using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Patient : ClinicDTO.Patient
    {
        public virtual ICollection<Examination> Examinations { get; set; } = new List<Examination>();
    }
}

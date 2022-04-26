using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Doctor : ClinicDTO.Doctor
    {
        public virtual ICollection<Examination> Examinations { get; set; } = new List<Examination>();
    }
}

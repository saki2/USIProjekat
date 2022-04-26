using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Examination : ClinicDTO.Examination
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}

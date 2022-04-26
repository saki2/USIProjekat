using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicDTO
{
    public class Secretary
    {
        [Key]
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
    }
}

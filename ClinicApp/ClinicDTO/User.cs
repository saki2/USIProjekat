using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

public enum Type
{
    Admin, Doctor, Patient, Secretary,
}

namespace ClinicDTO
{
    public class User
    {
        /// <summary>
        /// Id of the user
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string UserName { get; set; }

        public Type Type { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sy.Core.Abstracts;
using Sy.Core.Entities;

namespace Sy.Core.Entities
{
    [Table(name:"Clients")]
    class Client :BaseEntity<int>
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(50)]
        public string Password { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }
    }
}

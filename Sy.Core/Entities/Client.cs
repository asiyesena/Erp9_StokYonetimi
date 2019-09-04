using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.Enums;

namespace Sy.Core.Entities
{
    [Table(name:"Clients")]
    public class Client :BaseEntity<int>
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(50)]
        public string Password { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        public ApplicationRole ApplicationRole { get; set; }
        // kişiyi 9999 olarak girerse admin 1111 olarak girerse muster olsun diye property tanımladık
    }
}

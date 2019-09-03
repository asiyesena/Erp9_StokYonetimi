using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sy.Core.Abstracts
{
    // degişiklik tarihi , degişikligi yapan kullanıcı vs. gibi işlemleri takip etmek için açtık.
    public abstract class AuditBase

    {
      
        [StringLength(50)]
        public string CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;       //oluşturuldugu tarihi otomatik olarak kaydetsin diye eşitledik
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime? UpdatedTime { get; set; }          //bos olabilir alan olsun diye soru işareti koyduk

    }
}

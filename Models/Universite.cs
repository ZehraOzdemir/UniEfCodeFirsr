using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Universite
    {

        public int UniversiteId { get; set; }

        //[Column(TypeName ="varchar")]
        //[MaxLength(50)]
        //[Required]

        public int UniversiteAD { get; set; }


        public int BolumId { get; set; }

        public Bolum Bolumu { get; set; } 




    }
}

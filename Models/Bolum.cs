using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bolum
    {

        public int BolumId { get; set; }
        public string UniversiteAD { get; set; }

        public ICollection<Universite> UniBolumler { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbinamentiUST
{
    public class Posto
    {
        public string Scuola { get; set; }
        public string Città { get; set; }
        public Professore ProfessoreAbbinato { get; set; }

        public bool IsLibero()
        {
            if(ProfessoreAbbinato == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Abbina(Professore prof)
        {
            ProfessoreAbbinato = prof;
        }
        public override string ToString()
        {
            return this.Scuola + " " + this.Città + " Libero=" + IsLibero();
        }
    }
}

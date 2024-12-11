using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbinamentiUST
{
    public class Professore
    {
        public string Nome { get; set; }
        public int Punteggio { get; set; }
        public List<string> ElencoScuolePreferite { get; private set; }
        public Posto PostoAssegnato { get; set; }

        public Professore()
        {
            this.ElencoScuolePreferite = new List<string>();
        }
        //le scuole vanno aggiunte in ordine di preferenza
        public void AggiungiPreferenza(string scuola)
        {
            this.ElencoScuolePreferite.Add(scuola);
        }
        //metodi per accedere alla lista delle preferenze
        public string DimmiScuola(int indice)
        {
            return this.ElencoScuolePreferite[indice];
        }

        public int NumeroScuole()
        {
            return this.ElencoScuolePreferite.Count;
        }
        public override string ToString()
        {
            return $"{this.Nome} {this.Punteggio}";
        }
    }
}

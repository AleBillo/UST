using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbinamentiUST
{
    public class Graduatoria
    {
        public List<Professore> ListaProfessori { get; set; }

        public Graduatoria()
        {
            this.ListaProfessori = new List<Professore>();
        }
        // l'inserimento del professore mantiene la lista
        // in ordine decrescente di punteggio
        public void AggiungiProf(string nome, int punteggio)
        {
            Professore nuovo = new Professore() { Nome = nome, Punteggio = punteggio };
            //inizialmente il nuovo prof viene messo in fondo
            this.ListaProfessori.Add(nuovo);
            // poi li fa' risalire in graduatoria finché
            // raggiunge la sua posizione in base al suo punteggio
            int i = this.ListaProfessori.Count - 1; //l'ultima posizione
            bool sistemato = false;
            while(i>0 && !sistemato)
            {
                Professore precedente = ListaProfessori[i - 1];
                if(nuovo.Punteggio > precedente.Punteggio)
                {
                    //scambio di posto con il precedente
                    ListaProfessori[i] = precedente;
                    ListaProfessori[i - 1] = nuovo;
                    i = i - 1;
                }
                else
                {
                    sistemato = true;
                }
            }
        }
        //metodi per accedere alla lista
        public int NumeroProf()
        {
            return this.ListaProfessori.Count;
        }
        public Professore Dammiprof(int indice)
        {
            return this.ListaProfessori[indice];
        }
        //metodo che resituisce il prof cercato oppure null se non lo trova
        public Professore DammiProf(string nome)
        {
            // ricerca sequenziale
            // per ora non ho trovato nulla
            Professore risultato = null;
            int i = 0;
            while(i<this.ListaProfessori.Count && risultato==null)
            {
                Professore p = ListaProfessori[i];
                if(p.Nome == nome)
                {
                    risultato = p;
                }
                else
                {
                    i++;
                }
            }
            return risultato;
        }
    }
}

using System.Collections.Generic;

namespace NeperiaDizionarioV2.Models
{
    public class Parola
    {
           public Parola()
        {
           
            this.Sinonimi =  new HashSet<Sinonimo> ();
        }
        
        public int Id {get; set;}
        public string Termo { get; set; }

        public int Peso {get; set;}
        public ICollection<Sinonimo> Sinonimi { get; set; }
    }
}
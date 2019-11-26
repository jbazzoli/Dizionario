using System.ComponentModel.DataAnnotations.Schema;

namespace NeperiaDizionarioV2.Models
{
    public class Sinonimo
    {
         public Sinonimo(){
            this.Parola = new Parola();
        }
        public int Id {get;set;}
        public string Termo {get; set;}
        public int ParolaId { get; set; }
        [ForeignKey("ParolaId")]
        public Parola Parola { get; set; }
    }
}
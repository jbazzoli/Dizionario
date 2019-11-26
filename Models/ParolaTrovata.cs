using System.ComponentModel.DataAnnotations.Schema;

namespace NeperiaDizionarioV2.Models
{
    public class ParolaTrovata
    {
        public int Id  {get; set;}
        public int ParolaId {get; set;}
        public int ElaborId  {get; set;}
        public int Count {get; set;}
       [ForeignKey("ParolaId")]
        public Parola Parola {get; set;}
         [ForeignKey("ElaborId")]
        public Elabor Elabor {get; set;}
    }
}
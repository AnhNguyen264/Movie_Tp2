using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TP2.Models
{
    public class Objectives
    {

        [Key]
        public int Id { get; set; }


        public string NomObjective { get; set; }

        [ValidateNever]

        public  ICollection<Vendeur>? Vendeurs { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace TP2.Models
{
    public class Vendeur
    {

        [Key]
        public int Id { get; set; }
        public string NomVendeur { get; set; }


        [ValidateNever]
        public  ICollection<Objectives?> Objectives { get; set; }
    }
}

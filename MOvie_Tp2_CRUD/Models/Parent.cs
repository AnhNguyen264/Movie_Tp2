using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP2.Models
{
    public class Parent
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [DisplayName("NameStatut")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Le champ {0} demande un minimum de {1} et maximum de {2}.")]
        public string Nom { get; set; }

        [DisplayName("Image")]

        public string ImageURL { get; set; }

        [DisplayName("Description")]

        public string Description { get; set; }
        //public List<ParentEnfant> ParentEnfant { get; set; }
        //public Parent()
        //{
        //    Enfants = new List<Enfant>();
        //}
        public List<Enfant> Enfants { get; set; }



    }
}

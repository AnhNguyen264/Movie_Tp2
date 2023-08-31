using TP2.Models;

namespace TP2.ViewModels
{
    public class ObjectiveVM
    {

        public Objectives objectives { get; set; }
        public List<Vendeur> vendeurList { get; set; } = new List<Vendeur>();

    }
}

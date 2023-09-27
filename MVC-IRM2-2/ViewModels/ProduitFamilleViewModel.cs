using MVC_IRM2_2.Models;

namespace MVC_IRM2_2.ViewModels
{
    public class ProduitFamilleViewModel
    {
        public int ProduitId { get; set; }
        public string reference { get; set; }
        public string designation { get; set; }
        public string description { get; set; }
        public bool disponible { get; set; }
        public int FamilleId { get; set; }

        public IList<Famille> Familles { get; set; }
    }
}

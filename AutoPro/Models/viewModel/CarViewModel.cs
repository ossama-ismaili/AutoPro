using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPro.Models.viewModel
{
    public class CarViewModel
    {
        public Voiture Voiture { get; set; }
        public IEnumerable<Marque> Marques { get; set; }
        public IEnumerable<Model> Models { get; set; }
        public List<ApplicationUser> User { get; set; }
        public List<Location> locations { get; set; }
    }
}
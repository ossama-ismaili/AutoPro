using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPro.Models
{
    public class Locataire 
    {

        public int Id { get; set; }
       

        public List<Location> Locations { get; set; }
        public List<Voiture> voituresfavoris { get; set; }

    }
}

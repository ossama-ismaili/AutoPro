using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoPro.Controllers
{
    public class DashBoardController : Controller
    {
        AutoProContext _context;
        public DashBoardController(AutoProContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult marqueByNumber()
        {
            List<chartMarqueNumber> listMarque = new List<chartMarqueNumber>();
            var marque = _context.Marques.ToList();
            chartMarqueNumber item;
            foreach(var el in marque)
            {
                var count = _context.Voiture.Include(m => m.Marque).Include(m => m.Model).Where(m => m.Marque.NomMarque == el.NomMarque).Count();
                item = new chartMarqueNumber() { nomMarque = el.NomMarque, count= count };
                listMarque.Add(item);
            }

           
            return Json(listMarque);
        }

        public JsonResult carsByDemand()
        {
            List<CarsDemand> listMarque = new List<CarsDemand>();
            var voitures = _context.Voiture.Include(m => m.Marque).Include(m => m.Model).ToList();
            CarsDemand item;
            var count=0;
            foreach (var el in voitures)
            {

                count = _context.locations.Where(m => m.VoitureId== el.Id).Count() ;
                item = new CarsDemand() {nomVoiture= el.Marque.NomMarque+" "+ el.Model.NomModel,countLocation=count  };

                listMarque.Add(item);
            }


            return Json(listMarque);
        }
    }
}
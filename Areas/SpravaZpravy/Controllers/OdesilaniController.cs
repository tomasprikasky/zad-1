using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad.WEB_1.Areas.SpravaZpravy.Models;

namespace Zad.WEB_1.Areas.SpravaZpravy.Controllers
{
    [Area("SpravaZpravy")] //9. přidání reference na areu tak aby byl routing kompletní
    public class OdesilaniController : Controller
    {
        public IActionResult Odeslani() //vytvořeni akcnich metod krok 1 - pouze deklarovani
        {
            Modesilani modesilani = new Modesilani();
            
            return View(modesilani); //uprava
        }

        public IActionResult UspesneOdeslani() //vytvořeni akcnich metod krok 1 - pouze deklarovani
        {
            return View();
        }


        [HttpPost] // 8 pridání validace na straně serveru
        public IActionResult Odeslani(Modesilani modesilani)
        {

            if (ModelState.IsValid)
            {

                return RedirectToAction(nameof(OdesilaniController.UspesneOdeslani));// 8. přesměrování na příslušný wiev

            }

            return View(modesilani);


        }
    }

}

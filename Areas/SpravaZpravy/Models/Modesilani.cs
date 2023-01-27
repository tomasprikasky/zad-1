using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zad.WEB_1.Areas.SpravaZpravy.Models
{
    public class Modesilani
    {
        [Display(Name = "Zadejte odesilatele")]//7 nastaveni validace dle pozadavku
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Odesilatel musi mit minimalne 3 a maximalne 30 znaku")]
        [Required]
        public string Odesilatel { get; set; } = ""; // krok 4 zadefinovani promenych
        
        
        [Display(Name = "Zadejte příjemce")]//7 nastaveni validace dle pozadavku
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Odesilatel musi mit minimalne 3 a maximalne 30 znaku")]
        [Required]
        public string Nazev { get; set; } = ""; // krok 4 zadefinovani promenych


        [Display(Name = "Zadejte zpravu")]
        [Required]//7 nastaveni validace dle pozadavku
        public string Zprava { get; set; } = "";    // krok 4 zadefinovani promenych

        public Modesilani()                     // kork 4 zadefinovani nove instance tridy
        {

        }
    }
}

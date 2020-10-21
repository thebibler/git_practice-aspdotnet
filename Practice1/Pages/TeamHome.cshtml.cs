using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleSheets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practice1.Pages
{
    public class TeamHomeModel : PageModel
    {   
        [BindProperty(SupportsGet =true)]
        public string TeamName { get; set; }
        public static string spreadsheetID = "1wd883qK9f4J9V0eDb-wsVdZpbtbDcH341-i50ywRMUM";
        public static string sheet = " Summary";


        public GoogleSheetTable TeamSeasonStats;
        public GoogleSheetTable PlayerSeasonStats;
        public GoogleSheetTable CareerWinsAndLosses;
        public GoogleSheetTable BeltGameWinsAndLosses;
        public GoogleSheetTable SingleGameRecords;
        public GoogleSheetTable SeasonRecords;



        public void OnGet()
        {
         TeamSeasonStats = new GoogleSheetTable($"{TeamName} Summary", "B13:F23", spreadsheetID);
         PlayerSeasonStats = new GoogleSheetTable($"{TeamName} Summary", "B26:F32", spreadsheetID);
         CareerWinsAndLosses = new GoogleSheetTable($"{TeamName} Summary", "B35:D40", spreadsheetID);
         BeltGameWinsAndLosses = new GoogleSheetTable($"{TeamName} Summary", "B43:D49", spreadsheetID);
         SingleGameRecords = new GoogleSheetTable($"{TeamName} Summary", "B54:F65", spreadsheetID);
         SeasonRecords = new GoogleSheetTable($"{TeamName} Summary", "B69:E86", spreadsheetID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GoogleSheets.Models;
using System.Security.Cryptography;

namespace Practice1.Pages
{
    public class Current_WeekModel : PageModel
    {   
        public GoogleSheetTable Game1 { get; set; }
        public GoogleSheetTable Game2 { get; set; }
        public GoogleSheetTable Game3 { get; set; }
        public GoogleSheetTable Game4 { get; set; }
        public GoogleSheetTable Game5 { get; set; }
        public GoogleSheetTable Game6 { get; set; }
        public List<GoogleSheetTable> GameList;

        public string sheetID = "1wd883qK9f4J9V0eDb-wsVdZpbtbDcH341-i50ywRMUM";

        public void OnGet()
        {
            Game1 = new GoogleSheetTable("Game 1 Summary", "A1:C27", sheetID);
            Game2 = new GoogleSheetTable("Game 2 Summary", "A1:C27", sheetID);
            Game3 = new GoogleSheetTable("Game 3 Summary", "A1:C27", sheetID);
            Game4 = new GoogleSheetTable("Game 4 Summary", "A1:C27", sheetID);
            Game5 = new GoogleSheetTable("Game 5 Summary", "A1:C27", sheetID);
            Game6 = new GoogleSheetTable("Game 6 Summary", "A1:C27", sheetID);
        }
    }
}

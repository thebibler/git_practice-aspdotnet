using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GoogleSheets.Models;

namespace Practice1.Pages
{
    public class Current_SeasonModel : PageModel
    {
        public GoogleSheetTable Division1 { get; set; }
        public GoogleSheetTable Division2 { get; set; }
        public GoogleSheetTable SeasonLeaders { get; set; }
        public GoogleSheetTable SeasonLeadersCommittee { get; set; }
        public GoogleSheetTable SingleGameHighs { get; set; }

        public string sheetName = "Season Home Page Summary";
        public string sheetID = "1wd883qK9f4J9V0eDb-wsVdZpbtbDcH341-i50ywRMUM";

        public void OnGet()
        {
            Division1 = new GoogleSheetTable(sheetName, "A2:D8", sheetID);
            Division2 = new GoogleSheetTable(sheetName, "A11:D17", sheetID);
            SeasonLeaders = new GoogleSheetTable(sheetName, "A22:F29", sheetID);
            SeasonLeadersCommittee = new GoogleSheetTable(sheetName, "A32:E42", sheetID);
            SingleGameHighs = new GoogleSheetTable(sheetName, "A45:F53", sheetID);
        }
    }
}

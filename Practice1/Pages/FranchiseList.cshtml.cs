using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GoogleSheets.Models;
using SQLitePCL;
using Practice1.Models;

namespace Practice1.Pages
{
    public class FranchisesModel : PageModel

   {
       

        public GoogleSheetTable FranchiseList = new GoogleSheetTable("Team Records", "AM3:AM14", "1wd883qK9f4J9V0eDb-wsVdZpbtbDcH341-i50ywRMUM");
        public GoogleSheetTable TrophyList = new GoogleSheetTable("Team Records", "AV3:AV14", "1wd883qK9f4J9V0eDb-wsVdZpbtbDcH341-i50ywRMUM");
        
        
        public void OnGet()
        {
           
        }
    }
}

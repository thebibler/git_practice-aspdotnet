using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System.IO;
using System.Security.Cryptography;

namespace GoogleSheets.Models
{
    public class GoogleSheetTable
    {
        public string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public string ApplicationName = "Bibler Sheets";
        public string sheetID { get; set; }
        public string sheet { get; set; }
        public string dataBlock { get; set; }
        static SheetsService service;
        public IList<IList<object>> GoogleTable { get; set; }

        public void UseGoogle()
        {
            GoogleCredential credential;
            using (var stream = new FileStream("Bibler.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public GoogleSheetTable(string sheet, string dataBlock, string sheetID)
        {
            UseGoogle();
            var range = $"{sheet}!{dataBlock}";
            var request = service.Spreadsheets.Values.Get(sheetID, range);
            var response = request.Execute();
            this.GoogleTable = response.Values;

        }
        //method to creat google, creates an array of arrays
        public IList<IList<object>> CreateTable(string sheet, string dataBlock, string sheetID)
        {
            var range = $"{sheet}!{dataBlock}";
            var request = service.Spreadsheets.Values.Get(sheetID, range);
            var response = request.Execute();
            var values = response.Values;
            return values;
        }
    }
}

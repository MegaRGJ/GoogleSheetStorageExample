using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;


namespace GoogleSheetStorageExample
{
    class Program
    {

        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string MyApplicationName = "Postcode Notes Application"; //Postcode Notes Application
        static string SheetId = "14LBKok587gQguGzX6ORPjC-s-PyEklPWyPhdP-2zrRw";
        public static string AllSheetRange = "A2:B";
        static SheetsService SheetsService;
        public static int CurrentRowSelected = 2;


        [STAThread]
        static void Main()
        {
            UserCredential credentials = CreateCredentials();
            SheetsService = CreateSheetsService(credentials);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PostcodeNotesApplication());
        }

        public static ValueRange CellDataRequest(string InCellRange)
        {
            SpreadsheetsResource.ValuesResource.GetRequest Request = SheetsService.Spreadsheets.Values.Get(SheetId, InCellRange);
            ValueRange response = Request.Execute();
            return response;
        }

        public static void UpdatePostcodeInformation(string InInformation, string InCellRange)
        {
            ValueRange RequestBody = new ValueRange();
            RequestBody.MajorDimension = "ROWS";

            var oblist = new List<object>() { InInformation };
            RequestBody.Values = new List<IList<object>> { oblist };

            SpreadsheetsResource.ValuesResource.UpdateRequest Update = SheetsService.Spreadsheets.Values.Update(RequestBody, SheetId, InCellRange);
            Update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;

            UpdateValuesResponse Response = Update.Execute();
        }

        public static void CreateNewPostcodeEntry(string InPostcode, string InInformation, string InCellRange)
        {
            ValueRange RequestBody = new ValueRange();
            RequestBody.MajorDimension = "ROWS";

            var oblist = new List<object>() { InPostcode, InInformation };
            RequestBody.Values = new List<IList<object>> { oblist };

            SpreadsheetsResource.ValuesResource.AppendRequest Request = SheetsService.Spreadsheets.Values.Append(RequestBody, SheetId, InCellRange);
            Request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;

            AppendValuesResponse Response = Request.Execute();
        }

        public static string FindPostcodeInformation(ValueRange InValues, string InPostcode)
        {
            CurrentRowSelected = 2;
            if (InValues.Values != null)
            {
                foreach (var Row in InValues.Values)
                {
                    CurrentRowSelected++;
                    if (Row[0].ToString() == InPostcode)
                    {
                        return Row[1].ToString();
                    }
                }
            }

            return "Not Found";
        }

        private static UserCredential CreateCredentials()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None
                    ).Result;
            }

            return credential;
        }

        private static SheetsService CreateSheetsService(UserCredential credentials)
        {
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credentials,
                ApplicationName = MyApplicationName,
            });

            return service;
        }
    }
}

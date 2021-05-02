using System;
using RestSharp;

namespace RestApiProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCovidApiData();
        }

        private static void GetCovidApiData()
        {
            var apiBaseUrl = new Uri("https://covid19.th-stat.com");
            IRestClient client = new RestClient(apiBaseUrl);
            IRestRequest request = new RestRequest("/api/open/today", Method.GET);
            IRestResponse<ClsCovidModel> response = client.Execute<ClsCovidModel>(request);
            if (response.IsSuccessful)
            {
                Console.WriteLine($"Confirmed : {response.Data.Confirmed}");
                Console.WriteLine($"Recovered : {response.Data.Recovered}");
                Console.WriteLine($"Hospitalized : {response.Data.Hospitalized}");
                Console.WriteLine($"Deaths : {response.Data.Deaths}");
                Console.WriteLine($"NewConfirmed : {response.Data.NewConfirmed}");
                Console.WriteLine($"NewRecovered : {response.Data.NewRecovered}");
                Console.WriteLine($"NewHospitalized : {response.Data.NewHospitalized}");
                Console.WriteLine($"NewDeaths : {response.Data.NewDeaths}");
                Console.WriteLine($"UpdateDate : {response.Data.UpdateDate}");
                Console.WriteLine($"Source : {response.Data.Source}");
                Console.WriteLine($"DevBy : {response.Data.DevBy}");
                Console.WriteLine($"SeverBy : {response.Data.SeverBy}");

            }
        }
    }

    internal class ClsCovidModel
    {
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Hospitalized { get; set; }
        public int Deaths { get; set; }
        public int NewConfirmed { get; set; }
        public int NewRecovered { get; set; }
        public int NewHospitalized { get; set; }
        public int NewDeaths { get; set; }
        public string UpdateDate { get; set; }
        public string Source { get; set; }
        public string DevBy { get; set; }
        public string SeverBy { get; set; }

    }
}

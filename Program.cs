using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidIndiaAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var myJsonResponse = GetCovidData().GetAwaiter().GetResult();
            
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

            Console.WriteLine(myDeserializedClass.cases_time_series[myDeserializedClass.cases_time_series.Count - 1].dailyconfirmed + " - Daily Confirmed");
            Console.WriteLine("Total tested -" + myDeserializedClass.tested[myDeserializedClass.tested.Count - 1].totalsamplestested);
        }

        private static async Task<string> GetCovidData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.covid19india.org/data.json");
            client.DefaultRequestHeaders.Accept.Clear();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, client.BaseAddress);

            var response = await MakeRequestAsync(request, client);
            return response;
        }

        public static async Task<string> MakeRequestAsync(HttpRequestMessage getRequest, HttpClient client)
        {
            var response = await client.SendAsync(getRequest).ConfigureAwait(false);
            var responseString = string.Empty;
            try
            {
                response.EnsureSuccessStatusCode();
                responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (HttpRequestException)
            {

            }

            return responseString;
        }
    }
}

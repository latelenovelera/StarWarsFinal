using Newtonsoft.Json;
using StarWarsFinal.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsFinal
{
    public class JsonHelper
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<Players> GetPlayers(string PlayerID)
        {
            Players myDeserializedClass = new Players();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/people/" + PlayerID + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                myDeserializedClass = JsonConvert.DeserializeObject<Players>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", ex.Message);
            }
            return myDeserializedClass;
        }

    }
}

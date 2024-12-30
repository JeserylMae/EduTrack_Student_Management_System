using DomainLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ServiceLayer.Database
{
    public class ProrgamServices
    {
        public ProrgamServices()
        {
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/Program";
        }


        public async Task<Dictionary<string, string>> GetAllProgram()
        {
            string request = $"{_webAddress}/GetAllProgram";

            using (HttpClient client = new HttpClient()) 
            { 
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonResponse);
                }
                return new Dictionary<string, string>();
            }
        }


        private string _webAddress;
    }
}

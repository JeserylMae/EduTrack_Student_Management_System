using DomainLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ServiceLayer.Database
{
    public class ProgramServices
    {
        public ProgramServices()
        {
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/Program";
        }


        public async Task<List<PRProgramModel>> GetAll()
        {
            Uri endpoint = new Uri($"{_webAddress}/GetAll");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<PRProgramModel>>(jsonResponse);
                }
                return new List<PRProgramModel>();
            }
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

        public async Task<bool> InsertNew(PRProgramModel program)
        {
            string request = $"{_webAddress}/InsertNew";

            string jsonContent = JsonConvert.SerializeObject(program, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Update(PRProgramModel program)
        {
            Uri endpoint = new Uri($"{_webAddress}/Update");

            string jsonContent = JsonConvert.SerializeObject(program, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage httpRequest = new HttpRequestMessage
                {
                    Method = new HttpMethod("Patch"),
                    Content = content,
                    RequestUri = endpoint
                };

                HttpResponseMessage response = await client.SendAsync(httpRequest);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Delete(string programId)
        {
            Uri endpoint = new Uri($"{_webAddress}/Delete?programId={programId}");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = endpoint
                };

                HttpResponseMessage response = await client.SendAsync(httpRequest);
                return response.IsSuccessStatusCode;
            }
        }


        private string _webAddress;
    }
}

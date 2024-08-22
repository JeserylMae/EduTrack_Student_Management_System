

using DomainLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Database
{
    public class StudentPersonalInfoServices
    {
        public StudentPersonalInfoServices()
        {
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/StudentPersonalInfo";
        }

        public async Task<List<StudentPersonalInfoModel>> GetAll()
        {
            string request = $"{_webAddress}/GetAll";
            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode) 
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<StudentPersonalInfoModel>>(jsonResponse);
                }
                else { return new List<StudentPersonalInfoModel>(); }
            }
        }

        public async Task<bool> InsertNew(PersonalInfoModel<StudentPersonalInfoModel> parameters)
        {
            string request = $"{_webAddress}/InsertNew";

            string JsonParameter = JsonConvert.SerializeObject(parameters, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);

                Console.WriteLine(response.Content.ToString());
                return response.IsSuccessStatusCode;
            }
        }

        private string _webAddress;
    }
}

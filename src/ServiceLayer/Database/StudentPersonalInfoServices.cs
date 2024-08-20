

using DomainLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

        private string _webAddress;
    }
}

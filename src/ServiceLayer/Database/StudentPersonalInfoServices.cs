

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

        public async Task<int> InsertNew(StudentPersonalInfoModel studentPersonalInfo,
                                         string DefaultPassword, string Position,
                                         string StudentCode, string GuardianCode)
        {
            string request = $"{_webAddress}/InsertNew";

            var parameters = new 
            {
                studentPersonalInfo = studentPersonalInfo,
                DefaultPassword = DefaultPassword,
                Position = Position,
                StudentCode = StudentCode,
                GuardianCode = GuardianCode
            };

            string JsonParameter = JsonSerializer.Serialize(parameters);
        }

        private string _webAddress;
    }
}

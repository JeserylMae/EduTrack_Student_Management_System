using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Database
{
    public class InstructorPersonalInfoServices
    {
        public InstructorPersonalInfoServices() 
        { 
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/InstructorPersonalInfo";
        }


        public async Task<List<RInstructorPersonalInfoModel>> GetAll()
        {
            string request = $"{_webAddress}/GetAll";
            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode) 
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<RInstructorPersonalInfoModel>>(jsonResponse);
                }
                else { return new List<RInstructorPersonalInfoModel>(); }
            }
        }

        public async Task<RInstructorPersonalInfoModel> GetById(string itrCode)
        {
            string request = $"{_webAddress}/GetById?itrCode={itrCode}";
            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<RInstructorPersonalInfoModel>(jsonResponse);
                }
                else { return new RInstructorPersonalInfoModel(); }
            }
        }

        public async Task<bool> InsertNew(PInstructorPersonalInfoModel<PNameModel> instructor)
        {
            string request = $"{_webAddress}/InsertNew";

            string jsonParameter = JsonConvert.SerializeObject(instructor, Formatting.Indented);
            StringContent content = new StringContent(jsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Update(PInstructorPersonalInfoModel<PNameModel> instructor)
        {
            string request = $"{_webAddress}/Update";

            string jsonParameter = JsonConvert.SerializeObject(instructor, Formatting.Indented);
            StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage requestMessage = new HttpRequestMessage
                {
                    Method = new HttpMethod("Patch"),
                    RequestUri = new Uri(request),
                    Content = content
                };

                HttpResponseMessage response = await client.SendAsync(requestMessage);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Delete(PInstructorPersonalInfoParams instructor)
        {
            string request = $"{_webAddress}/Delete";

            string jsonParameter = JsonConvert.SerializeObject(instructor, Formatting.Indented);
            StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage requestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(request),
                    Content = content
                };

                HttpResponseMessage response = await client.SendAsync(requestMessage);
                return response.IsSuccessStatusCode;
            }
        }

        private string _webAddress;
    }
}

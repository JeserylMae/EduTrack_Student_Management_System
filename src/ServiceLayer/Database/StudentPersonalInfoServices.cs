﻿
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

        public async Task<StudentPersonalInfoModel> GetById(string SrCode)
        {
            if (string.IsNullOrEmpty(SrCode)) { throw new ArgumentNullException(nameof(SrCode)); }

            string request = $"{_webAddress}/GetById?SrCode={SrCode}";
            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<StudentPersonalInfoModel>(jsonResponse);
                }
                else { return new StudentPersonalInfoModel(); }
            }
        }

        public async Task<bool> InsertNew(PersonalInfoModel<StudentPersonalInfoModel> parameters)
        {
            string request = _webAddress + "/InsertNew";

            string JsonParameter = JsonConvert.SerializeObject(parameters, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Update(PersonalInfoModel<StudentPersonalInfoModel> parameters)
        {
            string request = _webAddress + "/Update";

            string JsonParameter = JsonConvert.SerializeObject(parameters, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Delete(StudentPersonalInfoCodeModel code)
        {
            Uri requestUri = new Uri(_webAddress + "/Delete");

            string JsonParameter = JsonConvert.SerializeObject(code, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage { 
                    Method = HttpMethod.Delete, 
                    RequestUri = requestUri, 
                    Content = content 
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
        }


        private string _webAddress;
    }
}

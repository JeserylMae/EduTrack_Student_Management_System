using DomainLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Database
{
    public class StudentAcademicInfoServices
    {
        public StudentAcademicInfoServices()
        {
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/StudentAcademicInfo";
        }


        public List<RStudentAcademicInfoModel> GetAll()
        {
            string request = $"{_webAddress}/GetAll";
            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(endpoint).Result;

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<RStudentAcademicInfoModel>>(jsonResponse);
                }
                else { return new List<RStudentAcademicInfoModel>(); }
            }
        }


        private string _webAddress;
    }
}

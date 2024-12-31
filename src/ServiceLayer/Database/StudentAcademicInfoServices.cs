using DomainLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ServiceLayer.Database
{
    public class StudentAcademicInfoServices
    {
        public StudentAcademicInfoServices()
        {
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/StudentAcademicInfo";
        }


        public async Task<List<PStudentAcademicInfoModel<PNameModel>>> GetAll()
        {
            string request = $"{_webAddress}/GetAll";
            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<PStudentAcademicInfoModel<PNameModel>>>(jsonResponse);
                }
                else { return new List<PStudentAcademicInfoModel<PNameModel>>(); }
            }
        }

        public async Task<PStudentAcademicInfoModel<PNameModel>> GetByParams(PRStudentAcademicInfoParams paramsModel)
        {
            string request = $"{_webAddress}/GetByParams";
            HandleRequestParameter(ref request, paramsModel);

            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<PStudentAcademicInfoModel<PNameModel>>(jsonResponse);
                }
                return new PStudentAcademicInfoModel<PNameModel>();
            }
        }

        public async Task<int> GetRecordId(PRStudentAcademicInfoParams paramsModel)
        {
            string request = $"{_webAddress}/GetRecordId";
            HandleRequestParameter(ref request, paramsModel);

            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<int>(jsonResponse);
                }
                return -1;
            }
        }

        public async Task<bool> InsertNew(PStudentAcademicInfoModel<string> paramsModel)
        {
            string request = $"{_webAddress}/InsertNew";

            string JsonParameter = JsonConvert.SerializeObject(paramsModel, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Update(PStudentAcademicInfoModel<string> paramsModel)
        {
            Uri request = new Uri($"{_webAddress}/Update");

            string JsonParameter = JsonConvert.SerializeObject(paramsModel, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage httpRequest = new HttpRequestMessage
                {
                    Method = new HttpMethod("Patch"),
                    RequestUri = request,
                    Content = content
                };

                HttpResponseMessage response = await client.SendAsync(httpRequest);

                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Delete(PRStudentAcademicInfoParams paramsModel)
        {
            Uri requestUri = new Uri($"{_webAddress}/Delete");

            string JsonParameter = JsonConvert.SerializeObject(paramsModel, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = requestUri,
                    Content = content
                };
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
        }

        #region Helpers
        private void HandleRequestParameter(ref string request, PRStudentAcademicInfoParams paramsModel)
        {
            if (String.IsNullOrEmpty(paramsModel.SrCode))
                request += $"/SrCode={paramsModel.SrCode}";
            
            if (String.IsNullOrEmpty(paramsModel.AcademicYear))
                request += $"&AcademicYear{paramsModel.AcademicYear.Replace(' ', '%')}";

            if (String.IsNullOrEmpty(paramsModel.YearLevel))
                request += $"&YearLevel={paramsModel.YearLevel}";

            if (String.IsNullOrEmpty(paramsModel.Semester))
                request += $"&Semester={paramsModel.Semester}";
        }
        #endregion


        private string _webAddress;
    }
}

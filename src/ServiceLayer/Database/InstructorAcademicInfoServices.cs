using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Database
{
    public class InstructorAcademicInfoServices
    {
        public InstructorAcademicInfoServices()
        {
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/InstructorAcademicInfo";
        }


        public async Task<List<PInstructorAcademicInfoModel<PNameModel>>> GetAll()
        {
            Uri request = new Uri($"{_webAddress}/GetAll");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string JsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<PInstructorAcademicInfoModel<PNameModel>>>(JsonResponse);
                }
                return new List<PInstructorAcademicInfoModel<PNameModel>>();
            }
        }

        public async Task<List<string>> GetAllCourse()
        {
            Uri request = new Uri($"{_webAddress}/GetAllCourse");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<string>>(jsonResponse);
                }
                return new List<string>();
            }
        }

        public async Task<PInstructorAcademicInfoModel<PNameModel>> GetById(string itrCode)
        {
            Uri request = new Uri($"{_webAddress}/GetById?ItrCode={itrCode}");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<PInstructorAcademicInfoModel<PNameModel>>(jsonResponse);
                }
                return new PInstructorAcademicInfoModel<PNameModel>();
            }
        }

        public async Task<int> GetRecordId(PRInstructorAcademicParams instructor)
        {
            string request = $"{_webAddress}/GetRecordId";
            HandleRequestParameters(ref request, instructor);

            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = new HttpResponseMessage();

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return int.Parse(JsonConvert.DeserializeObject<string>(jsonResponse));
                }
                return -1;
            }
        }

        public async Task<bool> InsertNew(PInstructorAcademicInfoModel<string> instructor)
        {
            string request = $"{_webAddress}/InsertNew";

            string jsonRequest = JsonConvert.SerializeObject(instructor, Formatting.Indented);
            StringContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);
                return response.IsSuccessStatusCode;
            }
        } 

        public async Task<bool> Update(string recordId, PInstructorAcademicInfoModel<string> instructor)
        {
            Uri request = new Uri($"{_webAddress}/Update?RecordId={recordId}");

            string jsonContent = JsonConvert.SerializeObject(instructor, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage httpRequest = new HttpRequestMessage
                {
                    Method = new HttpMethod("Patch"),
                    RequestUri = request,
                    Content = content
                };

                HttpResponseMessage responnse = await client.SendAsync(httpRequest);
                return responnse.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Delete(PInstructorPersonalInfoParams instructor)
        {
            Uri request = new Uri($"{_webAddress}/Delete");

            string jsonContent = JsonConvert.SerializeObject(instructor, Formatting.Indented);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = request,
                    Content = content
                };

                HttpResponseMessage response = await client.SendAsync(httpRequest);
                return response.IsSuccessStatusCode;
            }
        }


        #region Helpers
        private void HandleRequestParameters(ref string request, PRInstructorAcademicParams instructor)
        {
            if (!string.IsNullOrEmpty(instructor.ItrCode))
                request += $"?ItrCode={instructor.ItrCode}";

            if (!string.IsNullOrEmpty(instructor.AcademicYear))
                request += $"&AcademicYear={instructor.AcademicYear}";
            
            if (!string.IsNullOrEmpty(instructor.YearLevel))
                request += $"&YearLevel={instructor.YearLevel}";

            if (!string.IsNullOrEmpty(instructor.Semester))
                request += $"&Semester={instructor.Semester}";

            if (!string.IsNullOrEmpty(instructor.Section))
                request += $"&Section={instructor.Section}";

            if (!string.IsNullOrEmpty(instructor.Course))
                request += $"&Course={instructor.Course}";
        }
        #endregion

        private string _webAddress;
    }
}

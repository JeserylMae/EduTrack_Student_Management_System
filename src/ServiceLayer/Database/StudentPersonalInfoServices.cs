
using DomainLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
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
            string request = $"{_webAddress}/InsertNew";
            string JsonParameter = JsonConvert.SerializeObject(parameters, Formatting.Indented);
            StringContent content = new StringContent(JsonParameter, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(request, content);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task ValidateParameter(PersonalInfoModel<StudentPersonalInfoModel> parameters)
        {
            if (parameters == null) throw new ArgumentNullException("parameters");

            //if (HasNullOrEmptyString(parameters))
            //{
            //    string Message = $"Failed to add student with SR Code {parameters.InfoModel.SrCode} "
            //                   + "because some information were empty.";
            //    throw new ArgumentNullException(Message);
            //}

            StudentPersonalInfoModel model = await GetById(parameters.InfoModel.SrCode);
            if (model != null) 
            { 
                throw new Exception($"Student with SR Code {parameters.InfoModel.SrCode} already exists."); 
            }
        }

        //private bool HasNullOrEmptyString<TModel>(TModel model)
        //{
        //    bool isNull = false;

        //    foreach (PropertyInfo property in model.GetType().GetProperties())
        //    {
        //        object value = property.GetValue(model);

        //        if (value == null) { isNull = true; break; }
        //        if (!value.GetType().IsClass) { continue; }

        //        if (HasNullOrEmptyString(value))
        //        {
        //            isNull = true;
        //            break;
        //        };
        //    }
        //    return isNull;
        //}

        private bool HasNullOrEmptyString<TModel>(TModel model)
        {
            bool isNullOrEmpty = false;
            try
            {
                foreach (PropertyInfo property in model.GetType().GetProperties())
                {
                    object value = property.GetValue(model);
                    Console.WriteLine($"VALUE: {value} Type: {value.GetType()}");

                    if (value == null || (value is string && string.IsNullOrEmpty((string)value)))
                    {
                        isNullOrEmpty = true;
                        break;
                    }

                    if (!value.GetType().IsClass) { continue; }

                    if (HasNullOrEmptyString(value))
                    {
                        isNullOrEmpty = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() );
            }
            return isNullOrEmpty;
        }


        private string _webAddress;
    }
}

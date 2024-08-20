
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using DomainLayer.DataModels;


namespace ServiceLayer.Database
{
    public class UserServices
    {
        public UserServices()
        {
            _webAddress = $"{DatabaseConnection.GetWebAddress()}/User";
        }

        public async Task<UserModel> GetUserByID(string UserId)
        {
            string request = $"{_webAddress}/GetById?UserId={UserId}";
            Uri endpoint = new Uri(request);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<UserModel>(jsonResponse);
                }
                else { return new UserModel(); }
            }
        }

        private string _webAddress;
    }
}

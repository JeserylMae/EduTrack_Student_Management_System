
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;
using ServiceLayer.Database;

namespace ServiceLayer.Services
{
    public class EndpointAuthentication
    {
        public async Task<int> CheckWebConnection()
        {
            int attempts = 0;
            do
            {
                bool result;
                try { result = await HealthCheckEndpoint(); }
                catch (HttpRequestException) { result = false; }

                if (!result) attempts++;
                else         break; 
            }
            while (attempts < 10);

            return attempts;
        }

        private async Task<bool> HealthCheckEndpoint()
        {
            using (HttpClient client = new HttpClient())
            {
                string webAddress = DatabaseConnection.GetWebAddress();

                Uri endpoint = new Uri($"{webAddress}/Endpoint/Health");
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode) { return true; }
            }
            return false;
        }


        public void EvaluateWebConnection(int attempts)
        {
            if (attempts >= 10)
            {
                throw new Exception("ERROR: Failed to connect machine to web API. "
                                  + "Ensure that all submitted Web API Information "
                                  + "are correct.");
            }
        }
    }
}

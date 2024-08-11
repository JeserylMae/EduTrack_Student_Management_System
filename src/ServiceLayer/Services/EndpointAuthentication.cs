
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace ServiceLayer.Services
{
    public class EndpointAuthentication
    {
        public async Task CheckWebConnection()
        {
            int attempts = 0;
            do
            {
                bool result;
                try { result = await HealthCheckEndpoint(); }
                catch (HttpRequestException) { result = false; }

                if (!result)
                {
                    Thread.Sleep(1000);
                    attempts++;
                }
                else { break; }
            }
            while (attempts < 15);

            EvaluateWebConnection(attempts);
        }

        private async Task<bool> HealthCheckEndpoint()
        {
            using (HttpClient client = new HttpClient())
            {
                Uri endpoint = new Uri("https://localhost:5393/api/Endpoint/Health");
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode) { return true; }
            }
            return false;
        }


        private void EvaluateWebConnection(int attempts)
        {
            if (attempts < 15)
            {
                string Message = "Web API connection is successful.";
                Console.WriteLine(Message);
            }
            else
            {
                string Message = "ERROR: Failed to connect machine to web API. "
                               + "Ensure that all submitted Web API Information "
                               + "are correct.";
                Console.WriteLine(Message);
            }
        }
    }
}

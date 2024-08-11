
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;

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

                if (!result)
                {
                    Thread.Sleep(1000);
                    attempts++;
                    Console.WriteLine("Failed Connection.");
                }
                else { Console.WriteLine("Successful connection"); break; }
            }
            while (attempts < 15);

            return attempts;
        }

        private async Task<bool> HealthCheckEndpoint()
        {
            using (HttpClient client = new HttpClient())
            {
                Uri endpoint = new Uri("https://localhost:5176/api/Endpoint/Health");
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode) { return true; }
            }
            return false;
        }


        public string EvaluateWebConnection(int attempts)
        {
            if (attempts < 15)
            {
                return "Web API connection is successful.";
            }
            else
            {
                return "ERROR: Failed to connect machine to web API. "
                               + "Ensure that all submitted Web API Information "
                               + "are correct.";
            }
        }
    }
}

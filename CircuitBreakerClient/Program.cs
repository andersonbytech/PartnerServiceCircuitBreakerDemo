using System;
using System.Net.Http;
using System.Threading.Tasks;
using Polly;
using Polly.CircuitBreaker;

class Program
{
    static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();
        var circuitBreakerPolicy = Policy<HttpResponseMessage>
            .Handle<HttpRequestException>()
            .OrResult(r => !r.IsSuccessStatusCode)
            .CircuitBreakerAsync(
                handledEventsAllowedBeforeBreaking: 2,
                durationOfBreak: TimeSpan.FromSeconds(30)
            );

        for (int i = 0; i < 10; i++)
        {
            try
            {
                HttpResponseMessage response = await circuitBreakerPolicy.ExecuteAsync(async () =>
                {
                    Console.WriteLine($"Attempt {i + 1}: Calling external service...");
                    var response = await httpClient.GetAsync("http://localhost:5013/test");
                    response.EnsureSuccessStatusCode();
                    Console.WriteLine("Service call succeeded.");
                    return response;
                });
            }
            catch (BrokenCircuitException)
            {
                Console.WriteLine("Circuit is open. Skipping call.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Service call failed: {ex.Message}");
            }

            await Task.Delay(2000); // Wait 2 seconds before the next attempt
        }
    }
}

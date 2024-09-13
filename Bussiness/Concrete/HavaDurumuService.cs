using Bussiness.Abstract;

namespace Bussiness.Concrete
{
    public class HavaDurumuService : IHavaDurumuService
    {
        public async Task<string> HavaDurumuSorgula(string sehirAdi)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city={sehirAdi}");
                request.Headers.Add("Authorization", "apikey 2cCqfjyfAVpD72umqHelcB:1zSW9P1kMzc6YMiLHlD8ZU");
                var content = new StringContent("", null, "application/json");
                request.Content = content;
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dış serviste bir hata alındı, hata sebebi : " + ex.Message);
                return "Hata alındı";
            }
        }
    }
}

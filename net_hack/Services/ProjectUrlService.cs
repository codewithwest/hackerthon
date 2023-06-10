using System.Net;
using System.Text.Json;

namespace net_hack
{
    public class ProjectUrlService
    {
        public IEnumerable<Projects> GetProjects()
        {
            // Open url
            var url = "https://west-dynamics.vercel.app/api/";

            var request = WebRequest.Create(url);
            request.Method = "GET";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            // var myClient = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });
            // var response = await myClient.GetAsync("website.com");
            // var streamResponse = await response.Content.ReadAsStreamAsync();
            // Console.Write(data);

            return JsonSerializer.Deserialize<Projects[]>(data,
                       new JsonSerializerOptions
                       {
                           PropertyNameCaseInsensitive = true
                       });
        }


    }
}
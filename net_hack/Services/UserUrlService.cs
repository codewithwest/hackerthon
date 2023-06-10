using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Graph.Me.SendMail;
using Microsoft.Kiota.Abstractions;

namespace net_hack
{
    public class UserUrlService
    {
        private IRequestAdapter? requestAdapter;

        // private static GraphServiceClient? _userClient;
        public async Task<IEnumerable<User>?> GetUser()
        {
            // Open url
            var url = "https://graph.microsoft.com/v1.0/me";
            var graphClient = new GraphServiceClient(requestAdapter);

            var result = await graphClient.Me.GetAsync();

            // var request = WebRequest.Create(url);
            // request.Method = "GET";

            // using var webResponse = request.GetResponse();
            // using var webStream = webResponse.GetResponseStream();

            // using var reader = new StreamReader(webStream);
            // var data = reader.ReadToEnd();
            // var myClient = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });
            // var response = await myClient.GetAsync("website.com");
            // var streamResponse = await response.Content.ReadAsStreamAsync();
            // Console.Write(data);
            // return (IEnumerable<User>?)result;
            var list = JsonSerializer.Deserialize<List<User>>(result, JsonSerializerOptions.Default
            );
            return list;
            // var jsonNode = JsonSerializer.Deserialize<User>(result);
            // return JsonSerializer.Deserialize<User>(result,
            //            new JsonSerializerOptions
            //            {
            //                PropertyNameCaseInsensitive = true
            //            });

        }
    }
}
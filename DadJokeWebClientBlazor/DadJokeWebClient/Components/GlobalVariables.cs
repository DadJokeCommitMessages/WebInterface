using Microsoft.VisualBasic;
using System.Net.Http.Headers;

namespace DadJokeWebClient.Components
{
    public class GlobalVariables
    {

        public static string ApiRoot { get; } = "http://ec2-3-250-229-22.eu-west-1.compute.amazonaws.com:5282/api";
        public static string? AccessToken { get; set; }
        public static string? RedirectURL { get; set; } = "http://ec2-54-74-121-143.eu-west-1.compute.amazonaws.com";
        public static Boolean IsAccessTokenValid()
        {
            if (AccessToken == null)
            {
                return false;
            }
            else
            {
                var client = new HttpClient();
                string uri = $"https://www.googleapis.com/oauth2/v1/tokeninfo?access_token={AccessToken}";

                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsync(client.BaseAddress, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;

                }
                return false;
            }

        }
    }
}

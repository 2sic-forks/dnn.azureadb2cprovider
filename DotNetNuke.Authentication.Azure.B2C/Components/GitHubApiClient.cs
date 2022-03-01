using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNuke.Authentication.Azure.B2C.Components
{
    internal class GitHubApiClient
    {
        const string USER_AGENT_NAME = "DNNAzureB2C-GitHubClient";
        const string USER_AGENT_VERSION = "1.0";
        const string GITHUB_API_URI = "https://api.github.com";

        private string base64EncodedAuthenticationString = "";

        HttpClient httpClient;
        JsonSerializerSettings jsonSerializerSettings;

        public GitHubApiClient()
        {
            httpClient = new HttpClient();
            Uri baseUri = new Uri(GITHUB_API_URI);
            httpClient.BaseAddress = baseUri;
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.ConnectionClose = true;


            jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy
                    {
                        OverrideSpecifiedNames = false
                    }
                }
            };

        }

        public void SetAuthentication(string userName, string token)
        {
            var authenticationString = $"{userName}:{token}";
            base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));
        }

        public Models.GitHub.UserProfile GetUserProfile()
        {
            HttpRequestMessage requestMessage = this.buildRequestMessage(HttpMethod.Get, "/user");

            var task = httpClient.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Models.GitHub.UserProfile>(responseBody, jsonSerializerSettings);
        }

        public Models.GitHub.UserEmail[] GetUserEmails()
        {
            HttpRequestMessage requestMessage = this.buildRequestMessage(HttpMethod.Get, "/user/emails");

            var task = httpClient.SendAsync(requestMessage);
            var response = task.Result;
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Models.GitHub.UserEmail[]>(responseBody, jsonSerializerSettings);
        }

        private HttpRequestMessage buildRequestMessage(HttpMethod method, string requestUri)
        {
            var requestMessage = new HttpRequestMessage(method, requestUri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
            requestMessage.Headers.UserAgent.Add(new ProductInfoHeaderValue(USER_AGENT_NAME, USER_AGENT_VERSION));
            return requestMessage;
        }
    }
}

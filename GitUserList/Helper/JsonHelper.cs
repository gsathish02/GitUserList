using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GitUserList.Model;

namespace GitUserList.Helper
{
    public class JsonHelper
    {
        const string BASE_URL = "https://api.github.com/repositories?";
        const string POST_ENDPOINT = "application/vnd.github.v3+json";

        public static async Task<List<Users>> GetPostsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var jsonString = await httpClient.GetStringAsync(BASE_URL + POST_ENDPOINT);
                var details = JsonConvert.DeserializeObject<List<Users>>(jsonString);
                return details;
            }
        }
    }
}

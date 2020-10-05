using Newtonsoft.Json;

namespace GitUserList.Model
{
    public class Users
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("owner")] 
        public Owner OwnerList { get; set; }
    }

    public class Owner
    {
        [JsonProperty("avatar_url")]
        public string OwnerAvatarUrl { get; set; }

        [JsonProperty("html_url")]
        public string OwnerGitUrl { get; set; }
    }
}
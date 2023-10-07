using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using tools2807.Types;

namespace tools2807
{
    public class tools2807
    {
        public const string _baseurl = "https://tools.2807.eu/api";
        private HttpClient _client;

        public tools2807()
        {
            _client = new HttpClient();
        }

        public async Task<FollowUser[]?> GetFollows(string username)
        {
            string finalurl = _baseurl + $"/getfollows/{username.ToLower()}";
            Uri uri = new Uri(finalurl);

            var responseBody = await GetJSON(uri).ConfigureAwait(false);

            if (responseBody == null)
                return null;

            FollowUser[]? user = null;
            user = JsonConvert.DeserializeObject<FollowUser[]>(responseBody);

            return user;
        }
        public async Task<User[]?> GetMods(string username)
        {
            string finalurl = _baseurl + $"/getmods/{username.ToLower()}";
            Uri uri = new Uri(finalurl);

            var responseBody = await GetJSON(uri).ConfigureAwait(false);

            if (responseBody == null)
                return null;

            User[]? user = null;
            user = JsonConvert.DeserializeObject<User[]>(responseBody);

            return user;
        }
        public async Task<User[]?> GetVips(string username)
        {
            string finalurl = _baseurl + $"/getvips/{username.ToLower()}";
            Uri uri = new Uri(finalurl);

            var responseBody = await GetJSON(uri).ConfigureAwait(false);

            if (responseBody == null)
                return null;

            User[]? user = null;
            user = JsonConvert.DeserializeObject<User[]>(responseBody);

            return user;
        }
        public async Task<FounderUser[]?> GetFounders(string username)
        {
            string finalurl = _baseurl + $"/getfounders/{username.ToLower()}";
            Uri uri = new Uri(finalurl);

            var responseBody = await GetJSON(uri).ConfigureAwait(false);

            if (responseBody == null)
                return null;

            FounderUser[]? user = null;
            user = JsonConvert.DeserializeObject<FounderUser[]>(responseBody);

            return user;
        }

        private async Task<string?> GetJSON(Uri uri)
        {
            string timeFix = uri.ToString().Contains("?") ? "&time" : "?time";
            var request = new HttpRequestMessage(HttpMethod.Get, $"{uri}{timeFix}={DateTime.Now}");
            var response = await _client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }
    }
}

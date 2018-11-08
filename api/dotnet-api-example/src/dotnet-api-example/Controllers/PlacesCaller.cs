using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace gplaces_api.Controllers
{
    public static class PlacesCaller
    {
        public async static Task<string> call(string locationQuery){
            string url = "https://maps.googleapis.com/maps/api/place/textsearch/json?query={0}&key={1}";
            string apiKey = "AIzaSyDkaaQ0tpah5-kB9mlGzsUG7zH6YTOOXvw";
            url = String.Format(url, locationQuery, apiKey);
            
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponse = await httpClient.GetAsync(url);
            HttpContent httpContent = httpResponse.Content;
            return await httpContent.ReadAsStringAsync();
        }
    }
}
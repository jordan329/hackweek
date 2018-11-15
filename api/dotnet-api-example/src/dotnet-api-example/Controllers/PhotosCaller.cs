using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace gplaces_api.Controllers
{
    public static class PhotosCaller
    {
        public async static Task<string> call(string photo){
            string url = "https://maps.googleapis.com/maps/api/place/photo?key={0}&photoreference={1}&maxheight=500";
            string apiKey = "AIzaSyDkaaQ0tpah5-kB9mlGzsUG7zH6YTOOXvw";
            url = String.Format(url, photo, apiKey);
            
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponse = await httpClient.GetAsync(url);
            HttpContent httpContent = httpResponse.Content;
            return await httpContent.ReadAsStringAsync();
        }
    }
}
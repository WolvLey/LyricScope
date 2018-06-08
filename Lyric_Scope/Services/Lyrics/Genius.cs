using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LyricScope.Services.Spotify;
using System.Net.Http;
using System.Net.Http.Headers;
using HtmlAgilityPack;


namespace LyricScope.Services.Lyrics
{
    public class Genius : ILyricsService
    {
        private const string HOST = "https://genius.com";
        private const string PRAFIX = "/api/search/multi?per_page=5&q=";

        private string _compositeUrl;

        private string _lyrics;

        private HttpClient client;

        public Genius()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(HOST);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private string GetFilteredSongUrl(string url)
        {
            // TODO: Change to not only "First Hit".
            using (var response = client.GetAsync(url).Result)
            {
                using (var content = response.Content)
                {
                    string responseString = content.ReadAsStringAsync().Result;

                    var json = JsonConvert.DeserializeObject<dynamic>(responseString);

                    foreach (var section in json.response.sections)
                    {
                        if (section.type == "song")
                        {
                            foreach (var hit in section.hits)
                            {
                                return hit.result.url;
                            }
                        }
                    }

                    return "";
                }
            }
        }

        public string GetLyrics(string interpret, string title, string album = "")
        {
            if (interpret == null || title == null)
            {
                return "loading";
            }

            interpret = System.Net.WebUtility.UrlEncode(interpret);
            title = System.Net.WebUtility.UrlEncode(title);
            //album = System.Net.WebUtility.UrlEncode(album);

            _compositeUrl = $"{PRAFIX}%20{interpret}%20{title}%20{album}";

            string url = GetFilteredSongUrl(_compositeUrl);

            using (var response = client.GetAsync(url).Result)
            {
                using (var content = response.Content)
                {
                    var result = content.ReadAsStringAsync().Result;
                    var document = new HtmlDocument();
                    document.LoadHtml(result);
                    var node = document.DocumentNode.SelectSingleNode("//div[contains(@class,'lyrics')]/p");
                    //TODO: Error handling
                    if (node == null)
                    {
                        string shortTitle = "";

                        foreach (char c in title)
                        {
                            if (c == '-')
                                return GetLyrics(interpret, shortTitle);

                            shortTitle += c;
                        }


                        return "no text found";
                    }

                    _lyrics = HtmlAgilityPack.HtmlEntity.DeEntitize(node.InnerText);

                    return _lyrics;
                }
            }
        }
    }
}
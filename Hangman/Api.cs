namespace Hangman;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Api
{ 
    static HttpClient _client = new HttpClient();

    public static async Task<string> Get(string url)
    {
        try
        {
            var response = await _client.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e);
        }

        return "Unable to retrieve API response";
    }
}


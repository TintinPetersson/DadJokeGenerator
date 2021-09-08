using DadJokeGenerator.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DadJokeGenerator.APPI
{
    public class JokeProcessor
    {
        public static async Task<JokeModel> LoadJoke()
        {
            string url = ApiHelper.ApiClient.BaseAddress.ToString();

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JokeModel joke = await response.Content.ReadAsAsync<JokeModel>();

                    return joke;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

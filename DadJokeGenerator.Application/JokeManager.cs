using DadJokeGenerator.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DadJokeGenerator.APPI;

namespace DadJokeGenerator.Application
{
    public class JokeManager
    {
        public async Task<JokeModel> GetJoke()
        {
            JokeModel joke = new JokeModel();

            joke = await JokeProcessor.LoadJoke();

            return joke;
        }
        public string AllinCaps(string oldJoke)
        {
            var allCapsJoke = oldJoke.ToUpper();

            return allCapsJoke;
        }

        public string QuestionMark(string joke)
        {
            var questionJoke = joke + "?";
            return questionJoke;
        }

        public string Reverse(string joke)
        {

            char[] jokeArray = joke.ToCharArray();
            Array.Reverse(jokeArray);
            return new string(jokeArray);
        }
    }
}

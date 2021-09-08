using Microsoft.AspNetCore.Mvc;
using DadJokeGenerator.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadJokeGenerator.UI.Controllers
{
    public class JokeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Generator()
        {
            JokeManager jokeManager = new JokeManager();

            var newJoke = await jokeManager.GetJoke();

            return View(newJoke);
        }
        public IActionResult AllCaps(string joke)
        {
            JokeManager jm = new JokeManager();
            ViewBag.Joke = jm.AllinCaps(joke);

            return View();
        }
        public IActionResult QuestionMark(string joke)
        {
            JokeManager jm = new JokeManager();
            ViewBag.Joke = jm.QuestionMark(joke);

            return View();
        }
        public IActionResult Reverse(string joke)
        {
            JokeManager jm = new JokeManager();
            ViewBag.Joke = jm.Reverse(joke);

            return View();
        }
    }
}

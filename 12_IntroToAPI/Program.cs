using _12_IntroToAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;
            Console.WriteLine((int) response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                string lukeString = response.Content.ReadAsStringAsync().Result;
                string jsonFormatted = JValue.Parse(lukeString).ToString(Formatting.Indented);
                Console.WriteLine(jsonFormatted);

                Person personResponse = response.Content.ReadAsAsync<Person>().Result;

                Console.WriteLine($"{personResponse.Name} is a {personResponse.Gender} from {personResponse.Homeworld}");

                foreach (string filmUrl in personResponse.Films)
                {
                    Console.WriteLine(filmUrl);
                    HttpResponseMessage filmResponse = httpClient.GetAsync(filmUrl).Result;
                    // Console.WriteLine(filmResponse.Content.ReadAsStringAsync().Result);
                    Film film = filmResponse.Content.ReadAsAsync<Film>().Result;
                    Console.WriteLine($"{film.Title} was directed by {film.Director}");
                }
            }

            SWAPIService swapi = new SWAPIService();

            Person leia = swapi.GetPersonAsync("https://swapi.dev/api/people/5/").Result;
            Console.WriteLine(leia.Name);

            Film afilm = swapi.GetFilmAsync("https://swapi.dev/api/films/5/").Result;
            Console.WriteLine(afilm.Title);

            SearchResult<Person> skywalkers = swapi.GetSearchAsync<Person>("people", "skywalker").Result;
            foreach(Person skywalker in skywalkers.Results)
            {
                Console.WriteLine(skywalker.Name);
            }
        }
    }
}

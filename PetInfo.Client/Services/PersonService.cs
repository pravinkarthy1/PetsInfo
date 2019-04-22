using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PetInfo.Client.Models;
using PetInfo.Models;

namespace PetInfo.Client.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonHttpClient _personHttpClient;
        private HttpClient _httpClient;

        public PersonService(IPersonHttpClient personHttpClient)
        {
            _personHttpClient = personHttpClient;
        }

        public async Task<List<OwnerGenderWiseCats>> GetOwnerGenderWiseCats()
        {
            _httpClient = await _personHttpClient.GetClient();

            var response = await _httpClient.GetAsync("people.json");

            if (response.IsSuccessStatusCode)
            {
                var personListAsString = await response.Content.ReadAsStringAsync();
                var personsList = JsonConvert.DeserializeObject<IList<People>>(personListAsString).ToList();

                var genderWiseCatsList = new List<OwnerGenderWiseCats>();

                genderWiseCatsList = personsList.Where(x => x.Pets != null).GroupBy(group => new
                {
                    group.Gender
                }).Select(y => new OwnerGenderWiseCats
                {
                    Gender = y.Key.Gender,
                    Cats = y.SelectMany(z => z.Pets.Where(p => p.Type == "Cat").Select(n => n.Name)).OrderBy(o => o)
                }).ToList();

                return genderWiseCatsList;
            }

            throw new Exception($"A problem happened while calling the API: {response.ReasonPhrase}");
        }
    }
}

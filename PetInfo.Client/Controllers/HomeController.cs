using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PetInfo.Client.Models;
using PetInfo.Client.Services;
using PetInfo.Models;

namespace PetInfo.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }
        public async Task<IActionResult> Index()
        {
            // calling the PersonService
            var genderWiseCatsList = await _personService.GetOwnerGenderWiseCats();
            var galleryIndexViewModel = new PetIndexViewModel(genderWiseCatsList);
            return View(galleryIndexViewModel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

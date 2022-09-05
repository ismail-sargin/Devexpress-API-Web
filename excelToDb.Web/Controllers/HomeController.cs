
using excelToDb.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace excelToDb.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44308/api/");
            HttpResponseMessage response =  await client.GetAsync("data");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Sample> data = JsonConvert.DeserializeObject<List<Sample>>(responseBody);
            ViewBag.Data = data;
            return View();
        }

      
    }
}
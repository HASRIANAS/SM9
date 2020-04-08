using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;
using WebApplication11.Models;
using System.Net.Http;
using System.Web.Helpers;
using Microsoft.Ajax.Utilities;
using System.Web.Script.Serialization;

namespace WebApplication11.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult Index()
        {
            IEnumerable<SM9> sm9s = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:61418/api/SM9");

            var consumApi = hc.GetAsync("SM9");
            consumApi.Wait();

            var readData = consumApi.Result;
            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<IList<SM9>>();
                displayData.Wait();

                sm9s = displayData.Result;

            }
            return View(sm9s);
        }



        public ActionResult Create()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Create(SM9 sm9Insert)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:61418/api/SM9");

            var insertrecord = hc.PostAsJsonAsync<SM9>("SM9", sm9Insert);
            var saveData = insertrecord.Result;
            if (saveData.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");
        }





        public ActionResult Details(int id)
        {
            sm9Class sm9s = null;

            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:61418/api/");


            var consumeApi = hc.GetAsync("SM9?id=" + id.ToString());
            
            consumeApi.Wait();
        //string jsonstring = JsonConvert.SerializeObject(consumeApi);
            var readData = consumeApi.Result;

            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<sm9Class>();
                displayData.Wait();
                sm9s = displayData.Result;
            }
            return View(sm9s);
        }





        public ActionResult Edit(int id)
            {
            sm9Class sm9s = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:61418/api/SM9");
            var consumeApi = hc.GetAsync("sm9?id=" + id.ToString());
            consumeApi.Wait();
            var readData = consumeApi.Result;

            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<sm9Class>();
                displayData.Wait();
                sm9s = displayData.Result;
            }
            return View("sm9s");
        }





        [HttpPost]
        public ActionResult Edit(sm9Class sc)
            {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:61418/api/SM9");
            var insertrecord = hc.PutAsJsonAsync<sm9Class>("sm9", sc);
            var saveData = insertrecord.Result;
            if (saveData.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "update not completed...";
            }
            return View(sc);
        }
    }
}
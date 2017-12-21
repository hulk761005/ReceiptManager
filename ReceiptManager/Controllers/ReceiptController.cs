using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using ReceiptManager.Models;

namespace ReceiptManager.Controllers
{
    public class ReceiptController : Controller
    {
        
        // GET: Receipt
        public ActionResult Index()
        {
            var listReceipt = new List<ReceiptViewModel>();
            MongoClient _client = new MongoClient("mongodb://192.168.10.219:27017");
            var db = _client.GetDatabase("MyAccounting");
            var collection = db.GetCollection<ReceiptViewModel>("receipt");
            return View(collection.Find(_ => true).ToList());
        }

        // GET: Receipt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Receipt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receipt/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receipt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Receipt/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receipt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Receipt/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

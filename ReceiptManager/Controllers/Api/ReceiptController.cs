using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReceiptManager.Models;
using MongoDB.Driver;

namespace ReceiptManager.Controllers.Api
{
    public class ReceiptController : ApiController
    {
        // GET: api/Receipt
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Receipt/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Receipt
        public void Post(ReceiptAddViewModel model)
        {
            MongoClient _client = new MongoClient("mongodb://192.168.10.219:27017");
            var db = _client.GetDatabase("MyAccounting");
            var collection = db.GetCollection<ReceiptAddViewModel>("receipt");
            collection.InsertOne(model);
        }

        // PUT: api/Receipt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Receipt/5
        public void Delete(int id)
        {
        }
    }
}

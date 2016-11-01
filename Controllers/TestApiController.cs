using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;

namespace WebApplication{
    
    public class TestApiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var client = new MongoClient("mongodb://192.168.56.100:27017");
            var database = client.GetDatabase("mongopein");
            var collection = database.GetCollection<KchoClass>("kchocollection");

            var instance = new KchoClass(){ Name = "Nombre", Value = "Valor"};

            collection.InsertOne(instance);

            var filter = Builders<KchoClass>.Filter.Eq("Name", "Nombre");

            return Ok(collection.Find(filter));
        }
    }

    public class KchoClass
    {
        public string Name {get;set;}
        public string Value {get;set;}
    }
}
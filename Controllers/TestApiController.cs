using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace WebApplication
{

    public class TestApiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var client = new MongoClient("mongodb://172.17.0.2:27017");
            var database = client.GetDatabase("mongopein");
            var collection = database.GetCollection<KchoClass>("kchocollection");

            var instance = new KchoClass(){ Name = "Nombre", Value = "Valor"};

            collection.InsertOne(instance);

            var filter = Builders<KchoClass>.Filter.Eq("Name", "Nombre");

            return Ok(collection.Count(filter));
        }
    }

    public class KchoClass
    {
        public string Name {get;set;}
        public string Value {get;set;}
    }
}
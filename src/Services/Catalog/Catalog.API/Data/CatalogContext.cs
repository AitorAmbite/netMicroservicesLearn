using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {

        public CatalogContext(IConfiguration config)
        {
            string connectionString = config.GetValue<String>("DatabaseSettings:ConnectionString");
            string databaseName = config.GetValue<String>("DatabaseSettings:databaseName");
            string CollectionString = config.GetValue<String>("DatabaseSettings:CollectionName");

            MongoClient Client = new MongoClient(connectionString);
            IMongoDatabase database = Client.GetDatabase(databaseName);
            Products = database.GetCollection<Product>(CollectionString); 
            CatalogContextSeed.seedData(Products);
        }

        public IMongoCollection<Product> Products { get; set; }
    }
}

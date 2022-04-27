using DotNetPocModels.Models;
using DotNetPocRepositories.Interface;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPocRepositories.Repository
{
    public class ElementRepository : IElementRepository
    {
        private readonly IMongoCollection<Element> _elementCollection;
        public ElementRepository(IOptions<ElementDatabaseSettings> elementDatabaseSettings)
        {
            var mongoClient = new MongoClient(elementDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(elementDatabaseSettings.Value.DatabaseName);
            _elementCollection = mongoDatabase.GetCollection<Element>(elementDatabaseSettings.Value.ElementCollectionName);


        }
        public void DeleteR(string id)
        {
            var filter = Builders<Element>.Filter.Eq("workUrn", id);
            _elementCollection.DeleteOne(filter);
        }

        public List<Element> GetR()
        {
              var documents = _elementCollection.Find(x => true).ToList();
           // var documents = _elementCollection.
            return documents;
           
        }

        public List<Element> GetR(string id)
        {
            
            var documents = _elementCollection.Find(x => x.workUrn == id).ToList();
            return documents;
          
        }

        public Element PostR(Element elem)
        {
            
            _elementCollection.InsertOne(elem);
          
            return elem;    
            
        }

        public dynamic PutR(string id,Element elem)
        {
            var filter = Builders<Element>.Filter.Eq("workUrn", elem.workUrn);

            var update = Builders<Element>.Update.Set("entityUrn", elem.entityUrn).Set("slateManifestUrn", elem.slateManifestUrn).Set("Text", elem.Text).Set("type", elem.type).Set("createdBy", elem.createdBy).Set("createdTimestamp", elem.createdTimestamp).Set("updatedBy", elem.updatedBy).Set("updatedTimestamp", elem.updatedTimestamp);

            _elementCollection.UpdateOne(filter, update);
            return elem;
        }
    }
}

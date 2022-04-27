using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPocModels.Models
{
    public class Element
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; } = string.Empty;
        public string workUrn { get; set; } = string.Empty;
        public string entityUrn { get; set; }
        public string type { get; set; }
        public string slateManifestUrn { get; set; }
        public string Text { get; set; }
        public string createdBy { get; set; }
        public DateTime createdTimestamp { get; set; }
        public string updatedBy { get; set; }
        public DateTime updatedTimestamp { get; set; }
    }
}

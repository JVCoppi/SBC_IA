using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    [BsonIgnoreExtraElements()]
    public class Propriedade
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Valor")]
        public int valor { get; set; }
        [BsonElement("Atributo")]
        public string atributo { get; set; }
        [BsonElement("Classe")]
        public string classe { get; set; }
        [BsonElement("Peso")]
        public int peso { get; set; }
        [BsonElement("Similaridade")]
        public string similaridade { get; set; }
    }

}

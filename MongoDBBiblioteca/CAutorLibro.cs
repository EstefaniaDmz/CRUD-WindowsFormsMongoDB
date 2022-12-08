using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBBiblioteca
{
    internal class CAutorLibro
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("idAutor")]
        public ObjectId IdAutor { get; set; }
        [BsonElement("idLibro")]
        public ObjectId IdLibro { get; set; }

        public CAutorLibro(ObjectId idAutor, ObjectId idLibro)
        {
            IdAutor = idAutor;
            IdLibro = idLibro;
        }
        public CAutorLibro()
        {
            Id= IdAutor = IdLibro = ObjectId.Empty;
        }
    }
}

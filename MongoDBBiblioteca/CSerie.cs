using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBBiblioteca
{
    internal class CSerie
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        public CSerie(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public CSerie()
        {
            Id = ObjectId.Empty;
            Nombre = null;
            Descripcion = null;
        }
    }
}

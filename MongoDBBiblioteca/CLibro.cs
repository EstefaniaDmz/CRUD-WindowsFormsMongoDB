using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBBiblioteca
{
    internal class CLibro
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("titulo")]
        public string Titulo { get; set; }
        [BsonElement("isbn")]
        public string Isbn { get; set; }
        [BsonElement("precio")]
        public double Precio { get; set; }
        [BsonElement("editorial")]
        public string Editorial { get; set; }
        [BsonElement("idSerie")]
        public ObjectId IdSerie { get; set; }
        public CLibro()
        {
            Titulo = null;
            Isbn = null;
            Precio = 0;
            Editorial = null;
            IdSerie = ObjectId.Empty;
        }
        public CLibro(string titulo, string isbn, double precio, string editorial, ObjectId idSerie)
        {
            Titulo = titulo;
            Isbn = isbn;
            Precio = precio;
            Editorial = editorial;
            IdSerie = idSerie;
        }
    }
}

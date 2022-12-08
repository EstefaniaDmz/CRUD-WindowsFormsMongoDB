using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDBBiblioteca
{
    internal class CAutor
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("apellidoPaterno")]
        public string ApellidoPaterno { get; set; }
        [BsonElement("apellidoMaterno")]
        public string ApellidoMaterno { get; set; }
        [BsonElement("correo")]
        public string Correo { get; set; }
        [BsonElement("telefono")]
        public string Telefono { get; set; }

        public CAutor(string nombre, string apellidoPaterno, string apellidoMaterno, string correo, string telefono)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Correo = correo;
            Telefono = telefono;
        }

        public CAutor()
        {
            Id = ObjectId.Empty;
            Nombre = ApellidoMaterno = ApellidoPaterno = Correo = Telefono = null;
        }
    }
}

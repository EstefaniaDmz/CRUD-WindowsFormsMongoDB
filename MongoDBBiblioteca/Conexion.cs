using MongoDB.Driver;

namespace MongoDBBiblioteca
{
    internal class Conexion
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("biblioteca");
    }
}

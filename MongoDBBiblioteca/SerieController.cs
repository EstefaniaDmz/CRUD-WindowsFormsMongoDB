using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBBiblioteca
{
    internal class SerieController
    {
        SerieForm sf = new SerieForm();
        IMongoCollection<CSerie> collection = Conexion.db.GetCollection<CSerie>("Serie");
        public void Insert()
        {
            sf.Limpiar();
            if(sf.ShowDialog() == DialogResult.OK)
            {
                if (sf.txtDesc.Text == null || sf.txtNombre.Text == null)
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                    return;
                }
                CSerie serie = new CSerie(sf.txtNombre.Text, sf.txtDesc.Text);
                collection.InsertOne(serie);
            }
        }
        public void Read(DataGridView dgv)
        {
            List<CSerie> list = collection.AsQueryable().ToList();
            dgv.DataSource = list;
        }
        public List<CSerie> Read()
        {
            return collection.AsQueryable().ToList(); 
        }
        public void Update(string id)
        {
            var filter = Builders<CSerie>.Filter.Eq("_id", ObjectId.Parse(id));
            var serie = collection.Find(filter).FirstOrDefault();
            sf.Llenar(serie.Nombre, serie.Descripcion);
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (sf.txtNombre.Text == null || sf.txtDesc.Text == null)
                {
                    MessageBox.Show("Favor de no dejar campos vacíos");
                    return;
                }
                var update = Builders<CSerie>.Update.Set("nombre", sf.txtNombre.Text).Set("descripcion", sf.txtDesc.Text);
                collection.UpdateOne(rs => rs.Id == ObjectId.Parse(id), update);
                sf.Limpiar();
            }
        }
        public void Delete(string id)
        {
            var filter = Builders<CSerie>.Filter.Eq("_id", ObjectId.Parse(id));
            collection.DeleteOne(filter);
        }
    }
}

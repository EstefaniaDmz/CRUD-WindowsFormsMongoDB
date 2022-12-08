using MongoDB.Driver;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDBBiblioteca
{
    internal class AutorController
    {
        AutorForm af = new AutorForm();
        IMongoCollection<CAutor> collection = Conexion.db.GetCollection<CAutor>("Autor");
        public void Insert()
        {
            af.Limpiar();
            if(af.ShowDialog() == DialogResult.OK)
            {
                if(af.txtApM.Text == "" || af.txtApP.Text == "" || af.txtCorreo.Text == "" || af.txtNombre.Text == "" || af.txtTel.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                    return;
                }
                CAutor autor = new CAutor(af.txtNombre.Text, af.txtApP.Text, af.txtApM.Text, af.txtCorreo.Text, af.txtTel.Text);
                collection.InsertOne(autor);
            }
        }
        public void Read(DataGridView dgv)
        {
            List<CAutor> list = collection.AsQueryable().ToList();
            dgv.DataSource = list;
        }
        public List<CAutor> Read()
        {
            return collection.AsQueryable().ToList();
        }
        public void Update(string id)
        {
            var filter = Builders<CAutor>.Filter.Eq("_id", ObjectId.Parse(id));
            var autor = collection.Find(filter).FirstOrDefault();
            af.Llenar(autor.Nombre, autor.ApellidoPaterno, autor.ApellidoMaterno, autor.Correo, autor.Telefono);
            if (af.ShowDialog() == DialogResult.OK)
            {
                if (af.txtApM.Text == "" || af.txtApP.Text == "" || af.txtCorreo.Text == "" || af.txtNombre.Text == "" || af.txtTel.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos vacíos");
                    return;
                }
                var update = Builders<CAutor>.Update.Set("nombre", af.txtNombre.Text).Set("apellidoPaterno", af.txtApP.Text).Set("apellidoMaterno", af.txtApM.Text)
                    .Set("correo", af.txtCorreo.Text).Set("telefono", af.txtTel.Text);
                collection.UpdateOne(rs => rs.Id == ObjectId.Parse(id), update);
                af.Limpiar();
            }
        }
        public void Delete(string id)
        {
            var filter = Builders<CAutor>.Filter.Eq("_id", ObjectId.Parse(id));
            collection.DeleteOne(filter);
        }
    }
}

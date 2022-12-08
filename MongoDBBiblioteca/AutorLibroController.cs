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
    internal class AutorLibroController
    {
        AutorLibroForm alf = new AutorLibroForm();
        IMongoCollection<CAutorLibro> collection = Conexion.db.GetCollection<CAutorLibro>("AutorLibro");
        public void Insert()
        {
            alf.LlenarComboBox();
            alf.Limpiar();
            if(alf.ShowDialog() == DialogResult.OK)
            {
                if(alf.cmbAutor.SelectedIndex == -1 || alf.cmbLibro.SelectedIndex == -1)
                {
                    MessageBox.Show("FALTAN DATOS");
                    return;
                }
                CAutorLibro autorlibro = new CAutorLibro(ObjectId.Parse(alf.cmbAutor.Text), ObjectId.Parse(alf.cmbLibro.Text));
                collection.InsertOne(autorlibro);
            }
        }
        public void Read(DataGridView dgv)
        {
            List<CAutorLibro> list = collection.AsQueryable().ToList();
            dgv.DataSource = list;
        }
        public void Update(string id)
        {
            var filter = Builders<CAutorLibro>.Filter.Eq("_id", ObjectId.Parse(id));
            var autorlibro = collection.Find(filter).FirstOrDefault();
            alf.Llenar(autorlibro.IdAutor.ToString(), autorlibro.IdLibro.ToString());
            if(alf.ShowDialog() == DialogResult.OK)
            {
                if (alf.cmbAutor.SelectedIndex == -1 || alf.cmbLibro.SelectedIndex == -1)
                {
                    MessageBox.Show("FALTAN DATOS");
                    return;
                }
                var update = Builders<CAutorLibro>.Update.Set("idAutor", ObjectId.Parse(alf.cmbAutor.Text)).Set("idLibro", ObjectId.Parse(alf.cmbLibro.Text));
                collection.UpdateOne(rs => rs.Id == ObjectId.Parse(id), update);
                alf.Limpiar();
            }
        }
        public void Delete(string id)
        {
            var filter = Builders<CAutorLibro>.Filter.Eq("_id", ObjectId.Parse(id));
            collection.DeleteOne(filter);
        }
    }
}

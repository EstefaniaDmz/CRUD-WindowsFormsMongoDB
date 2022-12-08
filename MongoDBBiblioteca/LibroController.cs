using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBBiblioteca
{
    internal class LibroController
    {
        LibroForm lf = new LibroForm();
        IMongoCollection<CLibro> collection = Conexion.db.GetCollection<CLibro>("Libro");
        public void Insert()
        {
            lf.LlenarComboBox();
            lf.Limpiar();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                if(lf.txtTitulo.Text == null || lf.txtIsbn.Text == null || lf.txtPrecio.Text == null || lf.txtEditorial.Text == null)
                {
                    MessageBox.Show("FALTAN DATOS");
                    return;
                }
                ObjectId idsito;
                if(lf.cmbSerie.SelectedIndex == -1)
                {
                    idsito = ObjectId.Empty;
                }
                else
                {
                    idsito = ObjectId.Parse(lf.cmbSerie.Text);
                }
                CLibro libro = new CLibro(lf.txtTitulo.Text, lf.txtIsbn.Text, Double.Parse(lf.txtPrecio.Text), lf.txtEditorial.Text, idsito);
                collection.InsertOne(libro);
            }
        }

        public void Read(DataGridView dgv)
        {
            List<CLibro> list = collection.AsQueryable().ToList();
            dgv.DataSource = list;
        }
        public List<CLibro> Read()
        {
            return collection.AsQueryable().ToList();
        }
        public void Update(string id)
        {
            var filter = Builders<CLibro>.Filter.Eq("_id", ObjectId.Parse(id));
            var book = collection.Find(filter).FirstOrDefault();
            lf.Llenar(book.Titulo, book.Isbn, book.Precio.ToString(), book.Editorial, book.IdSerie.ToString());
            if (lf.ShowDialog() == DialogResult.OK)
            {
                if (lf.txtTitulo.Text == null || lf.txtIsbn.Text == null || lf.txtPrecio.Text == null || lf.txtEditorial.Text == null)
                {
                    MessageBox.Show("Favor de no dejar campos vacíos");
                    return;
                }
                ObjectId idsito;
                if (lf.cmbSerie.SelectedIndex == -1)
                {
                    idsito = ObjectId.Empty;
                }
                else
                {
                    idsito = ObjectId.Parse(lf.cmbSerie.Text);
                }
                var update = Builders<CLibro>.Update.Set("titulo", lf.txtTitulo.Text).Set("isbn", lf.txtIsbn.Text)
                    .Set("precio", lf.txtPrecio.Text).Set("editorial", lf.txtEditorial.Text).Set("idSerie", idsito);
                collection.UpdateOne(rs=> rs.Id == ObjectId.Parse(id), update);
                lf.Limpiar();
            }
        }

        public void Delete(string id)
        {
            var filter = Builders<CLibro>.Filter.Eq("_id", ObjectId.Parse(id));
            collection.DeleteOne(filter);
        }
    }
}

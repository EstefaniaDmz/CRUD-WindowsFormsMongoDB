using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBBiblioteca
{
    public partial class LibroForm : Form
    {
        SerieController serie = new SerieController();

        public LibroForm()
        {
            InitializeComponent();
            txtTitulo.Focus();
        }
        public void Llenar(string titulo, string isbn, string precio, string editorial, string id)
        {
            LlenarComboBox();
            txtTitulo.Text = titulo;
            txtIsbn.Text = isbn;
            txtPrecio.Text = precio;
            txtEditorial.Text = editorial;
            cmbSerie.SelectedItem = id;
        }
        public void Limpiar()
        {
            cmbSerie.SelectedIndex = -1;
            txtTitulo.Clear();
            txtIsbn.Clear();
            txtPrecio.Clear();
            txtEditorial.Clear();
        }
        public void LlenarComboBox()
        {
            cmbSerie.Items.Clear();
            foreach (CSerie item in serie.Read())
            {
                cmbSerie.Items.Add(item.Id.ToString());
            }
        }
        private void LibroForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBBiblioteca
{
    public partial class AutorLibroForm : Form
    {
        AutorController autor = new AutorController();
        LibroController libro = new LibroController();

        public AutorLibroForm()
        {
            InitializeComponent();
        }
        public void LlenarComboBox()
        {
            cmbAutor.Items.Clear();
            cmbLibro.Items.Clear();
            foreach (CAutor item in autor.Read())
            {
                cmbAutor.Items.Add(item.Id.ToString());
            }
            foreach (CLibro item in libro.Read())
            {
                cmbLibro.Items.Add(item.Id.ToString());
            }
        }
        public void Llenar(string idA, string idL)
        {
            LlenarComboBox();
            cmbAutor.SelectedItem = idA;
            cmbLibro.SelectedItem = idL;
        }
        public void Limpiar()
        {
            cmbLibro.SelectedIndex = -1;
            cmbAutor.SelectedIndex = -1;
        }
        private void AutorLibroForm_Load(object sender, EventArgs e)
        {

        }
    }
}

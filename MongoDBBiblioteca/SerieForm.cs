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
    public partial class SerieForm : Form
    {
        public SerieForm()
        {
            InitializeComponent();
            txtNombre.Focus();
        }
        public void Llenar(string nom, string desc)
        {
            txtNombre.Text = nom;
            txtDesc.Text = desc;
        }
        public void Limpiar()
        {
            txtNombre.Clear();
            txtDesc.Clear();
        }
        private void SerieForm_Load(object sender, EventArgs e)
        {

        }
    }
}

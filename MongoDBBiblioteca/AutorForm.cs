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
    public partial class AutorForm : Form
    {
        public AutorForm()
        {
            InitializeComponent();
        }
        public void Llenar(string nom, string app, string apm, string cor, string tel)
        {
            txtNombre.Text = nom;
            txtApP.Text = app;
            txtApM.Text = apm;
            txtCorreo.Text = cor;
            txtTel.Text = tel;
        }
        public void Limpiar()
        {
            txtApM.Clear();
            txtApP.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtTel.Clear();
        }
        private void AutorForm_Load(object sender, EventArgs e)
        {

        }
    }
}

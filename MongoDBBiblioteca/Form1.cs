using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBBiblioteca
{
    public partial class Form1 : Form
    {
        int bandera = 1;
        LibroController libro = new LibroController();
        SerieController serie = new SerieController();
        AutorController autor = new AutorController();
        AutorLibroController autorlibro = new AutorLibroController();
        public Form1()
        {
            InitializeComponent();
            libro.Read(dgvTabla);
            lblTabla.Text = "Libro";
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autor.Read(dgvTabla);
            lblTabla.Text = "Autor";
            bandera = 0;
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libro.Read(dgvTabla);
            lblTabla.Text = "Libro";
            bandera = 1;
        }

        private void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serie.Read(dgvTabla);
            lblTabla.Text = "Serie";
            bandera = 2;
        }

        private void autorLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorlibro.Read(dgvTabla);
            lblTabla.Text = "Autor - Libro";
            bandera = 3;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (bandera)
            {
                case 0: autor.Insert(); autor.Read(dgvTabla); break;
                case 1: libro.Insert(); libro.Read(dgvTabla); break;
                case 2: serie.Insert(); serie.Read(dgvTabla); break;
                case 3: autorlibro.Insert(); autorlibro.Read(dgvTabla); break;
            }
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (bandera)
            {
                case 0:
                    if (MessageBox.Show("¿Modificar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        autor.Update(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    else if (MessageBox.Show("¿Eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        autor.Delete(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    else { return; }
                    autor.Read(dgvTabla); break;
                case 1: if(MessageBox.Show("¿Modificar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            libro.Update(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                        } else if(MessageBox.Show("¿Eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            libro.Delete(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                        } else { return; }
                        libro.Read(dgvTabla); break;
                case 2:
                    if (MessageBox.Show("¿Modificar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        serie.Update(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    else if (MessageBox.Show("¿Eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        serie.Delete(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    else { return; }
                    serie.Read(dgvTabla); break;
                case 3:
                    if (MessageBox.Show("¿Modificar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        autorlibro.Update(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    else if (MessageBox.Show("¿Eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        autorlibro.Delete(dgvTabla.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    else { return; }
                    autorlibro.Read(dgvTabla); break;
            }
        }
    }
}

using RegistroLibros.UI.Consultas;
using RegistroLibros.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibros
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registrosDeTipoDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTiposLibros r = new RegistroTiposLibros();
            r.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la aplicacion?",
                       "Consulta",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }

        private void consultaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaLibros c = new ConsultaLibros();
            c.Show();
        }

        private void consultaDeTiposDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTiposLibros c = new ConsultaTiposLibros();
            c.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void registroDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLibros r = new rLibros();
            r.Show();
        }
    }
}

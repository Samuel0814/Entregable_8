using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibros.UI.Registros
{
    public partial class RegistroTiposLibros : Form
    {
        public RegistroTiposLibros()
        {
            InitializeComponent();
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox,
                    "Debes digitar la descripcion");
                HayErrores = true;
            }
            return HayErrores;

        }

        private Tipos LlenaClase()
        {
            Tipos tipos = new Tipos();

            tipos.TipoId = Convert.ToInt32(TipoIDnumericUpDown.Value);
            tipos.Descripcion =  DescripciontextBox.Text;

            return tipos;
        }

        private void RegistroTiposLibros_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TipoIDnumericUpDown.Value);
            Tipos tipos = BLL.TipoBLL.Buscar(id);

            if (tipos != null)
            {
                DescripciontextBox.Text = tipos.Descripcion;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            DescripciontextBox.Clear();
            MyerrorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Tipos tipos;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tipos = LlenaClase();


            if (TipoIDnumericUpDown.Value == 0)
                Paso = BLL.TipoBLL.Guardar(tipos);
            else
                Paso = BLL.TipoBLL.Modificar(LlenaClase());


            if (Paso)
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TipoIDnumericUpDown.Value);

            if (BLL.TipoBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

using RegistroLibros.DAL;
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
    public partial class RegistroLibros : Form
    {
        public RegistroLibros()
        {
            InitializeComponent();
            LlenaComboBox();
        }

        private void LlenaComboBox()
        {
            Repositorio<Tipos> ArtRepositorio = new Repositorio<Tipos>(new Contexto());

            TipocomboBox.DataSource = ArtRepositorio.GetList(c => true);
            TipocomboBox.ValueMember = "TiposID";
            TipocomboBox.DisplayMember = "Descripcion";

        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox,
                    "Debes digitar la descripcion del libro");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(SiglastextBox.Text))
            {
                MyerrorProvider.SetError(SiglastextBox,
                    "Debes digitar las siglas del libro");
                HayErrores = true;
            }
            return HayErrores;

        }

        private Libros LlenaClase()
        {
            Libros libros = new Libros();

            libros.LibroId = Convert.ToInt32(LibroIDnumericUpDown.Value);
            libros.Fecha = FechadateTimePicker.Value;
            libros.Descripcion = DescripciontextBox.Text;
            libros.Siglas = SiglastextBox.Text;
            
            return libros;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIDnumericUpDown.Value);

            Libros libros = BLL.LibrosBLL.Buscar(id);

            if (libros != null)
            {
                FechadateTimePicker.Value = libros.Fecha;
                DescripciontextBox.Text = libros.Descripcion;
                SiglastextBox.Text = libros.Siglas;
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegistroLibros_Load(object sender, EventArgs e)
        {
            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LibroIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            DescripciontextBox.Clear();
            SiglastextBox.Clear();
            MyerrorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Libros libros;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            libros = LlenaClase();

            if (LibroIDnumericUpDown.Value == 0)
                Paso = BLL.LibrosBLL.Guardar(libros);
            else
                Paso = BLL.LibrosBLL.Modificar(LlenaClase());

            if (Paso)
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIDnumericUpDown.Value);

            if (BLL.LibrosBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

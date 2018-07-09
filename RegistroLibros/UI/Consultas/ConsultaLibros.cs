using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibros.UI.Consultas
{
    public partial class ConsultaLibros : Form
    {
        public ConsultaLibros()
        {
            InitializeComponent();
        }

        private void Llenar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Fecha");
            FiltrocomboBox.Items.Insert(2, "Todo");
        }

        private void ConsultaLibros_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 2)
            {
                CriteriotextBox.Visible = false;
                Criteriolabel.Visible = false;
            }
            else
            {
                CriteriotextBox.Visible = true;
                Criteriolabel.Visible = true;
            }
        }

        private void Buscatbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Libros, bool>> filtro = a => true;
            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Filtrando por ID.
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = a => a.LibroId == id;
                    break;
                case 1://Filtrando por la Fecha .
                    filtro = a => a.Fecha >= DesdedateTimePicker.Value && a.Fecha <= HastadateTimePicker.Value;
                    break;
                case 2://Todo
                    Expression<Func<Libros, bool>> filtro1 = a => true;
                    break;
            }

            ConsultadataGridView.DataSource = BLL.LibrosBLL.GetList(filtro);
        }
    }
}

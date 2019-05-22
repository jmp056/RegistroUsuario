using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class CUsuarios : Form
    {
        public CUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = UsuariosBLL.GetList(p => true);
                        break;

                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = UsuariosBLL.GetList(p => p.IdUsuario == id);
                        break;

                    case 2://Nombre
                        listado = UsuariosBLL.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;

                    case 3://Apellido
                        listado = UsuariosBLL.GetList(p => p.Apellido.Contains(CriterioTextBox.Text));
                        break;

                    case 4://Email
                        listado = UsuariosBLL.GetList(p => p.Email.Contains(CriterioTextBox.Text));
                        break;

                    case 5://Usuario
                        listado = UsuariosBLL.GetList(p => p.Usuario.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.FechaDeIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaDeIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = UsuariosBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }


    }
}


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
    public partial class CCargos : Form
    {
        public CCargos()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cargos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = CargosBLL.GetList(p => true);
                        break;

                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = CargosBLL.GetList(p => p.IdCargo == id);
                        break;

                    case 2://Descripcion del cargo
                        listado = CargosBLL.GetList(p => p.DescripcionCargo.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = CargosBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}

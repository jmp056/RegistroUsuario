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

namespace ProyectoFinal.UI.Registros
{
    public partial class RCargos : Form
    {
        public RCargos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdCargoNumericUpDown.Value = 0;
            DescripcionCargoTextBox.Text = String.Empty;
        }

        private Cargos LlenaClase()
        {
            Cargos cargo = new Cargos();
            cargo.IdCargo = Convert.ToInt32(IdCargoNumericUpDown.Value);
            cargo.DescripcionCargo = DescripcionCargoTextBox.Text;
            return cargo;
        }

        private void LlenaCampos(Cargos cargo)
        {
            IdCargoNumericUpDown.Value = cargo.IdCargo;
            DescripcionCargoTextBox.Text = cargo.DescripcionCargo;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (DescripcionCargoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionCargoTextBox, "El campo \"Descripcion del cargo\" no puede estar vacio");
                DescripcionCargoTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Cargos cargo = CargosBLL.Buscar((int)IdCargoNumericUpDown.Value);
            return (cargo != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Cargos cargo = new Cargos();
            int.TryParse(IdCargoNumericUpDown.Text, out id);

            Limpiar();
            cargo = CargosBLL.Buscar(id);

            if (cargo != null)
            {
                MessageBox.Show("Cargo encontrado");
                LlenaCampos(cargo);
            }
            else
                MessageBox.Show("Cargo no encontrado");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cargos cargo;
            bool paso = false;

            if (!Validar())
                return;

            cargo = LlenaClase();
            Limpiar();

            if (IdCargoNumericUpDown.Value == 0)
                paso = CargosBLL.Guardar(cargo);
            /*else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cargo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargosBLL.Modificar(cargo);
            }*/

            if (paso)
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Cargos cargo;
            bool paso = false;

            if (!Validar())
                return;

            cargo = LlenaClase();
            Limpiar();

            if (ExisteEnLaBaseDeDatos() == false)
                paso = CargosBLL.Modificar(cargo);
            else
            {
                MessageBox.Show("No se puede modificar un cargo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (paso)
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

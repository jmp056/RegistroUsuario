﻿using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using System;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RUsuarios : Form
    {
        public RUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdUsuarioNumericUpDown.Value = 0;
            NombreTextBox.Text = String.Empty;
            ApellidoTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            AdministradorRadioButton.Checked = false;
            SupervisorRadioButton.Checked = false;
            SoporteRadioButton.Checked = false;
            UsuarioRadioButton.Checked = false;
            UsuarioTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            FechaDeIngresoDateTimePicker.Value = DateTime.Now;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.IdUsuario = Convert.ToInt32(IdUsuarioNumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Apellido = ApellidoTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            if (AdministradorRadioButton.Checked == true)
                usuario.NivelDeUsuario = 1;
            else if (SupervisorRadioButton.Checked == true)
                usuario.NivelDeUsuario = 2;
            else if (SoporteRadioButton.Checked == true)
                usuario.NivelDeUsuario = 3;
            else
                usuario.NivelDeUsuario = 4;
            usuario.Usuario = UsuarioTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.FechaDeIngreso = FechaDeIngresoDateTimePicker.Value;
            return usuario;
        }

        private void LlenaCampos(Usuarios usuario)
        {
            IdUsuarioNumericUpDown.Value = usuario.IdUsuario;
            NombreTextBox.Text = usuario.Nombre;
            ApellidoTextBox.Text = usuario.Apellido;
            EmailTextBox.Text = usuario.Email;
            if (usuario.NivelDeUsuario == 1)
                AdministradorRadioButton.Checked = true;
            else if (usuario.NivelDeUsuario == 2)
                SupervisorRadioButton.Checked = true;
            else if (usuario.NivelDeUsuario == 3)
                SoporteRadioButton.Checked = true;
            else if(usuario.NivelDeUsuario == 4)
                UsuarioRadioButton.Checked = true;
            UsuarioTextBox.Text = usuario.Usuario;
            ClaveTextBox.Text = usuario.Clave;
            FechaDeIngresoDateTimePicker.Value = usuario.FechaDeIngreso;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo \"Nombre\" no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (ApellidoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ApellidoTextBox, "El campo \"Apellido\" no puede estar vacio");
                ApellidoTextBox.Focus();
                paso = false;
            }

            if (AdministradorRadioButton.Checked == false && SupervisorRadioButton.Checked == false && SoporteRadioButton.Checked == false && UsuarioRadioButton.Checked == false)
            {
                MyErrorProvider.SetError(NivelDeUsuarioGroupBox, "Debe elegir un tipo de usuario");
                NivelDeUsuarioGroupBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo \"Usuario\" no puede estar vacio y/o tener espacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                MyErrorProvider.SetError(ClaveTextBox, "El campo \"Clave\" no puede estar vacio y/o tener espacio");
                ClaveTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuariosBLL.Buscar((int)IdUsuarioNumericUpDown.Value);
            return (usuario != null);
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(IdUsuarioNumericUpDown.Text, out id);

            Limpiar();
            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Usuario encontrado");
                LlenaCampos(usuario);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            NombreTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenaClase();
            Limpiar();

            if (IdUsuarioNumericUpDown.Value == 0)
                paso = UsuariosBLL.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuario);
            }

            if (paso)
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdUsuarioNumericUpDown.Text, out id);

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IdUsuarioNumericUpDown, "No se puede eliminar un usuario que no existe");
        }

    }
}

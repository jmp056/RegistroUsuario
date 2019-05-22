namespace ProyectoFinal.UI.Registros
{
    partial class RegistroUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.IdUsuarioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.FechaDeIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NivelDeUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.AdministradorRadioButton = new System.Windows.Forms.RadioButton();
            this.SupervisorRadioButton = new System.Windows.Forms.RadioButton();
            this.SoporteRadioButton = new System.Windows.Forms.RadioButton();
            this.UsuarioRadioButton = new System.Windows.Forms.RadioButton();
            this.Apellido = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IdUsuarioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.NivelDeUsuarioGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(334, 21);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(71, 61);
            this.BuscarButton.TabIndex = 0;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(28, 20);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(90, 30);
            this.NuevoButton.TabIndex = 1;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(28, 75);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(90, 30);
            this.GuardarButton.TabIndex = 2;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(28, 130);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(90, 30);
            this.EliminarButton.TabIndex = 3;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(12, 55);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(62, 15);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre:";
            // 
            // IdUsuarioNumericUpDown
            // 
            this.IdUsuarioNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuarioNumericUpDown.Location = new System.Drawing.Point(109, 21);
            this.IdUsuarioNumericUpDown.Name = "IdUsuarioNumericUpDown";
            this.IdUsuarioNumericUpDown.Size = new System.Drawing.Size(117, 21);
            this.IdUsuarioNumericUpDown.TabIndex = 5;
            this.IdUsuarioNumericUpDown.ValueChanged += new System.EventHandler(this.IdUsuarioNumericUpDown_ValueChanged);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(109, 54);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.NombreTextBox.TabIndex = 9;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoTextBox.Location = new System.Drawing.Point(109, 87);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(200, 21);
            this.ApellidoTextBox.TabIndex = 11;
            this.ApellidoTextBox.TextChanged += new System.EventHandler(this.ApellidoTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 122);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(296, 21);
            this.EmailTextBox.TabIndex = 13;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(109, 247);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(117, 21);
            this.UsuarioTextBox.TabIndex = 15;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveTextBox.Location = new System.Drawing.Point(109, 282);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(117, 21);
            this.ClaveTextBox.TabIndex = 17;
            // 
            // FechaDeIngresoDateTimePicker
            // 
            this.FechaDeIngresoDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDeIngresoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeIngresoDateTimePicker.Location = new System.Drawing.Point(146, 315);
            this.FechaDeIngresoDateTimePicker.Name = "FechaDeIngresoDateTimePicker";
            this.FechaDeIngresoDateTimePicker.Size = new System.Drawing.Size(80, 21);
            this.FechaDeIngresoDateTimePicker.TabIndex = 18;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // NivelDeUsuarioGroupBox
            // 
            this.NivelDeUsuarioGroupBox.Controls.Add(this.UsuarioRadioButton);
            this.NivelDeUsuarioGroupBox.Controls.Add(this.SoporteRadioButton);
            this.NivelDeUsuarioGroupBox.Controls.Add(this.SupervisorRadioButton);
            this.NivelDeUsuarioGroupBox.Controls.Add(this.AdministradorRadioButton);
            this.NivelDeUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NivelDeUsuarioGroupBox.Location = new System.Drawing.Point(15, 160);
            this.NivelDeUsuarioGroupBox.Name = "NivelDeUsuarioGroupBox";
            this.NivelDeUsuarioGroupBox.Size = new System.Drawing.Size(211, 73);
            this.NivelDeUsuarioGroupBox.TabIndex = 24;
            this.NivelDeUsuarioGroupBox.TabStop = false;
            this.NivelDeUsuarioGroupBox.Text = "Nivel de usuario";
            // 
            // AdministradorRadioButton
            // 
            this.AdministradorRadioButton.AutoSize = true;
            this.AdministradorRadioButton.Location = new System.Drawing.Point(6, 20);
            this.AdministradorRadioButton.Name = "AdministradorRadioButton";
            this.AdministradorRadioButton.Size = new System.Drawing.Size(114, 19);
            this.AdministradorRadioButton.TabIndex = 24;
            this.AdministradorRadioButton.TabStop = true;
            this.AdministradorRadioButton.Text = "Administrador";
            this.AdministradorRadioButton.UseVisualStyleBackColor = true;
            // 
            // SupervisorRadioButton
            // 
            this.SupervisorRadioButton.AutoSize = true;
            this.SupervisorRadioButton.Location = new System.Drawing.Point(6, 45);
            this.SupervisorRadioButton.Name = "SupervisorRadioButton";
            this.SupervisorRadioButton.Size = new System.Drawing.Size(93, 19);
            this.SupervisorRadioButton.TabIndex = 25;
            this.SupervisorRadioButton.TabStop = true;
            this.SupervisorRadioButton.Text = "Supervisor";
            this.SupervisorRadioButton.UseVisualStyleBackColor = true;
            this.SupervisorRadioButton.CheckedChanged += new System.EventHandler(this.SupervisorRadioButton_CheckedChanged);
            // 
            // SoporteRadioButton
            // 
            this.SoporteRadioButton.AutoSize = true;
            this.SoporteRadioButton.Location = new System.Drawing.Point(126, 20);
            this.SoporteRadioButton.Name = "SoporteRadioButton";
            this.SoporteRadioButton.Size = new System.Drawing.Size(75, 19);
            this.SoporteRadioButton.TabIndex = 26;
            this.SoporteRadioButton.TabStop = true;
            this.SoporteRadioButton.Text = "Soporte";
            this.SoporteRadioButton.UseVisualStyleBackColor = true;
            // 
            // UsuarioRadioButton
            // 
            this.UsuarioRadioButton.AutoSize = true;
            this.UsuarioRadioButton.Location = new System.Drawing.Point(126, 45);
            this.UsuarioRadioButton.Name = "UsuarioRadioButton";
            this.UsuarioRadioButton.Size = new System.Drawing.Size(75, 19);
            this.UsuarioRadioButton.TabIndex = 27;
            this.UsuarioRadioButton.TabStop = true;
            this.UsuarioRadioButton.Text = "Usuario";
            this.UsuarioRadioButton.UseVisualStyleBackColor = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(12, 90);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(63, 15);
            this.Apellido.TabIndex = 25;
            this.Apellido.Text = "Apellido:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(12, 20);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 15);
            this.ID.TabIndex = 26;
            this.ID.Text = "ID:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(12, 125);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 15);
            this.Email.TabIndex = 27;
            this.Email.Text = "Email:";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(18, 250);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(61, 15);
            this.Usuario.TabIndex = 28;
            this.Usuario.Text = "Usuario:";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(18, 285);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(46, 15);
            this.Clave.TabIndex = 29;
            this.Clave.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha de ingreso:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NuevoButton);
            this.panel1.Controls.Add(this.GuardarButton);
            this.panel1.Controls.Add(this.EliminarButton);
            this.panel1.Location = new System.Drawing.Point(260, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 180);
            this.panel1.TabIndex = 31;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.NivelDeUsuarioGroupBox);
            this.Controls.Add(this.FechaDeIngresoDateTimePicker);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdUsuarioNumericUpDown);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.BuscarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroUsuarios";
            this.Text = "Registro de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.IdUsuarioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.NivelDeUsuarioGroupBox.ResumeLayout(false);
            this.NivelDeUsuarioGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.NumericUpDown IdUsuarioNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.DateTimePicker FechaDeIngresoDateTimePicker;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox NivelDeUsuarioGroupBox;
        private System.Windows.Forms.RadioButton UsuarioRadioButton;
        private System.Windows.Forms.RadioButton SoporteRadioButton;
        private System.Windows.Forms.RadioButton SupervisorRadioButton;
        private System.Windows.Forms.RadioButton AdministradorRadioButton;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
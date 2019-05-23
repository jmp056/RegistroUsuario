namespace ProyectoFinal.UI.Registros
{
    partial class RCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCargos));
            this.DescripcionCargoTextBox = new System.Windows.Forms.TextBox();
            this.IdCargoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdCargoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionCargoTextBox
            // 
            this.DescripcionCargoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionCargoTextBox.Location = new System.Drawing.Point(173, 59);
            this.DescripcionCargoTextBox.Name = "DescripcionCargoTextBox";
            this.DescripcionCargoTextBox.Size = new System.Drawing.Size(204, 21);
            this.DescripcionCargoTextBox.TabIndex = 4;
            // 
            // IdCargoNumericUpDown
            // 
            this.IdCargoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCargoNumericUpDown.Location = new System.Drawing.Point(173, 21);
            this.IdCargoNumericUpDown.Name = "IdCargoNumericUpDown";
            this.IdCargoNumericUpDown.Size = new System.Drawing.Size(100, 21);
            this.IdCargoNumericUpDown.TabIndex = 5;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID del cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion del cargo:";
            // 
            // EditarButton
            // 
            this.EditarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarButton.Image = global::ProyectoFinal.Properties.Resources.portafolios_con_lapiz_opt__1_;
            this.EditarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditarButton.Location = new System.Drawing.Point(158, 106);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(77, 35);
            this.EditarButton.TabIndex = 3;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ProyectoFinal.Properties.Resources.eliminar_foto_opt;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(287, 106);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(90, 35);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(298, 14);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(79, 33);
            this.BuscarButton.TabIndex = 1;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ProyectoFinal.Properties.Resources.guardar_opt_opt__1_;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(25, 106);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 35);
            this.GuardarButton.TabIndex = 0;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // RCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdCargoNumericUpDown);
            this.Controls.Add(this.DescripcionCargoTextBox);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RCargos";
            this.Text = "Registro de Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.IdCargoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.TextBox DescripcionCargoTextBox;
        private System.Windows.Forms.NumericUpDown IdCargoNumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
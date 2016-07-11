namespace Parcial2_Cesar
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.CelularTextBox = new System.Windows.Forms.TextBox();
            this.CedulaTextBox = new System.Windows.Forms.TextBox();
            this.SueldoTextBox = new System.Windows.Forms.TextBox();
            this.IncentivoTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ActivoTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EmpleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.Label();
            this.CargoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdEmpleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cedula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sueldo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Incentivo";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(100, 57);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 11;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(100, 122);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 13;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(100, 91);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.FechaDateTimePicker.TabIndex = 14;
            this.FechaDateTimePicker.Value = new System.DateTime(2016, 7, 11, 19, 44, 48, 0);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(100, 162);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DireccionTextBox.TabIndex = 15;
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(100, 196);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonoTextBox.TabIndex = 16;
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.Location = new System.Drawing.Point(300, 56);
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(100, 20);
            this.CelularTextBox.TabIndex = 17;
            // 
            // CedulaTextBox
            // 
            this.CedulaTextBox.Location = new System.Drawing.Point(300, 90);
            this.CedulaTextBox.Name = "CedulaTextBox";
            this.CedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.CedulaTextBox.TabIndex = 18;
            // 
            // SueldoTextBox
            // 
            this.SueldoTextBox.Location = new System.Drawing.Point(300, 150);
            this.SueldoTextBox.Name = "SueldoTextBox";
            this.SueldoTextBox.Size = new System.Drawing.Size(100, 20);
            this.SueldoTextBox.TabIndex = 19;
            // 
            // IncentivoTextBox
            // 
            this.IncentivoTextBox.Location = new System.Drawing.Point(300, 183);
            this.IncentivoTextBox.Name = "IncentivoTextBox";
            this.IncentivoTextBox.Size = new System.Drawing.Size(100, 20);
            this.IncentivoTextBox.TabIndex = 20;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(19, 255);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Activo";
            // 
            // ActivoTextBox
            // 
            this.ActivoTextBox.Location = new System.Drawing.Point(300, 213);
            this.ActivoTextBox.Name = "ActivoTextBox";
            this.ActivoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ActivoTextBox.TabIndex = 21;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(138, 255);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(258, 255);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 24;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(380, 255);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 25;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // EmpleadoDataGridView
            // 
            this.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Nombre,
            this.Direccion});
            this.EmpleadoDataGridView.Location = new System.Drawing.Point(19, 296);
            this.EmpleadoDataGridView.Name = "EmpleadoDataGridView";
            this.EmpleadoDataGridView.Size = new System.Drawing.Size(462, 168);
            this.EmpleadoDataGridView.TabIndex = 26;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Location = new System.Drawing.Point(234, 130);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(35, 13);
            this.Cargo.TabIndex = 27;
            this.Cargo.Text = "Cargo";
            // 
            // CargoTextBox
            // 
            this.CargoTextBox.Location = new System.Drawing.Point(300, 121);
            this.CargoTextBox.Name = "CargoTextBox";
            this.CargoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CargoTextBox.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 509);
            this.Controls.Add(this.CargoTextBox);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.EmpleadoDataGridView);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ActivoTextBox);
            this.Controls.Add(this.IncentivoTextBox);
            this.Controls.Add(this.SueldoTextBox);
            this.Controls.Add(this.CedulaTextBox);
            this.Controls.Add(this.CelularTextBox);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.TextBox CelularTextBox;
        private System.Windows.Forms.TextBox CedulaTextBox;
        private System.Windows.Forms.TextBox SueldoTextBox;
        private System.Windows.Forms.TextBox IncentivoTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ActivoTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.DataGridView EmpleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.TextBox CargoTextBox;
    }
}


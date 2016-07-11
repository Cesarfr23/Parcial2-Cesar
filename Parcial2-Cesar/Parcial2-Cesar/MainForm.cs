using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Cesar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdEmpleado = Convert.ToInt32(IdTextBox.Text);
            string Fecha = Convert.ToString(FechaDateTimePicker.Text);
            string Nombre = Convert.ToString(NombreTextBox.Text);
            string Direccion = Convert.ToString(DireccionTextBox.Text);
            string Telefono = Convert.ToString(TelefonoTextBox.Text);
            string Celular = Convert.ToString(CelularTextBox.Text);
            string DCedula = Convert.ToString(CedulaTextBox.Text);
            string Cargo = Convert.ToString(CargoTextBox.Text);
            float Sueldo = Convert.ToSingle(SueldoTextBox.Text);
            float Incentivo = Convert.ToSingle(IncentivoTextBox.Text);

            EmpleadoDataGridView.Rows.Add(IdTextBox.Text, FechaDateTimePicker.Text, NombreTextBox.Text, DireccionTextBox.Text);
        }
    }
}

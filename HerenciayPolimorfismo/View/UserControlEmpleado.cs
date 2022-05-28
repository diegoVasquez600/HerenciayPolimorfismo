using HerenciayPolimorfismo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciayPolimorfismo.View
{
    public partial class UserControlEmpleado : UserControl
    {
        private readonly Empleado empleado;
        public UserControlEmpleado()
        {
            InitializeComponent();
            empleado = new("Diego", "Rios", "1000444958", "Soltero", "2021", "Desarrollador");
        }


        private void CargarLabel()
        {
            labelEmpleado.Text = $"{empleado.Nombre} {empleado.Apellidos}\nEstado Civil: {empleado.EstadoCivil}\nAño Incorporacion: {empleado.AnioIncorporacion}\nLabor: {empleado.Labor}";
        }

        private void ButtonLabor_Click(object sender, EventArgs e)
        {
            if (textBoxLabor.Text == string.Empty)
                MessageBox.Show("Debes Ingresar una nueva Labor");
            else
            {
                empleado.ModificaLabor(textBoxLabor.Text);
                CargarLabel();
                textBoxLabor.Text = string.Empty;
            }
        }

        private void UserControlEmpleado_Load(object sender, EventArgs e)
        {
            CargarLabel();
        }

        private void ButtonEstadoCivil_Click(object sender, EventArgs e)
        {
            empleado.CambioEstadoCivil();
            CargarLabel();
        }

        private void ButtonEstadoCivil_Click_1(object sender, EventArgs e)
        {
            CambiarEstadoCivil();
        }

        private void CambiarEstadoCivil()
        {
            empleado.CambioEstadoCivil();
            CargarLabel();
        }
    }
}

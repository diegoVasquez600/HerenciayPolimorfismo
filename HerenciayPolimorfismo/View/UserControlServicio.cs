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
    public partial class UserControlServicio : UserControl
    {
        private readonly Servicio servicio;
        public UserControlServicio()
        {
            InitializeComponent();
            servicio = new("Diego", "Rios", "1000444958", "Soltero", "Limpieza");
            CargarLabel();
        }

        private void ButtonLabor_Click(object sender, EventArgs e)
        {
            CambiarLabor();
        }

        private void CambiarLabor()
        {
            if (textBoxLabor.Text == string.Empty)
                MessageBox.Show("Debes Ingresar una nueva Labor");
            else
            {
                servicio.ModificarLabor(textBoxLabor.Text);
                CargarLabel();
                textBoxLabor.Text = string.Empty;
            }
        }

        private void ButtonEstadoCivil_Click(object sender, EventArgs e)
        {
            CambiarEstadoCivil();
        }

        private void CargarLabel()
        {
            labelEmpleado.Text = $"{servicio.Nombre} {servicio.Apellidos}\nEstado Civil: {servicio.EstadoCivil}\nLabor: {servicio.Labor}";
        }

        private void CambiarEstadoCivil()
        {
            servicio.CambioEstadoCivil();
            CargarLabel();
        }
    }
}

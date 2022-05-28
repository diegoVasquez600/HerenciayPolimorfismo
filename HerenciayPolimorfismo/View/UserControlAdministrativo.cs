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
    public partial class UserControlAdministrativo : UserControl
    {
        private readonly Administrativo administrativo;
        public UserControlAdministrativo()
        {
            InitializeComponent();
            administrativo = new("Diego", "Rios", "1000444958", "Soltero", "Contabilidad");
        }

        private void UserControlAdministrativo_Load(object sender, EventArgs e)
        {
            CargarLabel();
        }

        private void ButtonEstadoCivil_Click(object sender, EventArgs e)
        {
            CambiarEstadoCivil();
        }

        private void CambiarEstadoCivil()
        {
            administrativo.CambioEstadoCivil();
            CargarLabel();
        }

        private void CambiarDependencia()
        {
            if (textBoxDependencia.Text == string.Empty)
                MessageBox.Show("Debes Ingresar una nueva Dependencia");
            else
            {
                administrativo.ModificarDependencia(textBoxDependencia.Text);
                CargarLabel();
                textBoxDependencia.Text = string.Empty;
            }
        }

        private void CargarLabel()
        {
            labelAdministrativo.Text = $"{administrativo.Nombre} {administrativo.Apellidos}\nDependencia: {administrativo.Dependencia}\nIdentficacion: {administrativo.Identificacion}\nEstado Civil: {administrativo.EstadoCivil}";
        }

        private void ButtonDependencia_Click(object sender, EventArgs e)
        {
            CambiarDependencia();
        }
    }
}

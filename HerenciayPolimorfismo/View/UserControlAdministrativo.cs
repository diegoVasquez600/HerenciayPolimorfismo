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
        readonly Administrativo administrativo;
        public UserControlAdministrativo()
        {
            InitializeComponent();
            administrativo = new("Diego", "Rios", "1000444958", "Soltero", "Contabilidad");
        }

        private void UserControlAdministrativo_Load(object sender, EventArgs e)
        {
            CargarLabel();
        }

        private void buttonEstadoCivil_Click(object sender, EventArgs e)
        {
            CambiarEstadoCivil();
        }

        private void CambiarEstadoCivil()
        {
            administrativo.EstadoCivil = "Casado";
            administrativo.CambioEstadoCivil();
            CargarLabel();
        }

        private void CargarLabel()
        {
            labelAdministrativo.Text = $"{administrativo.Nombre} {administrativo.Apellidos}\nIdentficacion: {administrativo.Identificacion}\nEstado Civil: {administrativo.EstadoCivil}";
        }
    }
}

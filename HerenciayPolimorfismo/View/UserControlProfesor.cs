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
    public partial class UserControlProfesor : UserControl
    {
        private readonly Profesor profesor;
        public UserControlProfesor()
        {
            InitializeComponent();
            profesor = new("Diego", "Rios", "1000444958", "Soltero", "Electronica");
        }

        private void ButtonFacultad_Click(object sender, EventArgs e)
        {
            CambiarFacultad();
        }

        private void CambiarFacultad()
        {
            if (textBoxFacultad.Text == string.Empty)
                MessageBox.Show("Debes Ingresar una nueva Facultad");
            else
            {
                profesor.CambioFacultad(textBoxFacultad.Text);
                CargarLabel();
                textBoxFacultad.Text = string.Empty;
            }

        }

        private void CargarLabel()
        {
            labelProfesor.Text = $"{profesor.Nombre} {profesor.Apellidos}\nFacultad: {profesor.Facultad}\nIdentficacion: {profesor.Identificacion}\nEstado Civil: {profesor.EstadoCivil}";
        }

        private void UserControlProfesor_Load(object sender, EventArgs e)
        {
            CargarLabel();
        }

        private void ButtonEstadoCivil_Click(object sender, EventArgs e)
        {
            CambioEstadoCivil();
        }

        private void CambioEstadoCivil()
        {
            profesor.CambioEstadoCivil();
            CargarLabel();
        }
    }
}

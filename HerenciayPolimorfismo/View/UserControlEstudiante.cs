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
    public partial class UserControlEstudiante : UserControl
    {
        private readonly Estudiante estudiante;
        public UserControlEstudiante()
        {
            InitializeComponent();
            estudiante = new("Diego", "Rios", "1000444958", "Soltero", "No Matriculado");
            CargarLabel();
        }

        private void ButtonEstadoCivil_Click(object sender, EventArgs e)
        {
            CambiarEstadoCivil();
        }

        private void CambiarEstadoCivil()
        {
            estudiante.CambioEstadoCivil();
            CargarLabel();
        }

        private void CargarLabel()
        {
            labelEstudiante.Text = $"{estudiante.Nombre} {estudiante.Apellidos}\nCurso: {estudiante.Curso}\nIdentficacion: {estudiante.Identificacion}\nEstado Civil: {estudiante.EstadoCivil}";
        }

        private void ButtonCurso_Click(object sender, EventArgs e)
        {
            MatricularCurso();
        }

        private void MatricularCurso()
        {
            if (textBoxCurso.Text == string.Empty)
                MessageBox.Show("Debes Ingresar un Curso para Matricular");
            else
            {
                estudiante.MatricularEstudiante(textBoxCurso.Text);
                CargarLabel();
                textBoxCurso.Text = string.Empty;
            }
        }
    }
}

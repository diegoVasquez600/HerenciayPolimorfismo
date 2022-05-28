using HerenciayPolimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimorfismo.Classes
{
    public class Estudiante : Persona
    {
        public string Curso { get; set; }
        public Estudiante(string Nombre, string Apellidos, string Identificacion, string EstadoCivil, string curso) : base(Nombre, Apellidos, Identificacion, EstadoCivil)
        {
            Curso = curso;
        }

        public void MatricularEstudiante(string curso)
        {
            Curso = curso;
            MessageBox.Show($"El estudiante {Nombre} se matriculo a {Curso}");
        }

        public override void CambioEstadoCivil()
        {
            base.CambioEstadoCivil();
            EstadoCivil = "Casado";
            MessageBox.Show($"El estado Civil de {Nombre} cambio por {EstadoCivil}");
        }

    }
}

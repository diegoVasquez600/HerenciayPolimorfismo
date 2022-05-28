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
        private string Curso { get; set; }
        public Estudiante(string Nombre, string Apellidos, string Identificacion, string EstadoCivil, string curso) : base(Nombre, Apellidos, Identificacion, EstadoCivil)
        {
            Curso = curso;
        }

        public void MatricularEstudiante()
        {

        }

    }
}

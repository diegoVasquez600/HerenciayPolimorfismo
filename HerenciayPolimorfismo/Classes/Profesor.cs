using HerenciayPolimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimorfismo.Classes
{
    public class Profesor : Persona
    {
        public string Facultad { get; set; }

        public Profesor(string Nombre, string Apellidos, string Identificacion, string EstadoCivil, string Facultad) : base(Nombre, Apellidos, Identificacion, EstadoCivil)
        {
            this.Facultad = Facultad;
        }

        public void CambioFacultad(string facultad)
        {
            Facultad = facultad;
            MessageBox.Show($"La facultad del profesor {Nombre} cambió por {Facultad}");
        }

        public override void CambioEstadoCivil()
        {
            base.CambioEstadoCivil();
            EstadoCivil = "Casado";
            MessageBox.Show($"El estado Civil de {Nombre} cambio por {EstadoCivil}");
        }

    }
}

using HerenciayPolimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimorfismo.Classes
{
    public class Empleado: Persona
    {
        public string AnioIncorporacion { get; set; } = null!;
        public string Labor { get; set; }

        public Empleado(string Nombre, string Apellidos, string Identificacion, string EstadoCivil, string AnioIncorporacion, string labor) : base(Nombre, Apellidos, Identificacion, EstadoCivil)
        {
            this.AnioIncorporacion = AnioIncorporacion;
            Labor = labor;
        }

        public void ModificaLabor(string labor) 
        {
            Labor = labor;
            MessageBox.Show($"La labor de {Nombre} cambió por {Labor}");
        }
        public override void CambioEstadoCivil()
        {
            base.CambioEstadoCivil();
            EstadoCivil = "Casado";
            MessageBox.Show($"El estado Civil de {Nombre} cambio por {EstadoCivil}");
        }

    }
}

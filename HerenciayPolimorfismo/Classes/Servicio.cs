using HerenciayPolimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimorfismo.Classes
{
    public class Servicio : Persona
    {
        public string Labor { get; set; }
        public Servicio(string Nombre, string Apellidos, string Identificacion, string EstadoCivil, string labor) : base(Nombre, Apellidos, Identificacion, EstadoCivil)
        {
            Labor = labor;
        }

        public void ModificarLabor(string labor)
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

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
        private string AnioIncorporacion { get; set; } = null!;

        public Empleado(string Nombre, string Apellidos, string Identificacion, string EstadoCivil, string AnioIncorporacion) : base(Nombre, Apellidos, Identificacion, EstadoCivil)
        {
            this.AnioIncorporacion = AnioIncorporacion;
        }

        public void ModificaLabor() 
        { 
        
        }


    }
}

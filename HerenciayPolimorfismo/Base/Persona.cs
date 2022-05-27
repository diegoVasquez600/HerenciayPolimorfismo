using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimorfismo.Base
{
    public abstract class Persona
    {
        protected string Nombre { get; set; } = null!;
        protected string Apellidos { get; set; } = null!;
        protected string Identificacion { get; set; } = null!;
        protected string EstadoCivil { get; set; } = null!;

        public Persona(string Nombre, string Apellidos, string Identificacion, string EstadoCivil)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Identificacion = Identificacion;
            this.EstadoCivil = EstadoCivil;
        }

        public void CambioEstadoCivil() 
        {
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimorfismo.Base
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; } 
        public string Identificacion { get; set; }
        public string EstadoCivil { get; set; }

        public Persona(string Nombre, string Apellidos, string Identificacion, string EstadoCivil)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Identificacion = Identificacion;
            this.EstadoCivil = EstadoCivil;
        }

        public virtual void CambioEstadoCivil() 
        {
            MessageBox.Show($"Es estado Civil Actual es {EstadoCivil}, ¿Deseas Cambiarlo?");
        }

    }
}

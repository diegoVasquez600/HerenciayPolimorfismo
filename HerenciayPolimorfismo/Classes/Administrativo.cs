﻿using HerenciayPolimorfismo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayPolimorfismo.Classes
{
    public class Administrativo: Persona
    {
        public string Dependencia { get; set; } = null!;

        public Administrativo(string Nombre, string Apellidos, string Identificacion, string EstadoCivil, string Dependencia) : base(Nombre, Apellidos, Identificacion, EstadoCivil)
        {
            this.Dependencia = Dependencia;
            this.Nombre = Nombre;
        }

        public void ModificarDependencia(string dependencia)
        {
            Dependencia = dependencia;
            MessageBox.Show($"La dependencia de {Nombre} cambió por {Dependencia}");
        }

        public override void CambioEstadoCivil()
        {
            base.CambioEstadoCivil();
            EstadoCivil = "Casado";
            MessageBox.Show($"El estado Civil de {Nombre} cambio por {EstadoCivil}");
        }


    }
}

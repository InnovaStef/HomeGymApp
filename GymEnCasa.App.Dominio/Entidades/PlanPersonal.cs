using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace GymEnCasa.App.Dominio
{
    public class PlanPersonal
    {
        public int Id {get; set;}

        public Persona Persona {get; set;}

        public float Peso {get; set;}

        public PlanDeNutricion PlanDeNutricion {get; set;}

        public DateTime Fecha {get; set;}

        public Rutina Rutina {get; set;}

        public EstadoPlan EstadoPlan {get; set;}
         // Por ahora no es obligatorio el IMC
         public float IMC {get; set;}
    }
}

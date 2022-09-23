using System;
using System.Collections.Generic;

namespace GymEnCasa.App.Dominio
{
    public class PlanDeNutricion
    {
        public int Id {get;set;}
        
        public Nivel Nivel {get;set;}

        public string Descripcion {get;set;}

        public Dieta Dieta {get;set;}

        public string Image {get;set;}
    }
}
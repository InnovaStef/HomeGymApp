using GymEnCasa.App.Dominio;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public interface IRepositorioPlanDeNutricion
    {
        PlanDeNutricion CrearPlanDeNutricion (PlanDeNutricion PlanDeNutricion);
        PlanDeNutricion ConsultarPlanDeNutricion (int  idPlanDeNutricion);
        IEnumerable <PlanDeNutricion> ConsultarPlanDeNutricion();
        PlanDeNutricion ActualizarPlanDeNutricion (PlanDeNutricion PlanDeNutricion);
        void EliminarPlanDeNutricion (int  idPlanDeNutricion);

    }

}
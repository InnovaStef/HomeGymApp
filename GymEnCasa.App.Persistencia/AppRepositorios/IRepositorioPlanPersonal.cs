using GymEnCasa.App.Dominio;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public interface IRepositorioPlanPersonal
    {
        PlanPersonal CrearPlanPersonal (PlanPersonal PlanPersonal);
        PlanPersonal ConsultarPlanPersonal (int  idPlanPersonal);
        IEnumerable <PlanPersonal> ConsultarPlanPersonal();
        PlanPersonal ActualizarPlanPersonal (PlanPersonal PlanPersonal);
        void EliminarPlanPersonal (int  idPlanPersonal);

    }

}    

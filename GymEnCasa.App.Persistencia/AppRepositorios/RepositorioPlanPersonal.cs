using GymEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public class RepositorioPlanPersonal : IRepositorioPlanPersonal
    {
        
        /*Se modifica porque se hace desde la Web*/
        private readonly AppContext _appContext;
        
        public  RepositorioPlanPersonal (AppContext appContext)
        {
            this._appContext=appContext;
        }

        //Crea o adiciona PlanPersonal en la base de datos
        public PlanPersonal CrearPlanPersonal (PlanPersonal PlanPersonal)
        {
            var PlanPersonalAdicionado = _appContext.PlanPersonal.Add(PlanPersonal);
            _appContext.SaveChanges();
            return PlanPersonalAdicionado.Entity;
        }
        
        //Consulta PlanPersonal en la base de datos
        public PlanPersonal ConsultarPlanPersonal(int idPlanPersonal)
        {
            return _appContext.PlanPersonal.FirstOrDefault(pp=>pp.Id==idPlanPersonal); // pp de PlanPersonal
        
        }
        
        //Consulta todos los PlanPersonal en la base de datos
        public IEnumerable<PlanPersonal> ConsultarPlanPersonal()
        {
            return _appContext.PlanPersonal;

        }
        
         //Actualiza un PlanPersonal en la base de datos
        public PlanPersonal ActualizarPlanPersonal(PlanPersonal  PlanPersonal)
         {
            var PlanPersonalEncontrado = _appContext.PlanPersonal.FirstOrDefault(pp=>pp.Id == PlanPersonal.Id);
             if  (PlanPersonalEncontrado!=null)
             {
             PlanPersonalEncontrado.Id = PlanPersonal.Id;  
             PlanPersonalEncontrado.Persona = PlanPersonal.Persona;
             PlanPersonalEncontrado.Peso = PlanPersonal.Peso;
             PlanPersonalEncontrado.PlanDeNutricion = PlanPersonal.PlanDeNutricion;
             PlanPersonalEncontrado.Fecha = PlanPersonal.Fecha;
             PlanPersonalEncontrado.Rutina = PlanPersonal.Rutina;
             PlanPersonalEncontrado.EstadoPlan = PlanPersonal.EstadoPlan;
             PlanPersonalEncontrado.IMC = PlanPersonal.IMC;



                _appContext.SaveChanges();
             }
             return PlanPersonalEncontrado;
         }
        
         //Elimina un PlanPersonal en la base de datos
            public void EliminarPlanPersonal (int idPlanPersonal)
            {
            var PlanPersonalEncontrado = _appContext.PlanPersonal.FirstOrDefault(pp=>pp.Id == idPlanPersonal);
             if  (PlanPersonalEncontrado==null)
                return;
            _appContext.PlanPersonal.Remove(PlanPersonalEncontrado);
            _appContext.SaveChanges();
            }

    }

}
using GymEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public class RepositorioPlanDeNutricion : IRepositorioPlanDeNutricion
    {
        
        /*Se modifica porque se hace desde la Web*/
        private readonly AppContext _appContext;
        
        public  RepositorioPlanDeNutricion (AppContext appContext)
        {
            this._appContext=appContext;
        }

        //Crea o adiciona PlanDeNutricion en la base de datos
        public PlanDeNutricion CrearPlanDeNutricion (PlanDeNutricion PlanDeNutricion)
        {
            var PlanDeNutricionAdicionado = _appContext.PlanDeNutricion.Add(PlanDeNutricion);
            _appContext.SaveChanges();
            return PlanDeNutricionAdicionado.Entity;
        }
        
        //Consulta PlanDeNutricion en la base de datos
        public PlanDeNutricion ConsultarPlanDeNutricion(int idPlanDeNutricion)
        {
            return _appContext.PlanDeNutricion.FirstOrDefault(pn=>pn.Id==idPlanDeNutricion); // pn de PlanDeNutricion
        
        }
        
        //Consulta todos los PlanDeNutricion en la base de datos
        public IEnumerable<PlanDeNutricion> ConsultarPlanDeNutricion()
        {
            return _appContext.PlanDeNutricion;

        }
        
         //Actualiza un PlanDeNutricion en la base de datos
        public PlanDeNutricion ActualizarPlanDeNutricion(PlanDeNutricion  PlanDeNutricion)
         {
            var PlanDeNutricionEncontrado = _appContext.PlanDeNutricion.FirstOrDefault(pn=>pn.Id == PlanDeNutricion.Id);
             if  (PlanDeNutricionEncontrado!=null)
             {
             PlanDeNutricionEncontrado.Nivel = PlanDeNutricion.Nivel;
             PlanDeNutricionEncontrado.Descripcion = PlanDeNutricion.Descripcion;
             PlanDeNutricionEncontrado.Image = PlanDeNutricion.Image;

                _appContext.SaveChanges();
             }
             return PlanDeNutricionEncontrado;
         }
        
         //Elimina un PlanDeNutricion en la base de datos
            public void EliminarPlanDeNutricion (int idPlanDeNutricion)
            {
            var PlanDeNutricionEncontrado = _appContext.PlanDeNutricion.FirstOrDefault(pn=>pn.Id == idPlanDeNutricion);
             if  (PlanDeNutricionEncontrado==null)
                return;
            _appContext.PlanDeNutricion.Remove(PlanDeNutricionEncontrado);
            _appContext.SaveChanges();
            }

    }

}
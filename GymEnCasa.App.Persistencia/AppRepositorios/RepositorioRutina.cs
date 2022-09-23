using GymEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public class RepositorioRutina : IRepositorioRutina
    {
        
        /*Se modifica porque se hace desde la Web*/
        private readonly AppContext _appContext;
        
        public  RepositorioRutina (AppContext appContext)
        {
            this._appContext=appContext;
        }

        //Crea o adiciona Rutina en la base de datos
        public  Rutina CrearRutina (Rutina Rutina)
        {
            var RutinaAdicionado = _appContext.Rutinas.Add(Rutina);
            _appContext.SaveChanges();
            return RutinaAdicionado.Entity;
        }
        
        //Consulta Rutina en la base de datos
        public Rutina ConsultarRutina(int idRutina)
        {
            return _appContext.Rutinas.FirstOrDefault(r=>r.Id==idRutina); // r de Rutina
        
        }
        
        //Consulta todos los Rutinas en la base de datos
        public IEnumerable<Rutina> ConsultarRutinas()
        {
            return _appContext.Rutinas;

        }
        
         //Actualiza un Rutina en la base de datos
        public Rutina ActualizarRutina(Rutina  Rutina)
         {
            var RutinaEncontrado = _appContext.Rutinas.FirstOrDefault(r=>r.Id == Rutina.Id);
             if  (RutinaEncontrado!=null)
             {
             RutinaEncontrado.Nivel = Rutina.Nivel;
             RutinaEncontrado.Descripcion = Rutina.Descripcion;
             RutinaEncontrado.Image = Rutina.Image;

                _appContext.SaveChanges();
             }
             return RutinaEncontrado;
         }
        
         //Elimina un Rutina en la base de datos
            public void EliminarRutina (int idRutina)
            {
            var RutinaEncontrado = _appContext.Rutinas.FirstOrDefault(r=>r.Id == idRutina);
             if  (RutinaEncontrado==null)
                return;
            _appContext.Rutinas.Remove(RutinaEncontrado);
            _appContext.SaveChanges();
            }

    }

}
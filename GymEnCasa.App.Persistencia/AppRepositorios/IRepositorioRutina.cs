using GymEnCasa.App.Dominio;
using System.Collections.Generic;

namespace GymEnCasa.App.Persistencia
{
    public interface IRepositorioRutina
    {
        Rutina CrearRutina (Rutina Rutina);
        Rutina ConsultarRutina (int  idRutina);
        IEnumerable <Rutina> ConsultarRutinas();
        Rutina ActualizarRutina (Rutina Rutina);
        void EliminarRutina (int  idRutina);
    }
}

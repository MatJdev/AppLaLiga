using System;
using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Jugadores
    {
        private readonly CD_Jugadores objDatos = new CD_Jugadores();

        #region ConsultarJugadores
        public DataTable CargarJugadores(int equipoID)
        {
            return objDatos.CargarJugadores(equipoID);
        }
        #endregion
    }
}

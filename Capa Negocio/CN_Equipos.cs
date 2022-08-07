using System;
using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Equipos
    {
        private readonly CD_Equipos objDatos = new CD_Equipos();

        #region ConsultarClasi
        public DataTable CargarRankingEquipos()
        {
            return objDatos.CargarRankingEquipos();
        }
        #endregion

        #region ConsultarEquipo
        public CE_Equipos Consulta(int equipoID)
        {
            return objDatos.CD_Consulta(equipoID);
        }
        #endregion

        #region ActualizarDatos
        public void ActualizarDatos(CE_Equipos Equipos)
        {
            objDatos.CD_ActualizarDatos(Equipos);
        }
        #endregion
    }
}

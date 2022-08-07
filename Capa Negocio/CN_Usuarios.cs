using System;
using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios objDatos = new CD_Usuarios();

        #region Consultar
        public CE_Usuarios Consulta (string Nombre, string Pass)
        {
            return objDatos.CD_Consulta(Nombre, Pass);
        }
        #endregion

        #region CargarTodosUsuarios
        public DataTable CargarTodosUsuarios()
        {
            return objDatos.CargarTodosUsuarios();
        }
        #endregion

        #region Insertar
        public void Insertar(CE_Usuarios Usuarios)
        {
            objDatos.CD_Insertar(Usuarios);
        }
        #endregion

        #region InsertarAdmin
        public void InsertarAdmin(CE_Usuarios Usuarios)
        {
            objDatos.CD_InsertarAdmin(Usuarios);
        }
        #endregion

        #region ConsultarEmailRegistrado
        public CE_Usuarios ConsultaEmailRegistrado(string Nombre, string Email)
        {
            return objDatos.CD_ConsultaEmailRegistrado(Nombre, Email);
        }
        #endregion

        #region ConsultarLogin
        public CE_Usuarios ConsultaLogin(string Nombre, string Pass)
        {
            return objDatos.CD_ConsultaLogin(Nombre, Pass);
        }
        #endregion

        #region ActualizarDatos
        public void ActualizarDatos(CE_Usuarios Usuarios)
        {
            objDatos.CD_ActualizarDatos(Usuarios);
        }
        #endregion
    }
}

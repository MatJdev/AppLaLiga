using System;

namespace Capa_Entidad
{
    public class CE_Jugadores
    {
        private int nJugadorID;
        private string cNombre;
        private string cApellidos;
        private DateTime dNacimiento;
        private int nDorsal;
        private string cPosicion;
        private int nEquipoID;
        private string cPais;

        public int NJugadorID { get => nJugadorID; set => nJugadorID = value; }
        public string CNombre { get => cNombre; set => cNombre = value; }
        public string CApellidos { get => cApellidos; set => cApellidos = value; }
        public DateTime DNacimiento { get => dNacimiento; set => dNacimiento = value; }
        public int NDorsal { get => nDorsal; set => nDorsal = value; }
        public string CPosicion { get => cPosicion; set => cPosicion = value; }
        public int NEquipoID { get => nEquipoID; set => nEquipoID = value; }
        public string CPais { get => cPais; set => cPais = value; }
    }
}

namespace Capa_Entidad
{
    public class CE_Equipos
    {
        private int nEquipoID;
        private string cNombre;
        private int nAnyoFundacion;
        private string cEntrenador;
        private string cCiudad;
        private int nPuntos;
        private int nPJ;
        private int nPG;
        private int nPE;
        private int nPP;

        public int NEquipoID { get => nEquipoID; set => nEquipoID = value; }
        public string CNombre { get => cNombre; set => cNombre = value; }
        public int NAnyoFundacion { get => nAnyoFundacion; set => nAnyoFundacion = value; }
        public string CEntrenador { get => cEntrenador; set => cEntrenador = value; }
        public string CCiudad { get => cCiudad; set => cCiudad = value; }
        public int NPuntos { get => nPuntos; set => nPuntos = value; }
        public int NPJ { get => nPJ; set => nPJ = value; }
        public int NPG { get => nPG; set => nPG = value; }
        public int NPE { get => nPE; set => nPE = value; }
        public int NPP { get => nPP; set => nPP = value; }
    }
}

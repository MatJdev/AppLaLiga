namespace Capa_Entidad
{
    public class CE_Usuarios
    {
        private string cNIFID;
        private string cNombre;
        private string cPass;
        private int lAdmin;
        private int nAdmin;
        private string cEmail;

        public string CNIFID { get => cNIFID; set => cNIFID = value; }
        public string CNombre { get => cNombre; set => cNombre = value; }
        public string CPass { get => cPass; set => cPass = value; }
        public int LAdmin { get => lAdmin; set => lAdmin = value; }
        public int NAdmin { get => nAdmin; set => nAdmin = value; }
        public string CEmail { get => cEmail; set => cEmail = value; }
    }
}

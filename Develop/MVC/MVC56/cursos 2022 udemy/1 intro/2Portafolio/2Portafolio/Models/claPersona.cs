namespace _2Portafolio.Models
{
    public class claPersona
    {
        private string strNombre;
        public string Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }


        private int intEdad;
        public int Edad
        {
            get { return intEdad; }
            set { intEdad = value; }
        }


        public claPersona(string nom, int ed)
        {
            strNombre = nom;
            intEdad = ed;
        }

    }
}

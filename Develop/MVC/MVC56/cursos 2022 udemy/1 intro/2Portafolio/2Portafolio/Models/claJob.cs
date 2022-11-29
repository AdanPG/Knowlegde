namespace _2Portafolio.Models
{
    public class claJob
    {
        private string strTitulo;

        public string Titulo
        {
            get { return strTitulo; }
            set { strTitulo = value; }
        }

        private string strDescripcion;

        public string Descripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }

        private string strImagen;

        public string ImagenURL
        {
            get { return strImagen; }
            set { strImagen = value; }
        }

        private string strlink;

        public string Link
        {
            get { return strlink; }
            set { strlink = value; }
        }


        /*
         * esta clase representa la DATA, el TIPO
         */


        public claJob()
        {
            strTitulo = "Portal de FAM Potenciado";
            strDescripcion = "Portal que administra los trámites de pago de las estimaciones de  obra";
            strImagen = "";
            strlink = "https://www.inifech.gob";
        }



    }
}

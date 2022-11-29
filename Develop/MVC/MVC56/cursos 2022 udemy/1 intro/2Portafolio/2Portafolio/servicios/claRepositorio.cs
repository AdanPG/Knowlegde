using _2Portafolio.Models;

namespace _2Portafolio.servicios
{
    public class claRepositorio
    {
        public List<claJob> ObtenerJobs()
        {
            return new List<claJob>() { new claJob
            {
                Titulo="INIFECH, área de soporte técnico",
                Descripcion="Atender solicitudes de soporte técnico a las diferentes áreas del Instituto",
                ImagenURL="",
                Link="https://www.inifech.gob.mx"
            },
             new claJob
            {
                Titulo="INIFECH, Control de obra",
                Descripcion="Desarrollar una aplicacioón de seguimiento de solicirudes de pago de estimaciones de obra",
                ImagenURL="",
                Link="https://www.inifech.gob.mx"
            },
             new claJob
            {
                Titulo="Gobierno de Puebla",
                Descripcion="Proporcionar un sistema de información para control financiero de los contratos de obra del Ramo 33",
                ImagenURL="",
                Link="https://www.puebla.gob.mx"
            },
              new claJob
            {
                Titulo="Validata",
                Descripcion="Digitalización de bases de datos",
                ImagenURL="",
                Link="https://www.validata.com"
            }
            };

        }
    }
}

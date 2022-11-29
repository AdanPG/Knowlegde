using ManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta//:IValidatableObject
    {
        //debe heredar IValidatableObject para las validaciones por modelo

        /*OJO. si usas : get; private set, estaras utilizando campos en vez de propiedades, cuando intentes pasar los datos de las propiedades
         apareceran nulos*/


        public int id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        //[StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "la longitud del campo {0} es incorrecta")]
        //[Display(Name = "Nombre del tipo de la cuenta")]
        
        /*se llama al atributo personalizado de la carpeta validaciones. solo recordar que hay que quitar ALL en validation 
         summary de la vista, ya que se va a duplicar el mensaje. 
        este esquema pertenece a una tecnica por atributos, tambien existe POR MODELO.
         */
        
        //para implementar por modelo desactivamos lo siguiente
        //[MayusInicio]
        //validacion por controlador usando js.
        [Remote(action: "VerificarTCuenta", controller:"TiposCuentas" )]
        public string nombre { get; set; }
        public int usuarioid { get; set; }
        public int orden { get; set; }



        //se agrego esto al heredar, pero el modo a utilizar sera validacion por atributos
        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //   if (nombre!=null && nombre.Length>0)
        //    {
        //        var pl = nombre.ToString();
        //        if(pl!=pl.ToUpper())
        //        {
        //            yield return new ValidationResult("Mayus requerida", new[] { nameof(nombre)});
        //        }
        //    }
        //}






        /*Probando otro tipo de validaciones*/
        /*JQUERY es una libreria de js, en este caso la usamos para validacion rapida en el cliente*/

        /*
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [EmailAddress(ErrorMessage ="Proporcione un e mal válido")]
        public string Email { get; set; }

        [Range(minimum:18, maximum:100, ErrorMessage ="Proporcione una edad valida entree {1} y {2}")]
        public int Edad { get; set; }

        [Url(ErrorMessage ="Proporcione una URL válida")]
        public string URL { get; set; }

        [CreditCard(ErrorMessage ="Proporcione un numero de tarjeta válida")]
        public string TarjetaCredito { get; set; }
        */

    }
}

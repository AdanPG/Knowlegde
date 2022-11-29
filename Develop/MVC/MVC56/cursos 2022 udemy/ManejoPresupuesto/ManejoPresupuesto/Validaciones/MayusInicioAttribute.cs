using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Validaciones
{
    public class MayusInicioAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            //ignora si viene bulo o vacio, eso lo hace otra

            var pl = value.ToString()[0].ToString();
            //toma primera letra

            if(pl!=pl.ToUpper())
            {
                return new ValidationResult("mayus necesaria");
            }

            return ValidationResult.Success;
        }
        

    }
}

namespace Recetas.Models
{
    public class Receta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string Procedimiento { get; set; }


        public ICollection<Tipo> Tipos { get; set; }
        
    }
}

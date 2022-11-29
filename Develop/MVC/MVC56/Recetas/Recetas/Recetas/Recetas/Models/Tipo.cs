namespace Recetas.Models
{
    public class Tipo
    {
        public int Id { get; set; }

        public int RecetaId { get; set; }
        public Receta Receta { get; set; }
    }
}

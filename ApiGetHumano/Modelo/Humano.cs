using System.ComponentModel.DataAnnotations;

namespace ApiGetHumano.Modelo
{
    public class Humano
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public decimal Altura { get; set; }
        [Required]
        public decimal Peso { get; set; }
    }
}

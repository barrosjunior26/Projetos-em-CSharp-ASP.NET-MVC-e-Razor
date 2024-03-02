using System.ComponentModel.DataAnnotations;

namespace WebApplication_CadastroCarros.Models
{
    public class Cadastro
    {
        [Key]
        public int Codigo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public string? Potencia { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace WebApplication_CadastroCarros.Models
{
    public class MeuContextoBancoDeDados : DbContext
    {
        public MeuContextoBancoDeDados(DbContextOptions<MeuContextoBancoDeDados> options) : base(options)
        {
            
        }

        public DbSet<MeuContextoBancoDeDados> Cadastro { get; set; }
    }
}

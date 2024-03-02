using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_CadastroCarros.Models;

namespace WebApplication_CadastroCarros.Data
{
    public class WebApplication_CadastroCarrosContext : DbContext
    {
        public WebApplication_CadastroCarrosContext (DbContextOptions<WebApplication_CadastroCarrosContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_CadastroCarros.Models.Cadastro> Cadastro { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexto
{
    public class Contexto : DbContext //Referencia ao packet
    {
        public Contexto(DbContextOptions<Contexto> options) //construto (quando referenciar contexto startup vai passar a string de conexao)
            :base(options)
            //toda vez que a conexão com o Db é necessário um migration, qu vai perguntar quais as classess que serão criadas
        {         }

        public DbSet<Usuario> Usuario { get; set; }// para mostrar as tableas que o entity vai gerenciar, para o link e o banco, sera necessario um dbser
    }
}

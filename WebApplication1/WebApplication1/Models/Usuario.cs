using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/* PRIMEIRO PROJETO EM C# */

namespace WebApplication1.Models
{
    [Table("Usuario")] // para escolher o nome da tabela no banco (colocar o mesmo nome da classe é mais organizado)
    public class Usuario
    {
        [Display(Name ="Código")] //nome que vai aparecer na tela
        [Column("Id")] //mesma função do table ali de cima
        public int Id { get; set; } //propriedade id

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
    }
}

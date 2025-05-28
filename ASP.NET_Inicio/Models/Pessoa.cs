using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Inicio.Models
{
    public class Pessoa
    {
        [Display(Name ="Codigo do Cliente")]

        public int PessoaId { get; set; }
        [Display(Name = "Nome do CLiente")]
        public string? Nome {  get; set; }
        [EmailAddress(ErrorMessage = "Endereço de email errado")]
        public string? Email { get; set; }
    }
}

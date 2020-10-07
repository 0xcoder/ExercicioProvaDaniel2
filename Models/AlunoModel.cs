using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DanielProva02Exercicio.Models
{
    public class AlunoModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="Nome:")]
        [Required(ErrorMessage ="Informe o nome")]
        public string Nome { get; set; }

        [Display(Name ="Endereço:")]
        [Required(ErrorMessage ="informe o endereco")]
        public string Endereco { get; set; }

        [Display(Name ="Filiação:")]
        [Required(ErrorMessage ="Informe a filiação")]
        public string Filiacao { get; set; }

        [Display(Name ="Curso:")]
        [Required(ErrorMessage ="Informe o curso:")]
        public string Curso { get; set; }

        [Display(Name = "Telefone:")]
        [Required(ErrorMessage = "Informe o telefone")]
        public string Telefone { get; set; }

        [Display(Name ="E-mail:")]
        [EmailAddress(ErrorMessage ="Informe o E-mail")]
        public string Email { get; set; }
    }
}
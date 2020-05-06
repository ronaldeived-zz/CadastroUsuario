using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroUsuarioMvc.Models
{
    public class Processo
    {
        public int Id_Processo { get; set; }
        public int Id_Cidade { get; set; }
        public int Id_Status { get; set; }
        public string Nome { get; set; }
        public Decimal Cpf { get; set; }
        public int Rg { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public int Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Decimal Celular { get; set; }
        public string Sexo { get; set; }
    }
}
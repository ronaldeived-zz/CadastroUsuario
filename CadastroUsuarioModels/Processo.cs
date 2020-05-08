using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioModels
{
    public class Processo
    {
        [Display(Name = "Id_Processo")]
        public int Id_Processo { get; set; }

        [Display(Name = "Id_Cidade")]
        public int Id_Cidade { get; set; }
        
        [Display(Name = "Id_Status")]
        [Required()]
        public int Id_Status { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o Nome", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Informe o CPF", AllowEmptyStrings = false)]
        public Decimal Cpf { get; set; }
        
        [Display(Name = "RG")]
        [Required()]
        public int Rg { get; set; }
        
        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "Informe o Nascimento", AllowEmptyStrings = false)]
        public DateTime Nascimento { get; set; }
        
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Informe o E-mail", AllowEmptyStrings = false)]
        public string Email { get; set; }
        
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Informe o CEP", AllowEmptyStrings = false)]
        public int Cep { get; set; }
        
        [Display(Name = "Rua")]
        [Required()]
        public string Rua { get; set; }
        
        [Display(Name = "Número")]
        [Required(ErrorMessage = "Informe o número", AllowEmptyStrings = false)]
        public string Numero { get; set; }
        
        [Display(Name = "Complemento")]
        [Required()]
        public string Complemento { get; set; }
        
        [Display(Name = "Bairro")]
        [Required()]
        public string Bairro { get; set; }
        
        [Display(Name = "Celular")]
        [Required()]
        public Decimal Celular { get; set; }
        
        [Display(Name = "Sexo")]
        [Required()]
        public string Sexo { get; set; }
    }
}

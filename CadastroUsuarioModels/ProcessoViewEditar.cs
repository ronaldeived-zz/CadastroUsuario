using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroUsuarioModels
{
    [NotMapped]
    public class ProcessoViewEditar : Processo
    {
        public int Id_Estado { get; set; }

        public int Id_Pais { get; set; }

        [Display(Name = "Status")]
        public string Descricao_Status { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }
        
        public string Cidade { get; set; }
    }
}
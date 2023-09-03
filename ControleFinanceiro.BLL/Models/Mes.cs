using System.Collections.Generic;

namespace ControleFinanceiro.BLL.Models
{
    public class Mes
    {
        public int MesId { get; set; }

        public string Nome { get; set; }

        // As linhas abaixo evita desperdiço de memória
        public virtual ICollection<Ganho> Ganhos { get; set; }

        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}

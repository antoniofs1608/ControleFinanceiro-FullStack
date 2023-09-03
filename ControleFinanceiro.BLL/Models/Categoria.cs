using System.Collections.Generic;

namespace ControleFinanceiro.BLL.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public string Icone { get; set; }

        public int TipoId { get; set; } // FK - Chave Estrangeira

        public Tipo Tipo { get; set; }

        // As linhas abaixo evita desperdiço de memória
        public virtual ICollection<Despesa> Despesas { get; set; }

        public virtual ICollection<Ganho> Ganhos { get; set; }
    }
}

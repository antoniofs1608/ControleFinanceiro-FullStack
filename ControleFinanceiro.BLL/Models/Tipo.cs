using System.Collections.Generic;

namespace ControleFinanceiro.BLL.Models
{
    public class Tipo
    {
        public int TipoId { get; set; } // PK - Chave Primária

        public string Nome { get; set; }

        // Essa linha abaixo evita desperdiço de memória
        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}


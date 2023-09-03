using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;

namespace ControleFinanceiro.DAL.Repositorios
{
    //Classe pública, herda do RepositorioGenerico e implementa a interface ITipoRepositorio
    public class TipoRepositorio : RepositorioGenerico<Tipo>, ITipoRepositorio
    {
        //Vamos criar nosso contexto que é o atributo para acessar as tabelas
        public TipoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}

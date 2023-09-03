using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.DAL.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        //Método que vai pegar todos os dados
        IQueryable<TEntity> PegarTodos();

        //Método que vai pegar os dados por ID, como temos chaves inteiras e string então vamos fazer dois métodos
        Task<TEntity> PegarPeloId(int id);
        Task<TEntity> PegarPeloId(string id);

        //Método para insertir dados que podemos passar uma entidade ou uma lista
        Task Inserir(TEntity entity);
        Task Inserir(List<TEntity> entity);

        //Método para alterar
        Task Atualizar(TEntity entity);

        //Método para excluir dados por ID, como temos chaves inteiras e string então vamos fazer dois métodos
        Task Excluir(string id);
        Task Excluir(int id);

        Task Excluir(TEntity entity);
    }
}

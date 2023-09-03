using ControleFinanceiro.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DAL.Interfaces
{
    // A classe vai ser pública e vai herdar da classse de Categoria
    public interface ICategoriaRepositorio : IRepositorioGenerico<Categoria>
    {
        //Usa new para sobescrever todos que estão no IRepositorioGenerico
        new IQueryable<Categoria> PegarTodos();

        new Task<Categoria> PegarPeloId(int id);

        IQueryable<Categoria> FiltrarCategorias(string nomeCategoria);

        IQueryable<Categoria> PegarCategoriasPeloTipo(string tipo);
    }
}

using Modelo.Tabelas;
using Persistencia.DAL.Tabelas;
using System.Linq;

namespace Servico.Tabelas
{
    public class CategoriaServico
    {
        private CategoriaDAL categoriaDAL = new CategoriaDAL();

        public IQueryable<Categoria> ObterCategoriasClasssificadasPorNome()
        {
            return categoriaDAL.ObterCategoriasClassificadasPorNome();
        }
    }
}

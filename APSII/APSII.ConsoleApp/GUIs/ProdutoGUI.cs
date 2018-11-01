using APSII.DAO.DAOS;
using APSII.Model;
using APSII.Model.Aspects;

namespace APSII.ConsoleApp.GUIs
{
    public class ProdutoGUI
    {
        public ProdutoDAO ProdutoDao { get; private set; }

        public ProdutoGUI() 
            => ProdutoDao = new ProdutoDAO();

        public Produto BuscarProduto(int produtoId)
            => ProdutoDao.Receber(produtoId);

        [LogAspect]
        public Produto Inserir(string nome, string descricao, string categoria) 
            => ProdutoDao.Inserir(Produto.Criar(nome, descricao, categoria));
    }
}
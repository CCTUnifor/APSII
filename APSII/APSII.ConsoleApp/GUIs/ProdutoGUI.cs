using APSII.DAO.DAOS;
using APSII.Model;

namespace APSII.ConsoleApp.GUIs
{
    public class ProdutoGUI
    {
        public ProdutoDAO ProdutoDao { get; private set; }

        public ProdutoGUI() 
            => ProdutoDao = new ProdutoDAO();

        public Produto BuscarProduto(int produtoId)
            => ProdutoDao.Receber(produtoId);

        public Produto Inserir(string nome, string descricao, string categoria) 
            => ProdutoDao.Inserir(Produto.Criar(nome, descricao, categoria));
    }
}
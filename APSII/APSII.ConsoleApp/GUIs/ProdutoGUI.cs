using APSII.DAO.DAOS;
using APSII.Model;

namespace APSII.ConsoleApp.GUIs
{
    public class ProdutoGUI
    {
        public ProdutoDAO ProdutoDao { get; set; }

        public ProdutoGUI() 
            => ProdutoDao = new ProdutoDAO();

        public Produto Inserir(string nome, string descricao, string categoria) 
            => ProdutoDao.Inserir(Produto.Criar(nome, descricao, categoria));

        public Produto BuscarProduto(int produtoId)
            => ProdutoDao.Receber(produtoId);
    }
}
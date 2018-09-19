using System.Collections.Generic;
using System.Linq;
using APSII.Model;

namespace APSII.DAO.DAOS
{
    public class ProdutoDAO
    {
        private int UltimoId { get; set; }
        private ICollection<Produto> Produtos { get; set; }

        public ProdutoDAO()
        {
            UltimoId = 1;
            Produtos = new List<Produto>();
        }

        public Produto Inserir(Produto produto)
        {
            produto.Id = UltimoId++;
            Produtos.Add(produto);
            return produto;
        }

        public Produto Receber(int produtoId) 
            => Produtos.SingleOrDefault(x => x.Id == produtoId);
    }
}

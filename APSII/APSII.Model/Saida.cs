using System;

namespace APSII.Model
{
    public class Saida : Lancamento
    {
        public static Lancamento Criar(int produtoId, int quantidade)
            => new Saida
            {
                Data = DateTime.Now,
                ProdutoId = produtoId,
                Quantidade = quantidade
            };
    }
}
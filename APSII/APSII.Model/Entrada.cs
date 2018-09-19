using System;

namespace APSII.Model
{
    public class Entrada : Lancamento
    {
        public DateTime DataVencimento { get; set; }

        public static Lancamento Criar(int produtoId, int quantidade, DateTime? dataVencimento = null)
        {
            if (!dataVencimento.HasValue)
                throw new ArgumentNullException(nameof(dataVencimento));

            return new Entrada
            {
                Data = DateTime.Now,
                ProdutoId = produtoId,
                Quantidade = quantidade,
                DataVencimento = dataVencimento.Value
            };
        }
    }
}
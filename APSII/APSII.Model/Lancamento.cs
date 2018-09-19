using System;

namespace APSII.Model
{
    public abstract class Lancamento : Entidade
    {
        public int ProdutoId { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }

        public static Lancamento Criar(TipoLancamento tipoLancamento, int produtoId, int quantidade, DateTime? dataVencimento = null)
        {
            switch (tipoLancamento)
            {
                case TipoLancamento.ENTRADA:
                    return Entrada.Criar(produtoId, quantidade, dataVencimento);
                case TipoLancamento.SAIDA:
                    return Saida.Criar(produtoId, quantidade);
                default:
                    return null;
            }
        }
    }

    public enum TipoLancamento
    {
        ENTRADA,
        SAIDA
    }
}
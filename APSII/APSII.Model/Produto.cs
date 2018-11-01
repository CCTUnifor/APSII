using System;
using System.Collections.Generic;
using APSII.Model.Aspects;

namespace APSII.Model
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        private string _categoria { get; set; }
        public string Categoria {
            get { return _categoria; }
            [NotifyAspect]
            set { _categoria = value; } }

        public virtual ICollection<Lancamento> Lancamentos { get; set; }

        public Produto() 
            => Lancamentos = new List<Lancamento>();

        public static Produto Criar(string nome, string descricao, string categoria)
            => new Produto
            {
                Ativo = true,
                Nome = nome,
                Descricao = descricao,
                Categoria = categoria
            };

        public Lancamento AdicionarLancamentoEntrada(int quantidade, DateTime dataVencimento)
        {
            var lancamento = Lancamento.Criar(TipoLancamento.ENTRADA, Id, quantidade, dataVencimento);
            Lancamentos.Add(lancamento);
            return lancamento;
        }

        public Lancamento AdicionarLancamentoSaida(int quantidade)
        {
            var lancamento = Lancamento.Criar(TipoLancamento.SAIDA, Id, quantidade);
            Lancamentos.Add(lancamento);
            return lancamento;
        }
    }
}
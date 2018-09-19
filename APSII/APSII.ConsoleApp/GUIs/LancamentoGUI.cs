using System;
using APSII.DAO.DAOS;
using APSII.Model;

namespace APSII.ConsoleApp.GUIs
{
    public class LancamentoGUI
    {
        public LancamentoDAO LancamentoDao { get; set; }
        public ProdutoDAO ProdutoDao { get; set; }

        public LancamentoGUI()
        {
            LancamentoDao = new LancamentoDAO();
            ProdutoDao = new ProdutoDAO();
        }

        

        public Lancamento AdicionarLancamentoEntrada(Produto produto, int quantidade, DateTime dataVencimento)
        {
            var lancamento = produto.AdicionarLancamentoEntrada(quantidade, dataVencimento);
            LancamentoDao.Inserir(lancamento);
            return lancamento;
        }

        public Lancamento AdicionarLancamentoSaida(Produto produto, int quantidade)
        {
            var lancamento = produto.AdicionarLancamentoSaida(quantidade);
            LancamentoDao.Inserir(lancamento);
            return lancamento;
        }
    }
}
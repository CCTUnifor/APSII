using System;
using APSII.ConsoleApp.GUIs;

namespace APSII.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var produtoGUI = new ProdutoGUI();
            produtoGUI.Inserir("Prod 1", "Descricao 1", "cat");

            var lancamentoGUI = new LancamentoGUI();
            var prod = produtoGUI.BuscarProduto(1);
            var lancamento = lancamentoGUI.AdicionarLancamentoEntrada(prod, 10, DateTime.Now.AddMonths(1));
            
            Console.ReadKey();
        }
    }
}

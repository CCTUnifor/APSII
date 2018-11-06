using System;
using APSII.ConsoleApp.GUIs;
using APSII.Model;

namespace APSII.ConsoleApp
{
    public class Program
    {
        static void Main(string[] _args)
        {
            //Register observers
            Subject.UpdateEvent += (args, p) => Console.WriteLine($"Notificado por: {args.Method.DeclaringType.FullName}.{args.Method.Name}({string.Join(", ", args.Arguments)})!");

            var produtoGUI = new ProdutoGUI();
            produtoGUI.Inserir("Prod 1", "Descricao 1", "cat");

            var lancamentoGUI = new LancamentoGUI();
            var prod = produtoGUI.BuscarProduto(1);
            prod.Categoria = "Categoria mudada";

            var lancamento = lancamentoGUI.AdicionarLancamentoEntrada(prod, 10, DateTime.Now.AddMonths(1));

            Console.ReadKey();
        }
    }
}

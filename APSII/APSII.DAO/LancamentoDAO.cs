using System.Collections.Generic;
using APSII.Model;

namespace APSII.DAO.DAOS
{
    public class LancamentoDAO
    {
        private int UltimoId { get; set; }
        private ICollection<Lancamento> Lancamentos { get; set; }

        public LancamentoDAO()
        {
            UltimoId = 1;
            Lancamentos = new List<Lancamento>();
        }

        public Lancamento Inserir(Lancamento lancamento)
        {
            lancamento.Id = UltimoId++;
            Lancamentos.Add(lancamento);
            return lancamento;
        }
    }
}
using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Domain
{
    public class DisputaDaFase: IDisputaDaFase
    {
        #region Propriedades Privadas
        protected IFase _fase;
        #endregion

        #region Propriedades Publicas
        public IFase Fase { get { return _fase; } }
        #endregion

        #region Construtores
        public DisputaDaFase(IFase fase)
        {
            if (fase == null)
                throw new ArgumentNullException("Fase não informada");

            _fase = fase;
        }
        #endregion

        #region Metodos
        public IFase AvancarFase(IFase novaFase)
        {
            var vencedores = new List<IParticipante>();
            int posicaoDoConfrontoNaFase = 1;
            int ultimoConfrontoDaFase = _fase.Confrontos.OrderBy(confronto => confronto.PosicaoDoConfrontoNaFase).Last().PosicaoDoConfrontoNaFase;
            int posicaoDoConfrontoNaNovaFase = 1;
            var confrontosNaNovaFase = new List<IConfronto>();

            while (posicaoDoConfrontoNaFase < _fase.Confrontos.Count)
            {
                var confronto1 = _fase.Confrontos.First(confronto => confronto.PosicaoDoConfrontoNaFase == posicaoDoConfrontoNaFase);
                var apuracaoDoConfronto1 = new ApuracaoDoConfronto(confronto1);
                var resultado1 = apuracaoDoConfronto1.DefinirVencedor();
                posicaoDoConfrontoNaFase++;

                var confronto2 = _fase.Confrontos.First(confronto => confronto.PosicaoDoConfrontoNaFase == posicaoDoConfrontoNaFase);
                var apuracaoDoConfronto2 = new ApuracaoDoConfronto(confronto2);
                var resultado2 = apuracaoDoConfronto2.DefinirVencedor();
                posicaoDoConfrontoNaFase++;

                var novoConfronto = ConfrontoFactory.Criar(resultado1.Vencedor, resultado2.Vencedor, posicaoDoConfrontoNaNovaFase);

                novaFase.AdicionarConfronto(novoConfronto);
                posicaoDoConfrontoNaNovaFase++;
            }

            return novaFase;
        }
        #endregion
    }
}

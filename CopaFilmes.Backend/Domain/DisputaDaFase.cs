using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Factory;
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
        private int _posicaoDoConfrontoNaFase;
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
            _posicaoDoConfrontoNaFase = 1;
            var vencedores = new List<IParticipante>();            
            int posicaoDoConfrontoNaNovaFase = 1;
            var confrontosNaNovaFase = new List<IConfronto>();

            while (_posicaoDoConfrontoNaFase < _fase.Confrontos.Count)
            {
                var resultado1 = ExecutarComfronto();

                var resultado2 = ExecutarComfronto();

                var novoConfronto = ConfrontoFactory.Criar(resultado1.Vencedor, resultado2.Vencedor, posicaoDoConfrontoNaNovaFase);

                novaFase.AdicionarConfronto(novoConfronto);
                posicaoDoConfrontoNaNovaFase++;
            }

            return novaFase;
        }

        private IResultadoDaPartida ExecutarComfronto()
        {            
            var confronto =_fase.Confrontos.First(confronto => confronto.PosicaoDoConfrontoNaFase == _posicaoDoConfrontoNaFase);
            var apuracaoDoConfronto = new ApuracaoDoConfronto(confronto);
            var resultado = apuracaoDoConfronto.DefinirVencedor();

            _posicaoDoConfrontoNaFase++;
            
            return resultado;
        }
        #endregion
    }
}

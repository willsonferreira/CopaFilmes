using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using System;
using System.Linq;

namespace CopaFilmes.Backend.Domain
{
    public class DisputaDoCampeonato: IDisputaDoCampeonato
    {
        #region Propriedades Privadas
        protected ICampeonato _campeonato;
        #endregion

        #region Propriedades Publicas
        public ICampeonato Campeonato { get { return _campeonato; } }
        #endregion

        #region Construtores
        public DisputaDoCampeonato(ICampeonato campeonato)
        {
            if (campeonato == null)
                throw new ArgumentNullException("Campeonato não informado");

            _campeonato = campeonato;
        }
        #endregion

        #region Metodos
        public ICampeonato ExecutarDisputaDasFases()
        {
            var temProximaFase = true;
            var fase = _campeonato.Fases.First();
            while (temProximaFase)
            {
                var disputaDeFase = DisputaDaFaseFactory.Criar(fase);

                var novaFase = FaseFactory.Criar();
                disputaDeFase.AvancarFase(novaFase);
                _campeonato.AdicionarFase(novaFase);

                if (novaFase.Confrontos.Count > 1)
                    fase = novaFase;
                else
                    temProximaFase = false;
            }
            
            return _campeonato;
        }
        #endregion
    }
}

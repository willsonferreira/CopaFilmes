using System.Collections.Generic;

namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface ICampeonato
    {
        IList<IFase> Fases { get; }
        IList<IParticipante> Participantes { get; }
        IResultadoDaFinal ResultadoFinal { get; }
        IList<IFase> AdicionarFase(IFase fase);

        IResultadoDaFinal AdicionarResultadoDaFinal(IResultadoDaFinal resultadoDaFinal);
    }
}

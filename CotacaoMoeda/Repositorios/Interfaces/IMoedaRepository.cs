using System.Collections.Generic;
using CotacaoMoeda.Entidades;

namespace CotacaoMoeda.Repositorios.Interfaces
{
    public interface IMoedaRepository
    {
        bool SalvarMoeda(Moeda moeda);

        List<Moeda> BuscarMoedas();

    }
}

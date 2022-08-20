using System.Collections.Generic;
using System.Linq;
using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Repositorios
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly CotacaoMoedaContext _context;
        

        public MoedaRepository(CotacaoMoedaContext context)
        {
            _context = context;
        }

        public bool SalvarMoeda(Moeda moeda)
        {
            try
            {
                if (moeda.Id == 0)
                    _context.Moeda.Add(moeda);
                else
                    _context.Moeda.Update(moeda);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Moeda> BuscarMoedas()
        {
            return _context.Moeda.Include(c => c.Id).ToList();
        }
    }
}

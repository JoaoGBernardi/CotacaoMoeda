using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CotacaoMoeda.Repositorios
{
    public class CotacaoRepository
    {
        private readonly CotacaoMoedaContext _context;


        public CotacaoRepository(CotacaoMoedaContext context)
        {
            _context = context;
        }
        public bool SalvarCotacao(Cotacao cotacao)
        {
            try
            {
                if (cotacao.Id == 0)
                    _context.Cotacao.Add(cotacao);
                else
                    _context.Cotacao.Update(cotacao);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

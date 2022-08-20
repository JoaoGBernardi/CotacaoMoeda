using System.Collections;
using System.Collections.Generic;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CotacaoMoeda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class CotacaoMoedaController
    {
        private readonly IMoedaRepository _moedaRepository;
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoMoedaController(IMoedaRepository moedaRepository, ICotacaoRepository cotacaoRepository)
        {
            _moedaRepository = moedaRepository;
            _cotacaoRepository = cotacaoRepository;
        }
        [HttpPost]
        [Route("Adicionar-moeda")]
        public bool AdicionarMoeda([FromBody]Moeda moeda)
        {
            try
            {
                return _moedaRepository.SalvarMoeda(moeda);
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("Buscar-moedas")]
        public IEnumerable<Moeda> BuscarMoedas()
        {
            return _moedaRepository.BuscarMoedas();
        }
        private IEnumerable<Moeda> Moeda()
        {
            var moedas = new List<Moeda>();
            moedas.Add(new Moeda() { Id = 1, Nome = "Real", Sigla = "R$", Pais = "Brasil" });
            moedas.Add(new Moeda() { Id = 2, Nome = "Dolar", Sigla = "$", Pais = "Estados Unidos" });
            moedas.Add(new Moeda() { Id = 1, Nome = "Euro", Sigla = "&", Pais = "França" });

            return moedas;

        }
    }
}

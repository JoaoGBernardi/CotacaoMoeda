using System;
using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Entidades
{
    public class Cotacao : Entity
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Moeda Moeda { get; set; }
    }
}

using CotacaoMoeda.Entidades;
using System;
using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Models
{
    public class CotacaoModel
    {
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public Moeda Moeda { get; set; }
    }
}

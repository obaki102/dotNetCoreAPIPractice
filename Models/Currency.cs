using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyKey { get; set; }
        public string CurrencyAlternateKey { get; set; }
        public string CurrencyName { get; set; }


    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace KursWalutApp.Models
{
    public class ExchangeRateModel
    {
        [Key]
        public int Id { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Mid { get; set; }

        public DateTime Date { get; set; }
    }
    
}

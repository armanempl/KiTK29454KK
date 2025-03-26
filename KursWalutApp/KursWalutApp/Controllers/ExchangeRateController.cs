using KursWalutApp.Data;
using KursWalutApp.Models;
using KursWalutApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KursWalutApp.Controllers
{
    public class ExchangeRateController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly NBPService _nbpService;
        public ExchangeRateController(ApplicationDbContext context, NBPService nbpService)
        {
            _context = context;
            _nbpService = nbpService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHistoricalRates(string code)
        {
            var rates = await _context.ExchangeRates
                .Where(r => r.Code == code)
                .OrderBy(r => r.Date)
                .ToListAsync();

            return Json(rates);
        }

        public async Task<IActionResult> Index()
        {
            var rates = await _nbpService.GetExchangeRates();

            foreach (var rate in rates)
            {
                _context.ExchangeRates.Add(new ExchangeRateModel
                {
                    Currency = rate.Currency,
                    Code = rate.Code,
                    Mid = Math.Round(rate.Mid,2),
                    Date = DateTime.UtcNow
                });
            }

            await _context.SaveChangesAsync();

            var priorityCurrencies = new List<string>
    {
        "EUR", "USD", "AUD", "TRY", "CHF", "NOK", "UAH", "KRW"
    };

            var latestRates = _context.ExchangeRates
                .GroupBy(r => r.Code)
                .Select(g => g.OrderByDescending(r => r.Date).First())
                .ToList();

            var sortedRates = latestRates
                .OrderBy(r => !priorityCurrencies.Contains(r.Code))
                .ThenBy(r => r.Currency)
                .ToList();

            return View(sortedRates);
        }
    }
}

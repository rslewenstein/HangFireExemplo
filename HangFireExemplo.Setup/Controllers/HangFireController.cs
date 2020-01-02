using Hangfire;
using HangFireExemplo.Core.Exemplo;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HangFireExemplo.Controllers
{
    [Route("/Api/HangFire")]
    public class HangFireController : Controller
    {
        private IExemploServico exemploServico;

        public HangFireController(IExemploServico exemploServico)
        {
            this.exemploServico = exemploServico;
        }

        [HttpGet]
        public IActionResult Index()
        {
             RecurringJob.AddOrUpdate("Recurring! ", () => this.exemploServico.RunDemoTask(), Cron.Minutely);

           // BackgroundJob.Schedule(() => this.exemploServico.RunDemoTask(), TimeSpan.FromMilliseconds(100000));

           // BackgroundJob.Enqueue(() => this.exemploServico.RunDemoTask());

            return Ok();
        }
    }
}
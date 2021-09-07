using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class PessoaController : Controller
    {
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        public IActionResult PessoaData()
        {
            var pessoa = new Pessoa {
                Nome = "Giulia Augusto",
                Endereco = "Rua A, 123 - Perdões",
                Email = "giulia@gmail.com",
                Contato = "035987654321"
            };

            return View(pessoa);
        }

        public IActionResult Formulario()
        {
            return View();
        }
    }
}

using CalcularGastoFuncionario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalcularGastoFuncionario.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                var custoTotal = funcionario.CalcularCustoTotal();
                ViewBag.CustoTotal = custoTotal;
                ViewBag.Nome = funcionario.Nome;
                return View("Resultado");
            }
            return View("Index");
        }
    }
}

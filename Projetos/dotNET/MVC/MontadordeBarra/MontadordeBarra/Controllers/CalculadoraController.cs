using Microsoft.AspNetCore.Mvc;
using MontadordeBarra.Models;

namespace MontadordeBarra.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculadoraModel()); // Exibe o formulário inicial
        }

        [HttpPost]
        public IActionResult Index(CalculadoraModel modelo)
        {
            if (modelo.ConsiderarPesoBarra && modelo.PesoBarra <= 0)
            {
                ModelState.AddModelError("PesoBarra", "O peso da barra deve ser maior que 0.");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("PesoAlvo", modelo);
            }

            return View(modelo);
        }

        public IActionResult PesoAlvo(CalculadoraModel modelo)
        {
            return View(modelo); // Exibe a próxima etapa
        }

        [HttpPost]
        public IActionResult PesoAlvoPost(CalculadoraModel modelo)
        {
            if (modelo.PesoAlvo <= 0)
            {
                ModelState.AddModelError("PesoAlvo", "O peso alvo deve ser maior que 0.");
                return View("PesoAlvo", modelo);
            }

            // Se o peso da barra for considerado, atualiza o valor real necessário
            if (modelo.ConsiderarPesoBarra && modelo.PesoBarra.HasValue)
            {
                modelo.PesoAlvo -= modelo.PesoBarra.Value;
            }

            // Redireciona para a próxima etapa, ou exibe os resultados
            return RedirectToAction("Resultado", modelo);
        }

        public IActionResult Resultado(CalculadoraModel modelo)
        {
            return View(modelo); // Mostra os resultados finais
        }
    }
}

using System.Diagnostics;
using EstudaMais.Models;
using EstudaMais.Repositório;
using Microsoft.AspNetCore.Mvc;

namespace EstudaMais.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMateriaRepositorio _materiaRepositorio;
        public HomeController(IMateriaRepositorio materiaRepositorio)
        {
            _materiaRepositorio = materiaRepositorio;
        }
        public IActionResult Index()
        {
            List<MateriaModel> materias = _materiaRepositorio.BuscarTodas();
            return View(materias);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ExcluirConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(MateriaModel materia)
        {
            _materiaRepositorio.Adicionar(materia);
            return RedirectToAction("Index");
        }
    }
}

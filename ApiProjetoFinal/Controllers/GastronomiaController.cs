using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetoFinal.Controllers
{
    public class GastronomiaController : Controller
    {
        private readonly AplicationDbContext _context;

        public AtracoesController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Atracoes atracoes)
        {
            if (ModelState.IsValid)
            {
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Editar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Atracoes atracoes)
        {
            if (ModelState.IsValid)
            {
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Deletar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Deletar(Atracoes atracoes)
        {
            try
            {
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(atracoes);
            }
        }
    }
}
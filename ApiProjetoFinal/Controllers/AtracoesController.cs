using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjetoFinal.Data;
using ApiProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetoFinal.Controllers
{
    public class AtracoesController : Controller
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
                _context.Add(atracoes);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Editar(int id)
        {
            var atracao = _context.Atracoes.FirstOrDefault(x => x.Id == id);
            if (atracao == null) return RedirectToAction("Index");

            return View(atracao);
        }

        [HttpPost]
        public IActionResult Editar(Atracoes atracoes)
        {
            if (ModelState.IsValid)
            {
                _context.Update(atracoes);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Deletar(int id)
        {
            var atracao = _context.Atracoes.FirstOrDefault(x => x.Id == id);
            if (atracao == null) return RedirectToAction("Index");

            return View(atracao);
        }

        [HttpPost]
        public IActionResult Deletar(Atracoes atracoes)
        {
            try
            {
                _context.Remove(atracoes);
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
    
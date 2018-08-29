using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjetoFinal.Data;
using ApiProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetoFinal.Controllers
{
    public class ComercioController : Controller
    {
        private readonly AplicationDbContext _context;

        public ComercioController(AplicationDbContext context)
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
        public IActionResult Novo(Comercio comercio)
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
            var comercio = _context.Comercios.FirstOrDefault(x => x.Id == id);
            if (comercio == null) return RedirectToAction("Index");

            return View(comercio);
        }

        [HttpPost]
        public IActionResult Editar(Comercio  comercio)
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
            var comercio = _context.Comercios.FirstOrDefault(x => x.Id == id);
            if (comercio == null) return RedirectToAction("Index");

            return View(comercio);
        }

        [HttpPost]
        public IActionResult Deletar(Comercio comercio)
        {
            try
            {
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(comercio);
            }
        }
    }
}
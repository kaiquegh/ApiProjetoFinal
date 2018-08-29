using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjetoFinal.Data;
using ApiProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetoFinal.Controllers
{
    public class GastronomiaController : Controller
    {
        private readonly AplicationDbContext _context;

        public GastronomiaController(AplicationDbContext context)
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
        public IActionResult Novo(Gastronomia gastronomia)
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
            var gastronomia = _context.Gastronomia.FirstOrDefault(x => x.Id == id);
            if (gastronomia == null) return RedirectToAction("Index");

            return View(gastronomia);
        }

        [HttpPost]
        public IActionResult Editar(Gastronomia gastronomia)
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
            var gastronomia = _context.Gastronomia.FirstOrDefault(x => x.Id == id);
            if (gastronomia == null) return RedirectToAction("Index");

            return View(gastronomia);
        }

        [HttpPost]
        public IActionResult Deletar(Gastronomia gastronomia)
        {
            try
            {
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(gastronomia);
            }
        }
    }
}
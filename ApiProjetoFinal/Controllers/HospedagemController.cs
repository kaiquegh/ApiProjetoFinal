using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjetoFinal.Data;
using ApiProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetoFinal.Controllers
{
    public class HospedagemController : Controller
    {
        private readonly AplicationDbContext _context;

        public HospedagemController(AplicationDbContext context)
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
        public IActionResult Novo(Hospedagem hospedagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospedagem);
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
        public IActionResult Editar(Hospedagem hospedagem)
        {
            if (ModelState.IsValid)
            {
                _context.Update(hospedagem);
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
        public IActionResult Deletar(Hospedagem hospedagem)
        {
            try
            {
                _context.Remove(hospedagem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(hospedagem);
            }
        }
    }
}
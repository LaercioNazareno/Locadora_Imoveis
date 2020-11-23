using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using locadora.Models;
using locadora.Data;
using Microsoft.EntityFrameworkCore;

namespace locadora.Controllers
{
    public class CobrancaController: BaseController
    {
        public CobrancaController(LocadoraContext context): base(context)
        {

        }
        public IActionResult Index()
        {
            List<Cobranca> v_cobrancaList = _context.Cobranca.Include("Cliente").ToList(); 
            return View(v_cobrancaList);
        }
        public IActionResult Details(long Id)
        {
            Cobranca v_cobranca = _context.Cobranca.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            ViewBag.Selecionador = LocatarioList();
            return View("Cobranca", v_cobranca);
        }
        public IActionResult Delete(long Id)
        {
            Cobranca v_cobranca = _context.Cobranca.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            _context.Cobranca.Remove(v_cobranca);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Cobranca cobranca)
        {
            if(cobranca.Id == 0){
                _context.Cobranca.Add(cobranca);
            }else{
                _context.Cobranca.Update(cobranca);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}
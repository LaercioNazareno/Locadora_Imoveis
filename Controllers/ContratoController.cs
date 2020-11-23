using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using locadora.Models;
using locadora.Data;
using Microsoft.EntityFrameworkCore;

namespace locadora.Controllers
{
    public class ContratoController: BaseController
    {

        public ContratoController(LocadoraContext context): base(context)
        {
        }
        public IActionResult Index()
        {
            List<Contrato> v_contratoList = _context.Contrato.Include("Locatario").Include("Imovel").ToList(); 
           return View(v_contratoList);
        }
        public IActionResult Details(long Id)
        {
            Contrato v_contrato = _context.Contrato.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
             ViewBag.SelecionadorLocatario = LocatarioList();
            ViewBag.SelecionadorImovel = ImovelList();
            return View("Contrato", v_contrato);
        }
        public IActionResult Delete(long Id)
        {
            Contrato v_contrato = _context.Contrato.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            _context.Contrato.Remove(v_contrato);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Contrato contrato)
        {
            if(contrato.Id == 0){
                _context.Contrato.Add(contrato);
            }else{
                _context.Contrato.Update(contrato);
            }
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
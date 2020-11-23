using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using locadora.Models;
using locadora.Data;
using Microsoft.EntityFrameworkCore;

namespace locadora.Controllers
{
    public class ImovelController: BaseController
    {

        public ImovelController(LocadoraContext context): base(context)
        {
        }
        public IActionResult Index()
        {
            List<Imovel> v_imovelList = _context.Imovel.Include("Locador").ToList(); 
            return View(v_imovelList);
        }
        public IActionResult Details(long Id)
        {
            Imovel v_imovel = _context.Imovel.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            ViewBag.SelecionadorLocatario = LocatarioList();
            return View("Imovel", v_imovel);
        }
        public IActionResult Delete(long Id)
        {
            Imovel v_imovel = _context.Imovel.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            _context.Imovel.Remove(v_imovel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Imovel imovel)
        {
            if(imovel.Id == 0){
                _context.Imovel.Add(imovel);
            }else{
                _context.Imovel.Update(imovel);
            }
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
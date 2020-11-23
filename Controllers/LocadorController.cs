using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using locadora.Models;
using locadora.Data;

namespace locadora.Controllers
{
    public class LocadorController: BaseController
    {

        public LocadorController(LocadoraContext context): base(context)
        {
        }
        public IActionResult Index()
        {
            List<Locador> v_locadorList = _context.Locador.ToList(); 
            return View(v_locadorList);
        }
        public IActionResult Details(long Id)
        {
            Locador v_locador = _context.Locador.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            return View("Locador", v_locador);
        }
        public IActionResult Delete(long Id)
        {
            Locador v_locador = _context.Locador.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            _context.Locador.Remove(v_locador);
            _context.SaveChanges();
            List<Locador> v_locadorList = _context.Locador.ToList(); 
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Locador locador)
        {
            if(locador.Id == 0){
                _context.Locador.Add(locador);
            }else{
                _context.Locador.Update(locador);
            }
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
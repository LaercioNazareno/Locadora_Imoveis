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
    public class LocatarioController: BaseController
    {

        public LocatarioController(LocadoraContext context): base(context)
        {
        }
        public IActionResult Index()
        {
            List<Locatario> v_locatarioList = _context.Locatario.ToList(); 
            return View(v_locatarioList);
        }
        public IActionResult Details(long Id)
        {
            Locatario v_locatario = _context.Locatario.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            return View("Locatario", v_locatario);
        }
        public IActionResult Delete(long Id)
        {
            Locatario v_locatario = _context.Locatario.Where(x=>x.Id == Id).ToList().FirstOrDefault(); 
            _context.Locatario.Remove(v_locatario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Locatario locatario)
        {
            if(locatario.Id == 0){
                _context.Locatario.Add(locatario);
            }else{
                _context.Locatario.Update(locatario);
            }
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
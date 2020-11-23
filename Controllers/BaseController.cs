using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using locadora.Models;
using locadora.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace locadora.Controllers
{
    public class BaseController: Controller 
    {
        protected readonly LocadoraContext _context;

        public BaseController(LocadoraContext context)
        {
            _context = context;
        }
        protected SelectList ImovelList(){
            var dictionary = new Dictionary<long, string>();
            dictionary.Add(0,"Selelcione um Imóvel");
            List<Imovel> ImovelList = _context.Imovel.ToList();
            foreach (var imovel in ImovelList)
            {
                dictionary.Add(imovel.Id, imovel.Descricao);
            }
            return new SelectList(dictionary, "Key", "Value");
        }
        protected SelectList LocadorList(){
            var dictionary = new Dictionary<long, string>();
            dictionary.Add(0,"Selelcione um CPF");
            List<Locador> locadoresList = _context.Locador.ToList();
            foreach (var cliente in locadoresList)
            {
                dictionary.Add(cliente.Id, cliente.Cpf);
            }
            return new SelectList(dictionary, "Key", "Value");
        }
        protected SelectList LocatarioList(){
            var dictionary = new Dictionary<long, string>();
            dictionary.Add(0,"Selelcione um CPF");
            List<Locador> locadoresList = _context.Locador.ToList();
            foreach (var cliente in locadoresList)
            {
                dictionary.Add(cliente.Id, cliente.Cpf);
            }
            return new SelectList(dictionary, "Key", "Value");
        }
    }
}
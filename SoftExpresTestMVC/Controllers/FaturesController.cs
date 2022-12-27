using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftExpresTestMVC.Data.Service;
using SoftExpresTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace SoftExpresTestMVC.Controllers
{
    public class FaturesController : Controller
    {
        public readonly SoftExpresTextMVCService _service;
        public FaturesController(SoftExpresTextMVCService service)
        {
            _service = service;
        }

        //Serach  // All
        [HttpGet]
        public async Task<IActionResult> Index(string searching)
        {

            var data = await _service.GetAllFatura(searching);

            return View(data);
        }

        //Create
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Emertimi,Njesia,DatasKdences,Cmimi,Lloji,KaTvsh,Tipi,Barkod")] Fature fature)
        {
            if (!ModelState.IsValid)
            {
                return View(fature);
            }
            await _service.AddFature(fature);
            return RedirectToAction(nameof(Create));
        }

        //Update

        [HttpGet]

        public IActionResult Edito(int id)
        {
            var edito = _service.GetFature(id);
            if (edito == null) return View("Not Found");
            return View(edito);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edito(int id, [Bind("Id,Emertimi,Njesia,DatasKdences,Cmimi,Lloji,KaTvsh,Tipi,Barkod")] Fature fature)
        {
            if (!ModelState.IsValid)
            {
                return View(fature);
            }
            _service.UpdateAsync(id, fature);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> Fshi(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

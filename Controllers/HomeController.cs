using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 
             var mesact = DateTime.Today.Month; 
            int bXd = minutos*12;
            var dinm = DateTime.DaysInMonth(18, mesact);
            var td = DateTime.Today.Day;
            int bXtM = dinm-td;
            int bT = bXtM*bXd;
            int e = 31*bXd, f = 28*bXd, mz = 31*bXd, ab = 30*bXd, my = 31*bXd, jn = 30*bXd, jl = 31*bXd, ag = 31*bXd, s = 30*bXd, o = 31*bXd, n = 30*bXd, d = 31*bXd;
            switch(mesact){
                case 1: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Febrero: {f}]-[Marzo: {mz}]-[Abril: {ab}]-[Mayo: {my}]-[Junio: {jn}]-[Julio: {jl}]-[Agosto: {ag}]-[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 2: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Marzo: {mz}]-[Abril: {ab}]-[Mayo: {my}]-[Junio: {jn}]-[Julio: {jl}]-[Agosto: {ag}]-[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 3: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Abril: {ab}]-[Mayo: {my}]-[Junio: {jn}]-[Julio: {jl}]-[Agosto: {ag}]-[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 4: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Mayo: {my}]-[Junio: {jn}]-[Julio: {jl}]-[Agosto: {ag}]-[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 5: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Junio: {jn}]-[Julio: {jl}]-[Agosto: {ag}]-[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 6: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Julio: {jl}]-[Agosto: {ag}]-[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 7: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Agosto: {ag}]-[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 8: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Septiembre: {s}]-[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 9: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Octubre: {o}]-[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 10: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"[Noviembre: {n}]-[Diciembre: {d}]";
                break;
                case 11: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = $"Diciembre: {d}]";
                break;
                case 12: 
                ViewBag.Dias = bXtM;
                ViewBag.Botellas = bT;
                ViewBag.MesesQueQuedan = "vas a gastar solo esas botellas hasta el fin del año";
                break;
            }
    
            return View();
        }

    }
}

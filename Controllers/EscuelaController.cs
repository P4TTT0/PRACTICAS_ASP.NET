using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURSO_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CURSO_ASP.NET.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext context;
        public IActionResult Index()
        {

            Escuela escuela = this.context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context)
        {
            this.context = context;
        }
    }
}
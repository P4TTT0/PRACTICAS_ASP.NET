using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURSO_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CURSO_ASP.NET.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            
            return View(new Asignatura("Programacion"));
        }

        public IActionResult MultiAsignatura()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            listaAsignaturas.Add(new Asignatura("Matematica"));
            listaAsignaturas.Add(new Asignatura("Programacion"));
            listaAsignaturas.Add(new Asignatura("Laboratorio"));
            listaAsignaturas.Add(new Asignatura("Ingles"));
            return View("MultiAsignatura", listaAsignaturas);
        }
    }
}
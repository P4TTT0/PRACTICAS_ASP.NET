using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURSO_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CURSO_ASP.NET.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            
            return View(new Alumno("Juan"));
        }

        public IActionResult MultiAlumno()
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            listaAlumno.Add(new Alumno("Roger"));
            listaAlumno.Add(new Alumno("Felix"));
            listaAlumno.Add(new Alumno("Juan Domingo"));
            listaAlumno.Add(new Alumno("Ezequiel"));
            listaAlumno.Add(new Alumno("Bernardo"));
            listaAlumno.Add(new Alumno("Luis"));
            return View("MultiAlumno", listaAlumno);
        }
    }
}
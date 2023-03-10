using System;
using System.Collections.Generic;

namespace CURSO_ASP.NET.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();

        public Alumno (string nombre) => (this.Nombre) = (nombre);
    }
}
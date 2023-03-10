using System;

namespace CURSO_ASP.NET.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }
        public ObjetoEscuelaBase () => (this.UniqueId) = (Guid.NewGuid().ToString());

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}
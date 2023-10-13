using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set;}
        public String Nombre { get; set;}
        public String Apellido { get; set;}
        public String Direccion { get; set;}
        public String Telefono { get; set;}
        public String Email { get; set;}
    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Aplicacion.Service.Dto
{
    public class UsuarioDto
    {
        public long IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
    }
}

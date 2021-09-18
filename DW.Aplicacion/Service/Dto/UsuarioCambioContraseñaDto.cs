using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Aplicacion.Service.Dto
{
    public class UsuarioCambioContraseñaDto
    {
        public string Nombre { get; set; }
        public string ContraseñaAnterior { get; set; }
        public string ContraseñaNueva { get; set; }
    }
}

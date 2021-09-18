using DW.Aplicacion.Service;
using DW.Aplicacion.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DW.Api.Controllers
{
    public class UsuarioController : ApiController
    {
        UsuarioService _usuarioService;
        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }

        [Route("api/Usuario/Login")]
        [HttpPost]
        public UsuarioDto Login(UsuarioDto usuario)
        {
            return _usuarioService.Login(usuario.Nombre, usuario.Contraseña);
        }

        [Route("api/Usuario/Registrar")]
        [HttpPost]
        public UsuarioDto Registrar(UsuarioDto usuario)
        {
            return _usuarioService.Registrar(usuario.Nombre, usuario.Contraseña);
        }

        [Route("api/Usuario/cambiarContraseña")]
        [HttpPut]
        public UsuarioDto CambiarContraseña(UsuarioCambioContraseñaDto usuario)
        {
            return _usuarioService.CambiarContraseña(usuario.Nombre , usuario.ContraseñaAnterior, usuario.ContraseñaNueva);
        }

        [Route("api/Usuario/eliminar")]
        [HttpDelete]
        public void Eliminar(UsuarioDto usuario)
        {
             _usuarioService.Eliminar(usuario.Nombre , usuario.Contraseña);
        }
    }
}
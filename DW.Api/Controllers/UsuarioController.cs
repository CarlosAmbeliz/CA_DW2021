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
        // GET api/<controller>
        public UsuarioDto Login(string usuario, string contraseña)
        {
            return _usuarioService.Login(usuario, contraseña);
        }

    }
}
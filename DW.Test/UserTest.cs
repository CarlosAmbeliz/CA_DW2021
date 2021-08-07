using DW.Aplicacion.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DW.Test
{
    [TestClass]
    public class UserTest
    {
        UsuarioService _userService;

        public UserTest()
        {
            _userService = new UsuarioService();
        }

        [TestMethod]
        public void CrearUsuario()
        {
            _userService.Registrar("carlos", "1234");
            _userService.Login("carlos", "1234");
            
        }
    }
}

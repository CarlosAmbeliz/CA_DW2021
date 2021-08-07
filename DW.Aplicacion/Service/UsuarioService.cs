using DW.Aplicacion.Service.Dto;
using DW.Dominio.Base;
using DW.Dominio.Entidades;
using DW.Infraestructura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Aplicacion.Service
{
    public class UsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        public UsuarioDto Login(string usuario, string contraseña)
        {
            var usuarioEntity = _usuarioRepository.Login(usuario, contraseña);
            return new UsuarioDto()
            {
                IdUsuario = usuarioEntity.Id,
                Nombre = usuarioEntity.Nombre,
            };
        }

        public UsuarioDto Registrar(string usuario, string contraseña)
        {
            UsuarioBo usuarioEntity = new UsuarioBo()
            {
                Nombre = usuario,
                Contraseña = contraseña,
            };
             _usuarioRepository.Save(usuarioEntity);
            return new UsuarioDto()
            {
                IdUsuario = usuarioEntity.Id,
                Nombre = usuarioEntity.Nombre,
            };
        }

        public UsuarioDto CambiarContraseña(string usuario, string contraseñaAnterior, string contraseñaNueva)
        {
            var usuarioEntity = _usuarioRepository.Login(usuario, contraseñaAnterior);
            usuarioEntity.Contraseña = contraseñaNueva;
            _usuarioRepository.Modify(usuarioEntity);
            return new UsuarioDto()
            {
                IdUsuario = usuarioEntity.Id,
                Nombre = usuarioEntity.Nombre,
            };
        }

        public void Eliminar(string usuario, string contraseña)
        {
            var usuarioEntity = _usuarioRepository.Login(usuario, contraseña);
            _usuarioRepository.Remove(usuarioEntity);
        }
    }
}

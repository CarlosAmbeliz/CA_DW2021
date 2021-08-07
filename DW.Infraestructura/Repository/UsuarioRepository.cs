using DW.Dominio.Base;
using DW.Dominio.Entidades;
using DW.Infraestructura.Base;
using DW.Infraestructura.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Infraestructura.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IUsuarioDao _usuarioDao;
        public UsuarioRepository()
        {
            _usuarioDao = new UsuarioDao();
        }

        public IEnumerable<UsuarioBo> GetAll()
        {
            return _usuarioDao.GetAll().Select(usuario=> new UsuarioBo()
            {
                Id = usuario.id_usuario,
                Contraseña = usuario.contraseña,
                Nombre = usuario.nombre,
            }).ToList();
        }

        public UsuarioBo GetByNombre(string nombre)
        {
            var usuario = _usuarioDao.GetByNombre(nombre);
            if (usuario != null)
            {
                return new UsuarioBo()
                {
                    Id = usuario.id_usuario,
                    Contraseña = usuario.contraseña,
                    Nombre = usuario.nombre,
                };
            }
            else
            {
                return null;
            }
         
        }

        public UsuarioBo Login(string nombre, string contraseña)
        {
            var usuario = _usuarioDao.Login(nombre, contraseña);
            if (usuario != null)
            {
                return new UsuarioBo()
                {
                    Id = usuario.id_usuario,
                    Contraseña = usuario.contraseña,
                    Nombre = usuario.nombre,
                };
            }
            else 
            { return null; }
          
        }

        public void Modify(UsuarioBo entity)
        {
            _usuarioDao.Update(new Models.Usuario()
            {
                contraseña = entity.Contraseña,
                nombre = entity.Nombre,
            });
        }

        public void Remove(UsuarioBo entity)
        {
            _usuarioDao.Delete(new Models.Usuario()
            {
                contraseña = entity.Contraseña,
                nombre = entity.Nombre,
                id_usuario = entity.Id,
            });
        }

        public UsuarioBo Save(UsuarioBo entity)
        {
            var usuario =_usuarioDao.Insert(new Models.Usuario()
            {
                contraseña = entity.Contraseña,
                nombre = entity.Nombre,
                id_usuario = entity.Id,
            });
            entity.Id = usuario.id_usuario;
            return entity;
        }
    }
}

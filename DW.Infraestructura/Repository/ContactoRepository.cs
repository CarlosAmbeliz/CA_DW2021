using DW.Dominio.Base;
using DW.Dominio.Entidades;
using DW.Infraestructura.Base;
using DW.Infraestructura.Dao;
using DW.Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Infraestructura.Repository
{
    public class ContactoRepository : IContactoRepository
    {
        private IContactoDao _contactoDao;
        public ContactoRepository()
        {
            _contactoDao = new ContactoDao();
        }

        public IEnumerable<ContactoBo> GetAll()
        {
            return _contactoDao.GetAll().Select(contacto => new ContactoBo()
            {
                Apellidos = contacto.apellidos,
                Direccion = contacto.direccion,
                Email = contacto.email,
                IdContacto = contacto.id_contacto,
                IdUsuario = contacto.id_usuario,
                Nombres = contacto.nombres,
                Telefono= contacto.telefono,
            }).ToList();
        }

        public ContactoBo GetById(long id)
        {
            var contacto = _contactoDao.GetById(id);
            if (contacto!= null)
            {
                return new ContactoBo()
                {
                    Apellidos = contacto.apellidos,
                    Direccion = contacto.direccion,
                    Email = contacto.email,
                    IdContacto = contacto.id_contacto,
                    IdUsuario = contacto.id_usuario,
                    Nombres = contacto.nombres,
                    Telefono = contacto.telefono,
                };
            }
            else
            {
                return null;
            }
        }

        public void Modify(ContactoBo entity)
        {
            _contactoDao.Update(new Contacto()
            {
                apellidos = entity.Apellidos,
                direccion = entity.Direccion,
                email = entity.Email,
                id_contacto = entity.IdContacto,
                id_usuario = entity.IdUsuario,
                nombres = entity.Nombres,
                telefono = entity.Telefono,
            });
        }

        public void Remove(ContactoBo entity)
        {
            _contactoDao.Delete(new Contacto()
            {
                apellidos = entity.Apellidos,
                direccion = entity.Direccion,
                email = entity.Email,
                id_contacto = entity.IdContacto,
                id_usuario = entity.IdUsuario,
                nombres = entity.Nombres,
                telefono = entity.Telefono,
            });
        }

        public ContactoBo Save(ContactoBo entity)
        {
            var contacto = _contactoDao.Insert(new Contacto()
            {
                apellidos = entity.Apellidos,
                direccion = entity.Direccion,
                email = entity.Email,
                id_contacto = entity.IdContacto,
                id_usuario = entity.IdUsuario,
                nombres = entity.Nombres,
                telefono = entity.Telefono,
            });
            entity.IdContacto = contacto.id_contacto;
            return entity;
        }
    }
}

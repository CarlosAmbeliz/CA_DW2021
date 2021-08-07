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
    public class ContactoService
    {
        private IContactoRepository _contactoRepository;
        public ContactoService()
        {
            _contactoRepository = new ContactoRepository();
        }
        public List<ContactoDto> ObtenerTodos(long idUsuario)
        {
            return _contactoRepository.GetAll().Select(contactoEntity => new ContactoDto()
            {
                Apellidos = contactoEntity.Apellidos,
                Direccion = contactoEntity.Direccion,
                Email = contactoEntity.Email,
                IdContacto = contactoEntity.IdContacto,
                IdUsuario = contactoEntity.IdUsuario,
                Nombres = contactoEntity.Nombres,
                Telefono = contactoEntity.Telefono,
            }).ToList();
        }

        public ContactoDto ObtenerPorId(long idContacto)
        {
            var contactoEntity = _contactoRepository.GetById(idContacto);
            if (contactoEntity == null)
            {
                throw new Exception("El contacto no existe");
            }
            return new ContactoDto()
            {
                Apellidos = contactoEntity.Apellidos,
                Direccion = contactoEntity.Direccion,
                Email = contactoEntity.Email,
                IdContacto = contactoEntity.IdContacto,
                IdUsuario = contactoEntity.IdUsuario,
                Nombres = contactoEntity.Nombres,
                Telefono = contactoEntity.Telefono,
            };
        }

        public void Actualizar(ContactoDto contacto)
        {
            var contactoEntity = new ContactoBo()
            {
                Apellidos = contacto.Apellidos,
                Direccion = contacto.Direccion,
                Email = contacto.Email,
                IdContacto = contacto.IdContacto,
                IdUsuario = contacto.IdUsuario,
                Nombres = contacto.Nombres,
                Telefono = contacto.Telefono,
            };
            _contactoRepository.Modify(contactoEntity);
        }

        public void Eliminar(long id)
        {
            var contactoEntity = _contactoRepository.GetById(id);
            if (contactoEntity == null)
            {
                throw new Exception("El contacto no existe");
            }
            _contactoRepository.Remove(contactoEntity);
        }
    }
}

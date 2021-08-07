using DW.Aplicacion.Service.Dto;
using DW.Dominio.Base;
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
        public ContactoDto ObtenerTodos(long idUsuario)
        {
            throw new NotImplementedException();
        }

        public ContactoDto ObtenerPorId(long idContacto)
        {
            throw new NotImplementedException();
        }

        public ContactoDto Actualizar(string idUsuario, ContactoDto contacto)
        {
            throw new NotImplementedException();
        }

        public ContactoDto Eliminar(string idUsuario, long idContacto)
        {
            throw new NotImplementedException();
        }
    }
}

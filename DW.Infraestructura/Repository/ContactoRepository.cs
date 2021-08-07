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
    public class ContactoRepository : IContactoRepository
    {
        private IContactoDao _contactoDao;
        public ContactoRepository()
        {
            _contactoDao = new ContactoDao();
        }

        public IEnumerable<ContactoBo> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Modify(ContactoBo entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(ContactoBo entity)
        {
            throw new NotImplementedException();
        }

        public ContactoBo Save(ContactoBo entity)
        {
            throw new NotImplementedException();
        }
    }
}

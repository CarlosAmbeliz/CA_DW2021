using DW.Infraestructura.Base;
using DW.Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Infraestructura.Dao
{
    public class ContactoDao : IContactoDao
    {
        public void Delete(Contacto entity)
        {
            using (DWEntities context = new DWEntities())
            {
                context.Contacto.Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<Contacto> GetAll()
        {
            using (DWEntities context = new DWEntities())
            {
                return context.Contacto.ToList();
            }
        }

        public Contacto GetById(long id)
        {
            using (DWEntities context = new DWEntities())
            {
                return context.Contacto.Find(id);
            }
        }

        public Contacto Insert(Contacto entity)
        {
            using (DWEntities context = new DWEntities())
            {
                context.Contacto.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public void Update(Contacto entity)
        {
            using (DWEntities context = new DWEntities())
            {
                var entityToUpdate = context.Contacto.Find(entity.id_contacto);
                entityToUpdate.nombres = entity.nombres;
                entityToUpdate.apellidos = entity.apellidos;
                entityToUpdate.direccion = entity.direccion;
                entityToUpdate.email = entity.email;
                entityToUpdate.telefono = entity.telefono;
                context.SaveChanges();
            }
        }
    }
}

using DW.Infraestructura.Base;
using DW.Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.Infraestructura.Dao
{
    public class UsuarioDao : IUsuarioDao
    {
        public void Delete(Usuario entity)
        {
            using (DWEntities context = new DWEntities())
            {
                context.Usuario.Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            using (DWEntities context = new DWEntities())
            {
                return context.Usuario.ToList();
            }
        }

        public Usuario Insert(Usuario entity)
        {
            using (DWEntities context = new DWEntities())
            {
                context.Usuario.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public Usuario Login(string nombre, string contraseña)
        {
            using (DWEntities context = new DWEntities())
            {
                return context.Usuario.Where(x=> x.nombre == nombre & x.contraseña == contraseña).FirstOrDefault();
            }
        }

        public void Update(Usuario entity)
        {
            using (DWEntities context = new DWEntities())
            {
                var entityToUpdate = context.Usuario.Find(entity.id_usuario);
                entityToUpdate.nombre = entity.nombre;
                entityToUpdate.contraseña = entity.contraseña;
                context.SaveChanges();
            }
        }
    }
}

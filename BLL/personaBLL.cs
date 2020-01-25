using System;
using System.Collections.Generic;
using System.Text;
using Registro.DAL;
using Registro.Entidades;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Registro.BLL
{
    public class personaBLL
    {
        public static bool guardar(Persona Persona)
        {
            bool paso = false;
            contexto db = new contexto();
            try
            {
                if (db.Personas.Add(Persona) != null)
                    paso = db.SaveChanges() > 0;
              
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool modificar(Persona persona)
        {
            bool paso = false;
            contexto db = new contexto();
            try
            {
                db.Entry(persona).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool eliminar(int id)
        {
            bool paso = false;
            contexto db = new contexto();
            try
            {
                var eliminar = db.Personas.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges()>0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        
        public static Persona buscar(int id)
        {
            contexto db = new contexto();
            Persona persona = new Persona();

            try
            {
                persona = db.Personas.Find(id);

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return persona;
        }
        
        public static List<Persona> getlist(Expression<Func<Persona, bool>>persona)
        {
            List<Persona> lista = new List<Persona>();
            contexto db = new contexto();

            try
            {
                lista = db.Personas.Where(persona).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}

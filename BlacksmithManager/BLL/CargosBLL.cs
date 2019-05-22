using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    public class CargosBLL
    {
        public static bool Guardar(Cargos cargo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Cargos.Add(cargo) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Cargos cargo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(cargo).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Cargos.Find(id);
                db.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Cargos Buscar(int id)
        {
            Contexto db = new Contexto();
            Cargos cargo = new Cargos();
            try
            {
                cargo = db.Cargos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return cargo;
        }

        /*public static List<Cargos> GetList(Expression<Func<Cargos, bool>> cargo)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Cargos.Where(cargo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }*/
    }
}

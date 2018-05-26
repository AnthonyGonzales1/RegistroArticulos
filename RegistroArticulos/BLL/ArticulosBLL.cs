using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using RegistroArticulos.DAL;
using RegistroArticulos.Entidades;


namespace RegistroArticulos.BLL
{   //Aqui se programa toda la logica del programa
    public class ArticulosBLL
    {    //permite guardar una entidad en la base de datos
        public static bool Guardar(Articulos articulos) {
            //creamos la instancia del contexto para conectar a la base de datos
            bool paso = false;
            Contexto contexto=new Contexto();

            try {
                if (contexto.Articulos.Add(articulos) != null) {
                    contexto.SaveChanges();//guardad cambios
                    paso = true;
                }
                contexto.Dispose();//siempre cerramos la conexion
            }
            catch (Exception) {
                throw;
            }
            return paso;
        }

        //permite modificar una entidad en la base de datos
        public static bool Modificar(Articulos articulos)
        {
           
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                if (contexto.SaveChanges()>0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        //permite eliminar una entidad en la base de datos
        public static bool Eliminar(int ID)
        {
            
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Articulos articulos = contexto.Articulos.Find(ID);
                contexto.Articulos.Remove(articulos);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        //permite buscar una entidad en la base de datos
        public static Articulos Buscar(int ID)
        {   
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();

            try
            {
                articulos = contexto.Articulos.Find(ID);
                contexto.Dispose();
            }

            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
        //permite extraer una lista de articulos de la base de datos
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression) {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.Articulos.Where(expression).ToList();
                contexto.Dispose();
            }

            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
    }

}

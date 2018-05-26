using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroArticulos.Entidades;
using System.Data.Entity;

namespace RegistroArticulos.DAL
{
    public class Contexto : DbContext {
            //public de nuevo para que la clase sea encontrada en cualquier parte
            public DbSet<Articulos> Articulos {get;set;}
            //base(Constr) para pasar la conexion a la clase base de EntityFramwork
            public Contexto() : base("ConStr")
            {        }
            
        }

  }


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace RegistroArticulos.Entidades
{
    public class Articulos
    {
        [Key]//Llave primaria

        public int ArticuloID { get; set; }
        public DateTime FechaVC { get; set; }
        public string Descripcion { get; set; }
        public float Precio {get;set;}
        public float Existencia { get; set; }
        public float CantidadCo { get; set; }

        public Articulos() {
            ArticuloID = 0;
            FechaVC = DateTime.Now;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia = 0;
            CantidadCo = 0;
        }
        

    }
}

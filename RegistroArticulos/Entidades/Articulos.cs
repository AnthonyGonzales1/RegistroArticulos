using System;
using System.ComponentModel.DataAnnotations;



namespace RegistroArticulos.Entidades
{   //debe ser public para su visibilidad
    public class Articulos
    {   //llave primaria
        [Key]//Se importa  using System.ComponentModel.DataAnnotations;

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

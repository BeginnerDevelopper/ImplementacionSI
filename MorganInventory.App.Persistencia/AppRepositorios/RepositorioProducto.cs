using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
   public class RepositorioProducto : IRepositorioProducto
   { List<Producto> Productos;

     public RepositorioProducto()
     {
         Productos = new List<Producto>()
        { new Producto{
            Id_Producto = 1001,
            Preciocompra = 40.000F,
            Precioventa = 18.000F,
            Cantidad = 10,
            Añadido = new DateTime(2021,11,10)

        },
        
          new Producto{
            Id_Producto = 1002,
            Preciocompra = 30.000F,
            Precioventa = 98.000F,
            Cantidad = 5,
            Añadido = new DateTime(2021,11,10)

        },

           new Producto{
            Id_Producto = 1003,
            Preciocompra = 150.000F,
            Precioventa = 300.000F,
            Cantidad = 2,
            Añadido = new DateTime(2021,11,10)

        }


        }; 
     }

        public IEnumerable<Producto> GetAll()
        {
          return Productos;
        }
        public Producto App(Producto producto)
        {
          throw new NotImplementedException();
        }
        public Producto Update(Producto producto)
        {
          throw new NotImplementedException();
        }
        public void Delete(int Id_Producto)
        {
          throw new NotImplementedException();
        }

      public Producto Get(int Id_Producto)
        {
          throw new NotImplementedException();
        } 

      }




}
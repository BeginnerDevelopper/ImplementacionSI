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
          producto.Id_Producto=Productos.Max(r=>r.Id_Producto)+1;
          Productos.Add(producto);
          return producto;
          
        }
        public Producto Update(Producto producto)
        {
           var productoEncontrado= Productos.SingleOrDefault(p=>p.Id_Producto==producto.Id_Producto);
           //single or default devuelve un valor de un producto
           if(productoEncontrado!=null){
             //estos datos provienen y deben coincidir con la entidad o una entidad de la cual se ha heredado.
              productoEncontrado.Preciocompra =producto.Preciocompra;
              productoEncontrado.Precioventa =producto.Precioventa;
              productoEncontrado.Cantidad =producto.Cantidad;
              productoEncontrado.Añadido =producto.Añadido;
           }
           return productoEncontrado;
        }
        public void Delete(int idProducto)
        {
          var producto = Productos.SingleOrDefault(p => p.Id_Producto == idProducto);
          if (producto == null)
                return;
          Productos.Remove(producto);

        }

      public Producto Get(int idProducto)
        {
          return Productos.SingleOrDefault(p => p.Id_Producto == idProducto);
        } 

      }




}
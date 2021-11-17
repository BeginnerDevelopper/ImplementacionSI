using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
   public class RepositorioPedidoVentas : IRepositorioPedidoVentas
   { List<PedidoVentas> Pedidos;

     public RepositorioPedidoVentas()
     {
         Pedidos = new List<PedidoVentas>()
        { new PedidoVentas{
            Id_Pedido = 1001,
            Nombre = "Julian",
            Apellidos = "Barroso",
            Nitcedula = 100437560,
            Precioventa = 175.000F,
            Cantidad = 0,
            Fecha = new DateTime(2021,11,10),
            Estado = "Agotado",
            Descripcion = "Targeta NVIDIA gt9400"

        },
        
          new PedidoVentas{
            Id_Pedido = 1002,
            Nombre = "Sergio",
            Apellidos = "Pedraza",
            Nitcedula = 0700005,
            Precioventa = 175.000F,
            Cantidad = 5,
            Fecha = new DateTime(2021,11,10),
            Estado = "Nuevo",
            Descripcion = "Disco Solido 240GB"

        },

           new PedidoVentas{
            Id_Pedido = 1003,
            Nombre = "Ana",
            Apellidos = "Zapata",
            Nitcedula = 4250023,
            Precioventa = 300.000F,
            Cantidad = 1,
            Fecha = new DateTime(2021,11,10),
            Estado = "Nuevo",
            Descripcion = "Chaleco de Cuero original marrón"
            
            

        }


        }; 
     }

        public IEnumerable<PedidoVentas> GetAll()
        {
          return Pedidos;
        }
        public PedidoVentas App(PedidoVentas Pedido)
        {
          throw new NotImplementedException();
        }
        public PedidoVentas Update(PedidoVentas Pedido)
        {
          throw new NotImplementedException();
        }
        public void Delete(int Id_Pedido)
        {
          throw new NotImplementedException();
        }

      public PedidoVentas Get(int Id_Pedido)
        {
          throw new NotImplementedException();
        } 

      }




}
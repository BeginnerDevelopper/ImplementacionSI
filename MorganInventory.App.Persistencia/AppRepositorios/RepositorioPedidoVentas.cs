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
          Pedido.Id_Pedido=Pedidos.Max(r=>r.Id_Pedido)+1;
          Pedidos.Add(Pedido);
          return Pedido;
          
        }
        public PedidoVentas Update(PedidoVentas Pedido)
        {
          var pedidoEncontrado= Pedidos.SingleOrDefault(p=>p.Id_Pedido == Pedido.Id_Pedido);
           
           if(pedidoEncontrado!=null){
         
              pedidoEncontrado.Nombre =Pedido.Nombre;
              pedidoEncontrado.Apellidos =Pedido.Apellidos;
              pedidoEncontrado.Nitcedula =Pedido.Nitcedula;
              pedidoEncontrado.Cantidad =Pedido.Cantidad;
              pedidoEncontrado.Precioventa =Pedido.Precioventa;
              pedidoEncontrado.Fecha =Pedido.Fecha;
              pedidoEncontrado.Estado =Pedido.Estado;
              pedidoEncontrado.Descripcion =Pedido.Descripcion; 
        }
            return pedidoEncontrado;
        }

        public void Delete(int idPedido)
        {
          var Pedido = Pedidos.SingleOrDefault(p => p.Id_Pedido == idPedido);
          if (Pedido == null)
                return;
          Pedidos.Remove(Pedido);

        }

      public PedidoVentas Get(int idPedido)
        {
          return Pedidos.SingleOrDefault(p => p.Id_Pedido == idPedido);
        } 

      }




}
using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioInformeCompras : IRepositorioInformeCompras
    {List<InformeCompras> Informes;

        public RepositorioInformeCompras() //constructor
        {
            Informes = new List<InformeCompras>()
            {new InformeCompras{
                Id_Compra = 2001,
                Proveedor  = "Luis Angel",
                Fecha = new DateTime(2021,11,10),
                Empleado = "Jessica Arias",
                Neto = 350.000F,
                Iva = 0.19F,
                Total = 665.000F
                 
            },
             new InformeCompras{

                Id_Compra = 2001,
                Proveedor  = "Luis Angel",
                Fecha = new DateTime(2021,11,10),
                Empleado = "Jessica Arias",
                Neto = 350.000F,
                Iva = 0.19F,
                Total = 665.000F
                
            },

             new InformeCompras{

                Id_Compra = 2001,
                Proveedor  = "Luis Angel",
                Fecha = new DateTime(2021,11,10),
                Empleado = "Jessica Arias",
                Neto = 350.000F,
                Iva = 0.19F,
                Total = 665.000F
                
             }

            };
        }
        public IEnumerable<InformeCompras> GetAll() //Almacena información
        {
            return Informes;
        }
        public InformeCompras App(InformeCompras compras)
        {
            compras.Id_Compra = Informes.Max(r=>r.Id_Compra)+1;
            Informes.Add(compras);
            return compras;

        }
        public InformeCompras Update(InformeCompras compras)
        {
             var informecp = Informes.SingleOrDefault(p => p.Id_Compra == compras.Id_Compra);
            if (informecp != null)
            {
                informecp.Proveedor = compras.Proveedor;
                informecp.Fecha = compras.Fecha;
                informecp.Empleado = compras.Empleado;
                informecp.Neto = compras.Neto;
                informecp.Iva = compras.Iva;
                informecp.Total = compras.Total;  
            }
            return informecp;

        }    
        public void Delete(int idInformecompras)
        {
           var compras = Informes.SingleOrDefault(p => p.Id_Compra == idInformecompras);
            if (compras == null)
                return;
            Informes.Remove(compras);

        }
        public InformeCompras Get(int idInformecompras)
        {
            return Informes.SingleOrDefault(p => p.Id_Compra == idInformecompras);
        }
  
    }   


        
}


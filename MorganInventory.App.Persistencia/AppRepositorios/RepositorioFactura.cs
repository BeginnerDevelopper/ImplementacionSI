using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioFactura : IRepositorioFactura
    {List<Factura> resumen;

        public RepositorioFactura() //constructor
        {
            resumen = new List<Factura>()
            {new Factura{
                NumFactura = 2001,
                Cliente = "Andrés Cabales",
                Vendedor = "Jessica Arias",
                Fechahora = new DateTime(2021,11,14),
                Neto = 20.000F,
                Iva = 0.19F,
                Total = 38.000F
            },
             new Factura{
                NumFactura = 2002,
                Cliente = "Martha Aristizabal",
                Vendedor = "Jessica Arias",
                Fechahora = new DateTime(2021/10/01),
                Neto = 20.000F,
                Iva = 0.19F,
                Total = 38.000F
                
            },

             new Factura{
                NumFactura = 2003,
                Cliente = "Angel Fernandez",
                Vendedor = "William Arias",
                Fechahora = new DateTime(2021/10/01),
                Neto = 40.000F,
                Iva = 0.19F,
                Total = 76.000F  
             }
            };
        }
        public IEnumerable<Factura> GetAll() //Almacena información
        {
            return resumen;
        }
        public Factura App(Factura factura)
        {
            throw new NotImplementedException();
        }
        public Factura Update(Factura factura)
        {
            throw new NotImplementedException();
        }
        public void Delete(int NumFactura)
        {
            throw new NotImplementedException();
        }
        public Factura Get(int NumFactura)
        {
            throw new NotImplementedException();
        }
  
    }   


        
}


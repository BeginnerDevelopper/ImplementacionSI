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
            factura.NumFactura = resumen.Max(r => r.NumFactura)+1;
            resumen.Add(factura);
            return factura;
        }
        public Factura Update(Factura factura)
        {
            var facturaEncontrada = resumen.SingleOrDefault(p=>p.NumFactura==factura.NumFactura);
           
           if(facturaEncontrada!=null){

              facturaEncontrada.Cliente = factura.Cliente;
              facturaEncontrada.Vendedor = factura.Vendedor;
              facturaEncontrada.Fechahora = factura.Fechahora;
              facturaEncontrada.Neto = factura.Neto;
              facturaEncontrada.Iva = factura.Iva;
              facturaEncontrada.Total = factura.Total;

           }
            return facturaEncontrada;
        }
        public void Delete(int idFactura)
        {
            var factura = resumen.SingleOrDefault(p => p.NumFactura == idFactura);
            if (factura == null)
                    return;
            resumen.Remove(factura);
        }
        public Factura Get(int idFactura)
        {
           return resumen.SingleOrDefault(p => p.NumFactura == idFactura);
        }
  
    }   


        
}


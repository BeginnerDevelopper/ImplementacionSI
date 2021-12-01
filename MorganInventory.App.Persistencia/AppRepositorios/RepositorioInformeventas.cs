using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioInformeventas : IRepositorioInformeventas
    {List<Informeventas> Informes;

        public RepositorioInformeventas() //constructor
        {
            Informes = new List<Informeventas>()
            {new Informeventas{
                Id_Venta = 2001,
                Cliente  = "Luis Angel",
                Fecha = new DateTime(2021,11,10),
                Vendedor = "Jessica Arias",
                Neto = 350.000F,
                Iva = 0.19F,
                Total = 665.000F
                 
            },
             new Informeventas{

                Id_Venta = 2002,
                Cliente  = "Luis Angel",
                Fecha = new DateTime(2021,11,10),
                Vendedor = "Jessica Arias",
                Neto = 350.000F,
                Iva = 0.19F,
                Total = 665.000F
                
            },

             new Informeventas{

                Id_Venta = 2002,
                Cliente  = "Luis Angel",
                Fecha = new DateTime(2021,11,10),
                Vendedor = "Jessica Arias",
                Neto = 350.000F,
                Iva = 0.19F,
                Total = 665.000F
                
             }

            };
        }
        public IEnumerable<Informeventas> GetAll() //Almacena información
        {
            return Informes;
        }
        public Informeventas App(Informeventas ventas)
        {
            ventas.Id_Venta = Informes.Max(r=>r.Id_Venta)+1;
            Informes.Add(ventas);
            return ventas;
        }
        public Informeventas Update(Informeventas ventas)
        {
            var informevt = Informes.SingleOrDefault(p => p.Id_Venta == ventas.Id_Venta);
            if (informevt != null)
            {
                informevt.Cliente = ventas.Cliente;
                informevt.Fecha = ventas.Fecha;
                informevt.Vendedor = ventas.Vendedor;
                informevt.Neto = ventas.Neto;
                informevt.Iva = ventas.Iva;
                informevt.Total = ventas.Total;  
            }
            return informevt;
        }
        public void Delete(int idInformeventas)
        {
           var ventas = Informes.SingleOrDefault(p => p.Id_Venta == idInformeventas);
          if (ventas == null)
                return;
          Informes.Remove(ventas);

        }
        public Informeventas Get(int idInformeventas)
        {
            return Informes.SingleOrDefault(p => p.Id_Venta == idInformeventas);
        }
  
    }   


        
}


using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioProveedor : IRepositorioProveedor
    {List<Proveedor> Prov;

        public RepositorioProveedor() //constructor
        {
            Prov = new List<Proveedor>()
            {new Proveedor{
                Id = "3554k",
                Nombres = "TIENDA ACCESORIOS LA QUINTA ILERA",
                Apellidos = "",
                Telefono = 3446550,
                Email = "tiendalailera@acess.co",
                Direccion = "calle 33a-330 #24",
                Cuidad = "Bogotá"
            },
             new Proveedor{
                Id = "1401k",
                Nombres = "Martha Lucia",
                Apellidos = "Ocampo",
                Telefono = 3165587414,
                Email = "Mart.25_66@gmail.com",
                Direccion = "Barrio Kennedy cl. 16-21",
                Cuidad = "Pereira"   
             },
             new Proveedor{
                Id = "3061k",
                Nombres = "Centro de mantenimiento de computo S.A",
                Apellidos = "",
                Telefono = 302158794,
                Email = "repararpc@hotmail.com",
                Direccion = "Calle 2-8 Barrio santo domingo",
                Cuidad = "Dosquebradas"   
             },

             new Proveedor{
                Id = "0105k",
                Nombres = "Chalecos al por mayor",
                Apellidos = "",
                Telefono = 366594,
                Email = "Tiendamayorista@hotmail.com",
                Direccion = "Centro Parque Simon Bolivar cl. 12#-22 28",
                Cuidad = "Pereira"   
             }
            };
        }
        public IEnumerable<Proveedor> GetAll() //Almacena información
        {
            return Prov;
        }
        public Proveedor App(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
        public Proveedor Update(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
        public void Delete(string Id_Proveedor)
        {
            throw new NotImplementedException();
        }
        public Proveedor Get(string Id_Proveedor)
        {
            throw new NotImplementedException();
        }
  
    }   


        
}


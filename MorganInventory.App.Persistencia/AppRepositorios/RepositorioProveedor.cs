using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioProveedor : IRepositorioProveedor
    {List<Proveedor> Provedores;

        public RepositorioProveedor() //constructor
        {
            Provedores = new List<Proveedor>()
            {new Proveedor{
                Id_Proveedor = "3554k",
                Nombres = "TIENDA ACCESORIOS LA QUINTA ILERA",
                Apellidos = "",
                Telefono = 3446550,
                Email = "tiendalailera@acess.co",
                Direccion = "calle 33a-330 #24",
                Cuidad = "Bogotá"
            },
             new Proveedor{
                Id_Proveedor = "1401k",
                Nombres = "Martha Lucia",
                Apellidos = "Ocampo",
                Telefono = 3165587414,
                Email = "Mart.25_66@gmail.com",
                Direccion = "Barrio Kennedy cl. 16-21",
                Cuidad = "Pereira"   
             },
             new Proveedor{
                Id_Proveedor = "3061k",
                Nombres = "Centro de mantenimiento de computo S.A",
                Apellidos = "",
                Telefono = 302158794,
                Email = "repararpc@hotmail.com",
                Direccion = "Calle 2-8 Barrio santo domingo",
                Cuidad = "Dosquebradas"   
             },

             new Proveedor{
                Id_Proveedor = "0105k",
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
            return Provedores;
        }
        public Proveedor App(Proveedor proveedor)
        {
            proveedor.Id_Proveedor = Provedores.Max(r=>r.Id_Proveedor)+1;
            Provedores.Add(proveedor);
            return proveedor;
        }
        public Proveedor Update(Proveedor proveedor)
        {
            var proveedorEncontrado = Provedores.SingleOrDefault(p => p.Id_Proveedor == proveedor.Id_Proveedor);
            if (proveedorEncontrado !=null)
            {
                proveedorEncontrado.Nombres = proveedor.Nombres;
                proveedorEncontrado.Apellidos = proveedor.Apellidos;
                proveedorEncontrado.Telefono = proveedor.Telefono;
                proveedorEncontrado.Email = proveedor.Email;
                proveedorEncontrado.Direccion = proveedor.Direccion;
                proveedorEncontrado.Cuidad = proveedor.Cuidad;
            }
                return proveedorEncontrado;
        }
        public void Delete(string idProveedor)
        {
            var proveedor = Provedores.SingleOrDefault(p => p.Id_Proveedor == idProveedor);
            if (proveedor == null)
                return;
            Provedores.Remove(proveedor);
        }
        public Proveedor Get(string idProveedor)
        {
            return Provedores.SingleOrDefault(p => p.Id_Proveedor == idProveedor);
        }
  
    }   


        
}


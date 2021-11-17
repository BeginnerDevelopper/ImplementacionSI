using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{

    public class RepositorioRegistro : IRepositorioRegistro
     {List<Registro> crear;
        public RepositorioRegistro() 
        {
            crear = new List<Registro>()
            {new Registro{

                Id = "1203B",
                Nombres = "Jessica",
                Apellidos = "Arias",
                Telefono = 31336594,
                Email = "jesslaco16@gmail.com",
                Direccion = "Manzana23Casa3 Barrio Cuba",
                Cuidad = "Pereira",
                Nitcedula = 4590014,
                Cargo = "Asistente de ventas y Cajera",
                Fechanacimiento = new DateTime(1982/12/05) 
            },

            new Registro{

                Id = "1204B",
                Nombres = "William",
                Apellidos = "Arias",
                Telefono = 31336594,
                Email = "williamArias47@gmail.com",
                Direccion = "Local san Andresito",
                Cuidad = "Pereira",
                Nitcedula = 4780000,
                Cargo = "Gerente",
                Fechanacimiento = new DateTime(1989/24/08) 

            },    
            new Registro{
                Id = "1205B",
                Nombres = "Carlos",
                Apellidos = "Rojas",
                Telefono = 304639854,
                Email = "CrlMotos@gmail.com",
                Direccion = "Comuna Villa verde Apto 512",
                Cuidad = "Pereira",   
                Nitcedula = 725080,
                Cargo = "Asistente de ventas",
                Fechanacimiento = new DateTime(1979/12/12)   
             },
             new Registro{
                Id = "1206B",
                Nombres = "Jacobo",
                Apellidos = "Arias",
                Telefono = 302158794,
                Email = "Jacobin50@hotmail.com",
                Direccion = "Manzana12Casa2Barrio El poblado",
                Cuidad = "Pereira",
                Nitcedula = 1005795050, 
                Cargo = "Cajero",
                Fechanacimiento = new DateTime(2002/05/02) 
             }
    

            };
        }
        public IEnumerable<Registro> GetAll()
        {
            return crear;
        }
        public Registro App(Registro crearcuenta)
        {
            throw new NotImplementedException();
        }
        public Registro Update(Registro crearcuenta)
        {
            throw new NotImplementedException();
        }
        public void Delete(string Id_Registro)
        {
            throw new NotImplementedException();
        } 
        public Registro Get(string Id_Registro)
        {
            throw new NotImplementedException();
        }
  
    }   

     
}



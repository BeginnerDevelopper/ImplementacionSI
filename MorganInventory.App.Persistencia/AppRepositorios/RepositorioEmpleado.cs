using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {List<Empleado> Empleados;

        public RepositorioEmpleado() //constructor
        {
            Empleados = new List<Empleado>()
            {new Empleado{
                Id = "1204B",
                Nombres = "Jessica",
                Apellidos = "Arias",
                Telefono = 31336594,
                Email = "jesslaco16@gmail.com",
                Direccion = "Manzana23Casa3 Barrio Cuba",
                Cuidad = "Pereira"
            },
             new Empleado{
                Id = "1205B",
                Nombres = "Carlos",
                Apellidos = "Rojas",
                Telefono = 304639854,
                Email = "CrlMotos@gmail.com",
                Direccion = "Comuna Villa verde Apto 512",
                Cuidad = "Pereira"   
             },
             new Empleado{
                Id = "1206B",
                Nombres = "Jacobo",
                Apellidos = "Arias",
                Telefono = 302158794,
                Email = "Jacobin50@hotmail.com",
                Direccion = "Manzana12Casa2Barrio El poblado",
                Cuidad = "Dosquebradas"   
             },

             new Empleado{
                Id = "1207B",
                Nombres = "Jose",
                Apellidos = "Gonzales",
                Telefono = 31336594,
                Email = "sin correo",
                Direccion = "Centro Parque Simon Bolivar cl. 12#-22 28",
                Cuidad = "Pereira"   
             }
            };
        }
        public IEnumerable<Empleado> GetAll() //Almacena información
        {
            return Empleados;
        }
        public Empleado App(Empleado empleado)
        {
            throw new NotImplementedException();
        }
        public Empleado Update(Empleado empleado)
        {
            throw new NotImplementedException();
        }
        public void Delete(string Id_Empleado)
        {
            throw new NotImplementedException();
        }
        public Empleado Get(string Id_Empleado)
        {
            throw new NotImplementedException();
        }
  
    }   


        
        }


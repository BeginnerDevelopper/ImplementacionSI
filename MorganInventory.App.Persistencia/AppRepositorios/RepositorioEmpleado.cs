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
            empleado.Id=Empleados.Max(r=>r.Id)+1;
            Empleados.Add(empleado);
            return empleado;
          
            
        }
        public Empleado Update(Empleado empleado)
        {
          var empleadoEncontrado= Empleados.SingleOrDefault(p=>p.Id == empleado.Id);
        
           if(empleadoEncontrado!=null){
            
              empleadoEncontrado.Nombres =empleado.Nombres;
              empleadoEncontrado.Apellidos =empleado.Apellidos;
              empleadoEncontrado.Telefono=empleado.Telefono;
              empleadoEncontrado.Email =empleado.Email;
              empleadoEncontrado.Direccion = empleado.Direccion;
              empleadoEncontrado.Cuidad = empleado.Cuidad;
           }
           return empleadoEncontrado;
        }
        public void Delete(string idEmpleado)
        {
            var empleado = Empleados.SingleOrDefault(p => p.Id == idEmpleado);
          if (empleado == null)
                return;
          Empleados.Remove(empleado);

        }
        public Empleado Get(string idEmpleado)
        {
           return Empleados.SingleOrDefault(p => p.Id == idEmpleado);
        }
  
    }   


        
        }


using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{

    public class RepositorioRegistro : IRepositorioRegistro
     {List<Registro> crearUsuarios;
        public RepositorioRegistro() 
        {
            crearUsuarios = new List<Registro>()
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
                Fechanacimiento = new DateTime(1982/12/05) ,
                contraseña =""
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
                Fechanacimiento = new DateTime(1989/24/08),
                contraseña =""
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
                Fechanacimiento = new DateTime(1979/12/12), 
                contraseña ="",  
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
                Fechanacimiento = new DateTime(2002/05/02),
                contraseña ="" 
             }
    

            };
        }
        public IEnumerable<Registro> GetAll()
        {
            return crearUsuarios;
        }
        public Registro App(Registro crearcuenta)
        {
          crearcuenta.Id=crearUsuarios.Max(r=>r.Id)+1;
          crearUsuarios.Add(crearcuenta);
          return crearcuenta;
          
        }
        public Registro Update(Registro crearcuenta)
        {
            var usuarioRegistrado = crearUsuarios.SingleOrDefault(p=>p.Id == crearcuenta.Id);
           
           if(usuarioRegistrado!=null){
           
              usuarioRegistrado.Nombres = crearcuenta.Nombres;
              usuarioRegistrado.Apellidos = crearcuenta.Apellidos;
              usuarioRegistrado.Nitcedula = crearcuenta.Nitcedula;
              usuarioRegistrado.Cargo = crearcuenta.Cargo;  
              usuarioRegistrado.Telefono = crearcuenta.Telefono;
              usuarioRegistrado.Email = crearcuenta.Email;
              usuarioRegistrado.Direccion = crearcuenta.Direccion;
              usuarioRegistrado.Cuidad = crearcuenta.Cuidad;
              usuarioRegistrado.Fechanacimiento = crearcuenta.Fechanacimiento;
        }
            return usuarioRegistrado;
        }

        public void Delete(string idRegistro)
        {
            var crearcuenta = crearUsuarios.SingleOrDefault(p => p.Id == idRegistro);
            if (crearcuenta == null)
                return;
            crearUsuarios.Remove(crearcuenta);
        } 
        public Registro Get(string idRegistro)
        {
            return crearUsuarios.SingleOrDefault(p => p.Id == idRegistro);
        }
  
    }   

     
}



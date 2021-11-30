using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioAdministrador:IRepositorioAdministrador
{  List<Administrador> Admin;
     public RepositorioAdministrador()
    { 
      Admin = new List<Administrador>()

     {new Administrador{

          Id = "10056A",
          Nombres = "William",
          Apellidos = "Arias",
          Telefono = 57360789133,
          Email = "CarlosA360@gmail.com",
          Direccion = "calle 22 #12 a 33-01",
          Cuidad = "Pereira"

        },
        
          new Administrador{

          Id = "15127B",
          Nombres = "Luz Mary ",
          Apellidos = "Gutierrez Bedoya",
          Telefono = 57360789133,
          Email = "melomam0@gmail.com",
          Direccion = "San andresito local",
          Cuidad = "Pereira"

        }

        };

    }
        public IEnumerable<Administrador> GetAll()
        {
          return Admin; 
        }
        public Administrador App(Administrador administrador)
        {
            administrador.Id=Admin.Max(r=>r.Id)+1;
            Admin.Add(administrador);
            return administrador;
          
        }
        public Administrador Update(Administrador administrador)
        {
           var adminEncontrado = Admin.SingleOrDefault(p => p.Id == administrador.Id);
           if (adminEncontrado !=null){

             adminEncontrado.Nombres = administrador.Nombres;
             adminEncontrado.Apellidos = administrador.Apellidos;
             adminEncontrado.Telefono =administrador.Telefono;
             adminEncontrado.Email = administrador.Email;
             adminEncontrado.Direccion = administrador.Direccion;
             adminEncontrado.Cuidad = administrador.Cuidad;

           }
           return adminEncontrado;
        }
        public void Delete(string idAdministrador)
        {
            var administrador = Admin.SingleOrDefault(p => p.Id == idAdministrador);
          if (administrador == null)
                return;
          Admin.Remove(administrador);

        }

        public Administrador Get(string idAdministrador)
        {
          return Admin.SingleOrDefault(p => p.Id == idAdministrador);
        }

    }

}

 
  

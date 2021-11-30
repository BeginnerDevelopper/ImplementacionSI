using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {List<Cliente> Clientes;

        public RepositorioCliente() //constructor
        {
            Clientes = new List<Cliente>()
            {new Cliente{
                Id = "3554f",
                Nombres = "Olga",
                Apellidos = "Martinez",
                Telefono = 3446550,
                Email = "Olgamaria90@gmail.co",
                Direccion = "calle 33a-330 #24 Barrio Kennedy",
                Cuidad = "Pereira"
            },
             new Cliente{
                Id = "1401f",
                Nombres = "Leandro ",
                Apellidos = "Prada",
                Telefono = 3165587414,
                Email = "Aguila12@gmail.com",
                Direccion = "Centro avenida cl. 16-15",
                Cuidad = "Pereira"   
             },
             new Cliente{
                Id = "3061f",
                Nombres = "Centro de mantenimiento de computo S.A",
                Apellidos = "",
                Telefono = 302158794,
                Email = "repararpc@hotmail.com",
                Direccion = "Calle 2-8 Barrio santo domingo",
                Cuidad = "Dosquebradas"   
             },

             new Cliente{
                Id = "0105f",
                Nombres = "Ana",
                Apellidos = "Rodriguez",
                Telefono = 3218710211,
                Email = "anarosexl@hotmail.com",
                Direccion = "Avenida 30 de Agosto cl. 12#-22 28",
                Cuidad = "Pereira"   
             },
            
            new Cliente{
                Id = "010df",
                Nombres = "Valeri",
                Apellidos = "Gutierreez",
                Telefono = 3218710211,
                Email = "Roomxt21@hotmail.com",
                Direccion = "Barrio Salamos carrera 15-#22 octava",
                Cuidad = "Pereira"   
             }



            };
        }
        public IEnumerable<Cliente> GetAll() //Almacena información
        {
            return Clientes;
        }
        public Cliente App(Cliente clientes)
        {
            clientes.Id=Clientes.Max(r=>r.Id)+1;
            Clientes.Add(clientes);
            return clientes;
          
        }
        public Cliente Update(Cliente clientes)
        {
            
          var clienteEncontrado= Clientes.SingleOrDefault(p=>p.Id==clientes.Id);
    
           if(clienteEncontrado!=null){
     
              clienteEncontrado.Nombres =clientes.Nombres;
              clienteEncontrado.Apellidos =clientes.Apellidos;
              clienteEncontrado.Telefono =clientes.Telefono;
              clienteEncontrado.Email =clientes.Email;
              clienteEncontrado.Direccion = clientes.Direccion;
              clienteEncontrado.Cuidad =clientes.Cuidad;
                 
           }
            return clienteEncontrado;
        }
    
        public void Delete(string idCliente)
        {
            var clientes = Clientes.SingleOrDefault(p => p.Id == idCliente);
          if (clientes == null)
                return;
          Clientes.Remove(clientes);

        }
        public Cliente Get(string idCliente)
        {
            return Clientes.SingleOrDefault(p => p.Id == idCliente);
        }
  
    }   


        
}


using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
   public class RepositorioAdministrarUsuarios : IRepositorioAdministrarUsuarios
   { List<AdministrarUsuarios> Usuarios;

     public RepositorioAdministrarUsuarios()
     {
         Usuarios = new List<AdministrarUsuarios>()
        { new AdministrarUsuarios{
            IdAdministrarusuarios = 1001,
            Nombre = "William Arias",
            Rol_de_usuario= "Admin",
            Estado = "Desconectado",
            UltimoLogin = new DateTime(2021,10,07),
            contraseña = ""

        },
        
          new AdministrarUsuarios{
            IdAdministrarusuarios = 1002,
            Nombre = "Jessica Arias",
            Rol_de_usuario= "Special",
            Estado = "Activo",
            UltimoLogin = new DateTime(2021,11,05),
            contraseña = ""

        },

           new AdministrarUsuarios{
            IdAdministrarusuarios = 1003,
            Nombre = "Carlos Hernandez",
            Rol_de_usuario= "Special",
            Estado = "Activo",
            UltimoLogin = new DateTime(2021,11,05),
            contraseña = ""

        }




        }; 
     }
        public IEnumerable<AdministrarUsuarios> GetAll()
        {
          return Usuarios;
        }
        public AdministrarUsuarios App(AdministrarUsuarios usuario)
        {
          usuario.IdAdministrarusuarios=Usuarios.Max(r=>r.IdAdministrarusuarios)+1;
          Usuarios.Add(usuario);
          return usuario;
          
        }
        public AdministrarUsuarios Update(AdministrarUsuarios usuario)
        {          
           var users1 = Usuarios.SingleOrDefault(p=>p.IdAdministrarusuarios==usuario.IdAdministrarusuarios);
      
           if(users1!=null){
           
              users1.Nombre = usuario.Nombre;
              users1.Rol_de_usuario = usuario.Rol_de_usuario;
              users1.Estado =usuario.Estado;
              users1.UltimoLogin = usuario.UltimoLogin;
              users1.contraseña =usuario.contraseña;
           } 
            return users1;;
        }
        public void Delete(int idAdministrarUsuarios)
        {
         var usuario = Usuarios.SingleOrDefault(p => p.IdAdministrarusuarios == idAdministrarUsuarios);
          if (usuario == null)
                return;
          Usuarios.Remove(usuario);
 
        }

      public AdministrarUsuarios Get(int idAdministrarUsuarios)
        {
          return Usuarios.SingleOrDefault(p => p.IdAdministrarusuarios == idAdministrarUsuarios);
        } 

      }




}
using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioAutenticaruser : IRepositorioAutenticaruser
    {List<Autenticaruser> Usuario;

        public RepositorioAutenticaruser()
        {
            Usuario = new List<Autenticaruser>()
            {new Autenticaruser{

                Id_Autenticaruser = "1203B",
                nombreUsuario = "Jessica",
                contraseña = "A#xvfrdv10"
        
            },

            new Autenticaruser{

                Id_Autenticaruser = "1204B",
                nombreUsuario = "William",
                contraseña = "SSDFdsf10$"
    
            },    
             new Autenticaruser{
                Id_Autenticaruser = "1205B",
                nombreUsuario = "Carlos",
                contraseña = "A#xvfrdv10"
            },
             new Autenticaruser{
                Id_Autenticaruser = "1206B",
                nombreUsuario = "Jacobo",
                contraseña = "A#xvfrdv10"
            }

            };
        }
        public IEnumerable<Autenticaruser> GetAll()
        {
            return Usuario;
        }
        public Autenticaruser App(Autenticaruser autenticacion)
        {
            autenticacion.Id_Autenticaruser = Usuario.Max(r => r.Id_Autenticaruser)+1;
            Usuario.Add(autenticacion);
            return autenticacion;
        }
        public Autenticaruser Update(Autenticaruser autenticacion)
        {
            var autenUser = Usuario.SingleOrDefault(p => p.Id_Autenticaruser == autenticacion.Id_Autenticaruser);
            if (autenUser!=null)
            {
                autenUser.nombreUsuario = autenticacion.nombreUsuario;
                autenUser.contraseña = autenticacion.contraseña;
            }
              return autenUser;
        }
        public void Delete(string idAutenticaruser)
        {
            var autenticacion = Usuario.SingleOrDefault(p => p.Id_Autenticaruser == idAutenticaruser); 
            if (autenticacion == null)
                return;
            Usuario.Remove(autenticacion);
        }
        public Autenticaruser Get(string idAutenticaruser)
        {
            return Usuario.SingleOrDefault(p => p.Id_Autenticaruser == idAutenticaruser);  
        }
  
    }   


        
}


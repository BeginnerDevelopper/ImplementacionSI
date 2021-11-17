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
            throw new NotImplementedException();
        }
        public Autenticaruser Update(Autenticaruser autenticacion)
        {
            throw new NotImplementedException();
        }
        public void Delete(string Id_Autenticaruser)
        {
            throw new NotImplementedException();
        }
        public Autenticaruser Get(string Id_Autenticaruser)
        {
            throw new NotImplementedException();
        }
  
    }   


        
}


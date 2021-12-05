using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modelar un gestor de usuarios en el sistema
    /// </sumary>
    public class AdministrarUsuarios: Autenticaruser
    {
        public int IdAdministrarusuarios{get;set;}
        public string Nombre{get;set;}
        public string Rol_de_usuario{get;set;}
        public string Estado{get;set;}
        public DateTime UltimoLogin {get;set;}
      
        
        
    }
}


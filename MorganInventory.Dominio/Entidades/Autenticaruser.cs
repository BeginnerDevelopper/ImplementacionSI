using System;

namespace MorganInventory.Dominio.Entidades
{
    /// <sumary>
    ///  Modela una persona en el sistema
    /// </sumary>
    public class Autenticaruser : Persona
    {
        public int Id_Autenticaruser {get;set;}
        public string nombreUsuario{get;set;}
        public string contraseña{get;set;}
        

    }
}
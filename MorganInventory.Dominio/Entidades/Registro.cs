using System;
using System.Collections.Generic;
namespace MorganInventory.Dominio
{
    public class Registro : Persona
    {
    public string Id_Registro{get;set;}
    public DateTime Fechanacimiento {get;set;}
    public long Nitcedula {get;set;}
    public string Cargo {get;set;}
    public string contraseña {get;set;}



    }
}
using System.Security.Permissions;
using System.IO.Pipes;
using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;
namespace Aplicacion.App.Persistencia
{
    public class RepositorioPersona: IRepositorioPersona
    {
        private readonly AppContext _appContext;
        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext;
        }

        //Metodo Adicionar Persona
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada=_appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            
            return personaAdicionada.Entity;
        }

        //Metodo Actualizar Persona
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var PersonaEncontrada=_appContext.Personas.FirstOrDefault(p=> p.Identificacion==persona.Identificacion);
            if(PersonaEncontrada!=null)
            {
                PersonaEncontrada.Identificacion=persona.Identificacion;
                PersonaEncontrada.Nombre=persona.Nombre;
                PersonaEncontrada.Apellido=persona.Apellido;
                _appContext.SaveChanges();
            }
            
            return PersonaEncontrada;
        }

        //Metodo traer persona
        Persona IRepositorioPersona.GetPersona(string IdentificacionPersona)
        {
            var personaEncontrada=_appContext.Personas.FirstOrDefault(p=> p.Identificacion==IdentificacionPersona);
            return personaEncontrada;
        }

        //Metodo traer todas las personas
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {  
            return _appContext.Personas;
        }

        //Metodo Eliminar Persona
         Persona IRepositorioPersona.DeletePersona(string identificacionPersona)
        {   var personaEncontrada=_appContext.Personas.FirstOrDefault(p=> p.Identificacion==identificacionPersona);
            if(personaEncontrada!=null)
            {
                _appContext.Personas.Remove(personaEncontrada);
                _appContext.SaveChanges();
            }
           
            return personaEncontrada;
        }
    }
}
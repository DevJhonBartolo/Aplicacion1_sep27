using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioPersona _repoPersona= new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("inicio de pruebas!");
            AddPersona();
            Console.WriteLine("ok");
        }

        private static void AddPersona()
        {
            var per=new Persona
            {
                Identificacion="1234",
                Nombre="Ana",
                Apellido="Arcos",
                Genero="Femenino",
                Estado='A'
            };
            _repoPersona.AddPersona(per);
        }
    }
}

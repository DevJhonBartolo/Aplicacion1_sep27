using System.Collections.Generic;
using System;
namespace Aplicacion.App.Dominio
{
    public class Reporte
    {
        public int Id{get;set;}
        public string Descripcion{get;set;}
        public List<TipoReporte> TiposReportes{get;set;}

    }
}
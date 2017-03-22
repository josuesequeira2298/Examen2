using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatitoSA
{
    public class ControladoraBD
    {
        Adaptador adaptador = new Adaptador();
        internal void agregarPersona(Entidad persona)
        {
            String consulta = "select * from Persona";
            adaptador.consultar(consulta);
        }
    }
}
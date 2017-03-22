using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatitoSA
{
    public class ControladoraPersona
    {
        ControladoraBD controladoraBD = new ControladoraBD();
        internal void agregarPersona(object[] objeto)
        {
            Entidad persona = new Entidad(objeto);

            controladoraBD.agregarPersona(persona);
        }
    }
}
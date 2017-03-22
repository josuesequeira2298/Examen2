using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatitoSA
{
    public class Entidad
    {
        String numReserva;
        String nombreCliente;
        String cedulaCliente;
        String fechaReserva;
        String tipoReserva;

        public Entidad(Object[] objeto)
        {
            this.numReserva = objeto[0].ToString();
            this.nombreCliente = objeto[1].ToString();
            this.cedulaCliente = objeto[2].ToString();
            this.fechaReserva = objeto[3].ToString();
            this.tipoReserva = objeto[4].ToString();
        }

        public String NumReserva
        {
            get { return numReserva; }
            set { numReserva = value; }
        }

        public String NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        public String CedulaCliente
        {
            get { return cedulaCliente; }
            set { cedulaCliente = value; }
        }
        public String FechaReserva
        {
            get { return fechaReserva; }
            set { fechaReserva = value; }
        }
        public String TipoReserva
        {
            get { return tipoReserva; }
            set { tipoReserva = value; }
        }
    }
}
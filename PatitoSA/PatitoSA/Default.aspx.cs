using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PatitoSA
{
    public partial class _Default : Page

    {
        ControladoraPersona controladora = new ControladoraPersona();
        Adaptador adaptador = new Adaptador();  
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void agregar(int numReservas, String nombreClientes, String CedulaClientes, String FechaReservas, String tipoReservas)
        {
          
                String consulta = "insert into Persona values(@num_reserva, @nombre_cliente, @cedula_cliente, @fecha_reserva, @tipo_reserva)";

                SqlCommand comando = new SqlCommand(consulta);

                SqlParameter numReserva = new SqlParameter("@num_reserva", SqlDbType.Int);
                numReserva.Value = numReservas;
                SqlParameter nombreCliente = new SqlParameter("@nombre_cliente", SqlDbType.VarChar, 30);
                nombreCliente.Value = nombreClientes;
                SqlParameter cedulaCliente = new SqlParameter("@cedula_cliente", SqlDbType.VarChar, 30);
                cedulaCliente.Value = CedulaClientes;
                SqlParameter fechaReserva = new SqlParameter("@fecha_reserva", SqlDbType.VarChar, 10);
                fechaReserva.Value = FechaReservas;
                SqlParameter tipoReserva = new SqlParameter("@tipo_reserva", SqlDbType.VarChar, 10);
                tipoReserva.Value = tipoReservas;

                comando.Parameters.Add(numReserva);
                comando.Parameters.Add(nombreCliente);
                comando.Parameters.Add(cedulaCliente);
                comando.Parameters.Add(fechaReserva);

                adaptador.insertar(comando);
            }
            
    protected void btnCargar_Click(object sender, EventArgs e)
        {
            String consulta = "select num_reserva, nombre_cliente, cedula_cliente, FechaReservas, tipoReservas";
            DataTable tabla = adaptador.consultar(consulta);

            grvReporte.DataSource = tabla;
            grvReporte.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Object[] objeto = new Object[4];
            objeto[0] = txtNum_Reserva.Text;
            objeto[1] = txtNombre_Cliente.Text;
            objeto[2] = txtCedula.Text;
            objeto[3] = cboTipoReserva.Text;

            controladora.agregarPersona(objeto);

        }


    }


}

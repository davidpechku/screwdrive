using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Integradora_in
{
    class ControlNuevoDiagnostico
    {
        FrameBD Diag = new FrameBD("localhost", 3308, "root", "admin", "int");

        public void agregarDiag(string claor, int clacli, int ideq,DateTimePicker fecharec, float cost, string posifalla) 
        {

            string sqldia = "INSERT INTO orden_servicio (ClaveOrden,clave_cliente, id_equipo, Fecha_Recepcion,Costo, posible_falla) VALUES ('"+claor+"'," + clacli + "," + ideq + ",'" + fecharec.Value.ToString("yyyy-MM-dd") + "'," + cost + ",'" + posifalla + "')";
            Diag.SQLIDU(sqldia);
        }

        public void MostrarDiag(string nom, DataGridView dat) 
        {
            string sqlmostdia = "SELECT orden_servicio.ClaveOrden, concat (Clientes.Nombre, ' ', Clientes.ApellidoP, ' ', Clientes.ApellidoM) as Cliente,Clientes.clave_cliente,Clientes.direccion,Clientes.Telefono, CONCAT(marcas.marca,' ', modelo.modelo) as Equipo, datos_equipo.id_equipo, orden_servicio.Fecha_Recepcion as 'Fecha de Entrada', orden_servicio.Costo, orden_servicio.posible_falla as 'Posible Falla'  FROM (((clientes INNER JOIN orden_servicio ON clientes.clave_cliente = orden_servicio.clave_cliente) INNER JOIN datos_equipo ON datos_equipo.id_equipo = orden_servicio.id_equipo) INNER JOIN marcas ON marcas.Id_marca=datos_equipo.Id_marca) INNER JOIN modelo ON modelo.id_model = datos_equipo.id_model WHERE orden_servicio.PasoADiagnostico ='0' AND orden_servicio.cancelado ='0' AND Clientes.nombre Like '" + nom + "%' ORDER BY Clientes.Nombre";
            Diag.SQLSEL(sqlmostdia);
            dat.DataSource = Diag.SQLSEL(sqlmostdia);
            dat.DataMember = "datos";
            dat.Columns["Cliente"].Width = 200;
            dat.Columns["Equipo"].Width = 150;
            dat.Columns["Posible Falla"].Width = 215;

            dat.Columns["direccion"].Visible = false;
            dat.Columns["clave_cliente"].Visible = false;
            dat.Columns["telefono"].Visible = false;
            dat.Columns["id_equipo"].Visible = false;
        }

        public string genera_clave(int l)
        {
            Random aleatorio = new Random();
            string res = "";
            string[] vals = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i <= l; i++)
            {
                res = res + vals[aleatorio.Next(vals.GetUpperBound(0) + 1)];
            }
            

            //MySqlConnection conn = new MySqlConnection("connection string"); 

            //conn.Open();
		
            //string sql = @"SELECT COUNT(ClaveOrden) as cla FROM orden_servicio"; 
            //MySqlCommand cmd = new MySqlCommand(sql, conn); 
            //cmd.Parameters.AddWithValue("@cla", l); 
            
            //string sqlc= "SELECT COUNT(ClaveOrden) FROM orden_servicio";
            //Diag.SQLSEL(sqlc);
            //string[] sqlu = new string[l];

            return res;

            
        }

        public void AddNewDiagnostico(string claor, DateTimePicker dat, string diag, float costo)
        {
            
            string sqlnewdiag = "INSERT INTO diagnostico(ClaveOrden,FechaDiagnostico,Descripcion,costo) VALUES ('" + claor + "','" + dat.Value.ToString("yyyy-MM-dd") + "','" + diag + "'," + costo + ")";
            Diag.SQLIDU(sqlnewdiag);
           
        }

        public void actualpaso(string claor) 
        {
            string act = "UPDATE orden_servicio SET PasoADiagnostico =1 WHERE ClaveOrden='" + claor + "'";
            Diag.SQLIDU(act);
        }

        public void cancelardiag(string claor)
        {
            string cancel = "UPDATE orden_servicio SET cancelado=1 WHERE ClaveOrden='" + claor + "'";
            Diag.SQLIDU(cancel);
        }

        public void mostrardiagnosticos(DataGridView dat) 
        {
            string mostdiagnostico = "SELECT * FROM mostrardiagnostico";
            Diag.SQLIDU(mostdiagnostico);
            dat.DataSource = Diag.SQLSEL(mostdiagnostico);
            dat.DataMember = "datos";

            dat.Columns["Cliente"].Width = 200;
            dat.Columns["Equipo"].Width = 150;
            

            //dat.Columns["direccion"].Visible = false;
            //dat.Columns["telefono"].Visible = false;
            //dat.Columns["clave_cliente"].Visible = false;
            //dat.Columns["telefono"].Visible = false;
            //dat.Columns["id_equipo"].Visible = false;
        }

        public void mostrarcancelados(DataGridView dat) 
        {
            string sqlcancel = "SELECT * FROM mostrarcancelados";
            Diag.SQLSEL(sqlcancel);
            dat.DataSource = Diag.SQLSEL(sqlcancel);
            dat.DataMember = "datos";
            dat.Columns["Cliente"].Width = 200;
            dat.Columns["Equipo"].Width = 150;

            dat.Columns["clave_cliente"].Visible = false;
           
            dat.Columns["id_equipo"].Visible = false;
        }

        public void equiposFinal(string claor, DateTimePicker dat, string inf) 
        {
            string sqlfin = "INSERT INTO reparacion (ClaveOrden,Fecha,Informe) VALUES ('" + claor + "','" + dat.Value.ToString("yyyy-MM-dd") + "','" + inf + "')";
            Diag.SQLIDU(sqlfin);
        }

        public void mostrarfinalizados(DataGridView dat)
        {
            string sqlcancel = "SELECT * FROM mostrarterminados";
            Diag.SQLSEL(sqlcancel);
            dat.DataSource = Diag.SQLSEL(sqlcancel);
            dat.DataMember = "datos";
        }

        public void actualpasoarep(string claor)
        {
            string act = "UPDATE diagnostico  SET PasoAReparacion = 1 WHERE ClaveOrden='" + claor + "'";
            Diag.SQLIDU(act);
        }

        public void entregarEquipo(string claor)
        {
            string entre = "UPDATE reparacion SET finalizado = 1 WHERE ClaveOrden='" + claor + "'";
            Diag.SQLIDU(entre);
        }

        public void mostrartermi(DataGridView dat) 
        {
            string termi = "SELECT * FROM mostrartermi";
            Diag.SQLSEL(termi);

           // dat.Columns["Cliente"].Width = 200;
            //dat.Columns["Equipo"].Width = 150;

            dat.DataSource = Diag.SQLSEL(termi);
            dat.DataMember = "datos";
        }
    }
}

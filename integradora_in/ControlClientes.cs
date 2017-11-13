using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora_in
{
    
    class ControlClientes
    {
        FrameBD Clientes = new FrameBD("localhost", 3308, "root", "admin", "int");


        public void AgregarCliente(string nom,string app,string apm,string tel,string dir,string loc,string mail)
        { 
            string sqlAdd = "INSERT INTO Clientes(Nombre,ApellidoP,ApellidoM,telefono,direccion,localidad,e_mail) VALUES('" + nom + "','"  + app + "','" + apm + "','" + tel + "','" + dir + "','" + loc + "','" + mail + "')";
            Clientes.SQLIDU(sqlAdd);
        }

        public void modificarCliente(string nom, string app, string apm, string tel, string dir, string loc, string mail, int clave)
        {
            string sqlUpdate = "UPDATE clientes  SET Nombre ='" + nom + "', Apellidop='" + app + "', ApellidoM='" + apm + "', telefono ='" + tel + "', direccion='" + dir + "', localidad='" + loc + "', e_mail='" + mail + "' WHERE Clave_cliente =" + clave + "";
            Clientes.SQLIDU(sqlUpdate);

        }

        public void mostrarClientes(string nom,DataGridView grid) 
        {
            string sqlMos = "SELECT clave_cliente as Clave, nombre as Nombre, apellidoP as 'Apellido Paterno', apellidoM as 'Apellido Materno',direccion as 'Direccion', telefono as 'Telefono', Localidad, e_mail as 'Correo' FROM clientes WHERE nombre Like '" + nom + "%'";
            grid.DataSource = Clientes.SQLSEL(sqlMos);
            grid.DataMember = "datos";
        }

        public void eliminarClientes(string clave) 
        {
            string sqlDelete = "DELETE FROM Clientes WHERE clave_cliente="+clave+"";
            Clientes.SQLIDU(sqlDelete);
        }

        

    }

        
}

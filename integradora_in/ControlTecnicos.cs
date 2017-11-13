using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora_in
{
    class ControlTecnicos
    {
        FrameBD tecni = new FrameBD("localhost", 3308, "root", "admin", "screw");

        public void registrarUsuario(string nom, string app, string tel, string corr, string local, string user, string pass, int idnive)
        {
            string sqlingreUser = "INSERT INTO usuarios(nombre, apellidos,telefono,correo, localidad,idnivel, user, pass ) VALUES('" + nom + "','" + app + "','" + tel + "','" + corr + "','" + local + "'," + idnive + ",'" + user + "','" +pass +"')";
            tecni.SQLIDU(sqlingreUser);
        }

        public void mostrarusuario(string nom,DataGridView grid)
        {
            string sqlMos = "SELECT  usuarios.id_tecnico as ID, CONCAT(usuarios.nombre ,' ',usuarios.apellidos) AS Nombre, usuarios.telefono as Teléfono, usuarios.correo as Correo, usuarios.localidad as Localidad,usuarios.user as 'Usuario', usuarios.pass ,tipo_user.nomnivel as 'Tipo de Usuario' FROM (tipo_user INNER JOIN usuarios ON usuarios.idnivel=tipo_user.idnivel) WHERE usuarios.nombre Like '" + nom + "%'";
            grid.DataSource = tecni.SQLSEL(sqlMos);
            grid.DataMember = "datos";
            
           grid.Columns["pass"].Visible = false;
           grid.Columns["Nombre"].Width = 235;
            
        }

        public void modificarUser(string nom, string app, string tel, string cor, string locu, int idnive, string user, string pass, int idtec) 
        {
            string sqlmodus = "UPDATE usuarios SET nombre ='" + nom + "', apellidos='" + app + "',telefono='"+tel+"',correo='"+cor+"',localidad='"+locu+"', idnivel =" + idnive +", user='" + user + "', pass='" + pass +"' WHERE id_tecnico=" + idtec + "";
            tecni.SQLIDU(sqlmodus);
        }

        public void deleteUser(string clave) 
        {
            string sqldeluser = "DELETE FROM usuarios WHERE id_tecnico='" + clave + "'";
            tecni.SQLIDU(sqldeluser);
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClaseBDCSharp
{

    
    class Auth
    {
        private string tabla;
        private string campousuario;
        private string campopass;
        private string valoruser;
        private string valorpass;
        private Boolean statususer;
        private Boolean statuspass;
             

        FrameBD TablaUser = new FrameBD("localhost", 3308, "root", "admin", "dvdclub");
        //Constructor de la clase
        public Auth(string tabla, string campousuario, string campopass,string valoruser,string valorpass)
        {
            this.tabla = tabla;
            this.campousuario = campousuario;
            this.campopass = campopass;
            this.valoruser = valoruser;
            this.valorpass = valorpass;

        }

        public void DatosUser()
        {

            string GetDatos = "SELECT " + campousuario + "," + campopass + 
                              " FROM " + tabla + 
                              " WHERE " + campousuario + "='" + valoruser + "'";

            MySqlDataReader Drus = TablaUser.SQLReader(GetDatos);

        if (Drus.HasRows== true)
            {
            ExisteUsuario=true;
                while (Drus.Read())
                {
                    string pass= Drus.GetString(1);

                    if (pass==valorpass)
                    
                        PassOk = true;
                    else
                        PassOk=false;

                    
                        


                }
         
            }

        else
            ExisteUsuario=false;


            

        }


        public Boolean ExisteUsuario
        {
            get
            {
                return this.statususer;
            }
            set
            {
                this.statususer =value;
            }
        }


        public Boolean PassOk
        {
            get
            {
                return this.statuspass;
            }
            set
            {
                this.statuspass = value;
            }
        }





    }

    


}

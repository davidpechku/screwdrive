using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora_in
{
    class ControlEquipos
    {
        FrameBD equi = new FrameBD("localhost", 3308, "root", "admin", "screw");

        public void mostrarequipos(string nom,DataGridView dat)
        {
            string sqlMost = "SELECT datos_equipo.id_equipo as Identificacion,tipo_equipo.id_tipo_equipo, tipo_equipo.tipo_de_equipo as 'Tipo de Equipo', marcas.id_marca,marcas.marca as Marca ,modelo.id_model,modelo.modelo as Modelo, datos_equipo.caracteristicas as Caracteristicas FROM ((marcas INNER JOIN datos_equipo ON marcas.Id_marca = datos_equipo.Id_marca) INNER JOIN modelo ON modelo.id_model=datos_equipo.id_model) INNER JOIN tipo_equipo ON tipo_equipo.id_tipo_equipo = datos_equipo.id_tipo_equipo WHERE marcas.marca Like '" + nom + "%'";
            dat.DataSource = equi.SQLSEL(sqlMost);
            dat.DataMember = "datos";
            dat.Columns["id_tipo_equipo"].Visible = false;
            dat.Columns["id_marca"].Visible = false;
            dat.Columns["id_model"].Visible = false;
            dat.Columns["caracteristicas"].Width = 472;
            dat.Columns["Identificacion"].Width = 80;
        }

        public void mostrarequipos2(string nom, DataGridView dat)
        {
            string sqlMost = "SELECT datos_equipo.id_equipo as Identificacion, tipo_equipo.id_tipo_equipo as 'Tipo de Equipo', marcas.id_marca,marcas.marca as Marca ,modelo.id_model,modelo.modelo as Modelo, datos_equipo.caracteristicas as Caracteristicas FROM ((marcas INNER JOIN datos_equipo ON marcas.Id_marca = datos_equipo.Id_marca) INNER JOIN modelo ON modelo.id_model=datos_equipo.id_model) INNER JOIN tipo_equipo ON tipo_equipo.id_tipo_equipo = datos_equipo.id_tipo_equipo WHERE marcas.marca Like '" + nom + "%'";
            dat.DataSource = equi.SQLSEL(sqlMost);
            dat.DataMember = "datos";
            dat.Columns["id_marca"].Visible = false;
            dat.Columns["id_model"].Visible = false;
            dat.Columns["caracteristicas"].Width = 401;
            dat.Columns["Identificacion"].Width = 80;

        }
        public void newmarca(string marca)
        {
            string sqladdmarc = "INSERT INTO marcas(marca) VALUES ('" + marca + "')";
            equi.SQLIDU(sqladdmarc);
        }

        public void LlenaMarca(ComboBox CmbMarca)
        {
            string marca = "SELECT *" +
                              " FROM marcas";

            CmbMarca.DataSource = equi.SQLCOMBO(marca);
            CmbMarca.ValueMember = "Id_marca";
            CmbMarca.DisplayMember = "marca";
        }

        public void LlenaModelo(ComboBox CmbMarca, ComboBox CmbModelo) 
        {
            string sqlm = "SELECT * FROM modelo WHERE id_marca = '" + CmbMarca.SelectedValue  + "'";
            CmbModelo.DisplayMember = "modelo";
            CmbModelo.ValueMember = "id_model";
            CmbModelo.DataSource = equi.SQLCOMBO(sqlm);
        }

        public void LlenaTipo(ComboBox CmbTipo)
        {
            string marca = "SELECT *" +
                              " FROM tipo_equipo";

            CmbTipo.DataSource = equi.SQLCOMBO(marca);
            CmbTipo.ValueMember = "id_tipo_equipo";
            CmbTipo.DisplayMember = "tipo_de_equipo";
        }

        public void newmodelo(string mod, int idmo)
        {
            string sqladdmodel = "INSERT INTO modelo(Id_marca,modelo) VALUES (" + idmo + ", '" + mod + "')";
            equi.SQLIDU(sqladdmodel);
        }

        public void nuevoequipo(int idmarc, int idmod, string carac, int tipe) 
        {
            string sqladdequi = "INSERT INTO datos_equipo(Id_marca,id_model,caracteristicas,id_tipo_equipo) VALUES ("+idmarc+","+idmod+",'"+carac+"',"+tipe+")";
            equi.SQLIDU(sqladdequi);
        }

        public void modificarequipo(int idmarc, int idmod, string carac,int idt, int clave) 
        {
            string sqlmodequi = "UPDATE datos_equipo SET Id_marca=" + idmarc + ", id_model=" + idmod + ", caracteristicas='" + carac + "',id_tipo_equipo="+idt+" WHERE id_equipo=" +clave+ "";
            equi.SQLIDU(sqlmodequi);
        }

        public void eliminarEquipo(int clave) 
        { 
            string delequi="DELETE FROM datos_equipo WHERE id_equipo="+clave+"";
            equi.SQLIDU(delequi);
        }
    }
}

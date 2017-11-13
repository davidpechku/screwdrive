using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora_in
{
    public partial class FrmRepara : Form
    {
       
        ControlNuevoDiagnostico newdia = new ControlNuevoDiagnostico();
   
        
        public FrmRepara()
        {
            //FiltroRepara();
            
            InitializeComponent();
        }

        private void FrmRepara_Load(object sender, EventArgs e)
        {
            TextClaveOrden.Text = newdia.genera_clave(6);
            TextClaveOrden.ReadOnly = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

       // private void BtnGuardar_Click(object sender, EventArgs e)
        //{
           //epa.sqlRepara(TxtClaveCliente.Tex,TxtIDequipo, TxtFRecepcion.Text, TxtCosto.Text, TextClaveOrden.Text,m
          // repa.sqlRepara = (TxtClaveCliente.Text, TxtIDequipo.Text, TxtFRecepcion.Text, TxtCosto.Text, TxtFDiagnostico.Text, TextClaveOrden.Text, TxtFDiagnostico.Text  TxtFDevolucion.Text, TxtMotivoFalla.Text, TxtDescripcion.Text);
                    
          //  Reparaciones ObjGuardar = new Reparaciones();
           // ObjGuardar.sqlRepara(
          
        //}

    

        private void BtnBuscaCli_Click(object sender, EventArgs e)
        {
            BuscaCliente.Visible = true;
            TxtBuscaClie.Focus();
            FiltrarClientes(); 
        }

        public void FiltrarClientes()
        {
            ControlClientes AuxCliente = new ControlClientes();
            AuxCliente.mostrarClientes(TxtBuscaClie.Text, DgvClientes);
            DgvClientes.RowHeadersVisible = false;
            DgvClientes.Columns[0].Visible = false;
            DgvClientes.Columns[2].Visible = false;
            DgvClientes.Columns[3].Visible = false;
            DgvClientes.Columns[4].Visible = false;
            DgvClientes.Columns[5].Visible = false;
            DgvClientes.Columns[1].Width = 200;
        }


        private void TxtBuscaClie_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtClaveCli.Text = Convert.ToString(DgvClientes[0, DgvClientes.CurrentCellAddress.Y].Value);
            TxtNomCliente.Text = Convert.ToString(DgvClientes[1, DgvClientes.CurrentCellAddress.Y].Value);
            TxtDirec.Text = Convert.ToString(DgvClientes[2, DgvClientes.CurrentCellAddress.Y].Value);
            TxtTel.Text = Convert.ToString(DgvClientes[3, DgvClientes.CurrentCellAddress.Y].Value);
            BuscaCliente.Visible = false;
            TxtBuscaClie.Clear();   
        }


        //equipos



        private void BtnBuscaEqui_Click(object sender, EventArgs e)
        {
            GroupEquipo.Visible = true;
            TxtBuscaEquipos.Focus();
            FiltrarEquipos(); 
        }

        public void FiltrarEquipos()
        {
            ControlEquipos eq = new ControlEquipos();
            eq.mostrarequipos(TxtBuscaEquipos.Text, DgvEquipos);
            DgvEquipos.RowHeadersVisible = false;
            DgvEquipos.Columns[0].Visible = false;
            DgvEquipos.Columns[4].Visible = false;
            DgvEquipos.Columns[2].Width = 300;
        }

        private void TxtBuscaEquipos_TextChanged(object sender, EventArgs e)
        {
            FiltrarEquipos();
        }

        private void DgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtClaveEquipo.Text = Convert.ToString(DgvEquipos[0, DgvEquipos.CurrentCellAddress.Y].Value);
            TxtEquipo.Text = Convert.ToString(DgvEquipos[2, DgvEquipos.CurrentCellAddress.Y].Value);
            GroupEquipo.Visible = false;
            TxtBuscaEquipos.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmControlClientes cli = new FrmControlClientes();
            cli.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmEquipos equ = new FrmEquipos();
            equ.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            newdia.agregarDiag(TextClaveOrden.Text,Convert.ToInt32(TxtClaveCli.Text), Convert.ToInt32(TxtClaveEquipo.Text), DtpFechaDiagnostico, Convert.ToInt32(TxtCosto.Text), TxtDescripcion.Text);
            MessageBox.Show("Datos registrados con exito");

            FrmControl con = new FrmControl();
            con.Show();
            this.Hide();
        }

        private void DtpFechaDiagnostico_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtTecnico_TextChanged(object sender, EventArgs e)
        {

            

            //TxtTecnico.Text= rep
        }

        public void DatosAccesoo(string user)
        {
           // this.LblIng.Text = user;
            
        }



      
    }
}

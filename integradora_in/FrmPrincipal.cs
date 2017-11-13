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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            gb1.Visible = true;
            gb2.Visible = true;
            gb3.Visible = false;
            gb4.Visible = false;

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
        } 

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmControlClientes cli = new FrmControlClientes();
            cli.Show();
        }

        private void BtnAddCliente_Click(object sender, EventArgs e)
        {
            FrmControlClientes rep = new FrmControlClientes();
            rep.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmControlClientes cli = new FrmControlClientes();
            cli.Show();
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmControlClientes cli2 = new FrmControlClientes();
            cli2.Show();
        }

        private void herramientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void DatosAcceso(string user, string nivel)
        {
            this.LblUsuario.Text = user;
            this.LblTipo.Text = nivel;
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipos equi = new FrmEquipos();
            equi.Show();
            
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTecnicos tecni = new FrmTecnicos();
            tecni.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRepara rep = new FrmRepara();
            rep.Show();
        }

        private void BtnVerEqui_Click(object sender, EventArgs e)
        {
            FrmEquipos eq = new FrmEquipos();
            eq.Show();
        }

        private void BtnVerTec_Click(object sender, EventArgs e)
        {
            FrmTecnicos tec = new FrmTecnicos();
            tec.Show();
        }

        private void BtnVerCli_Click(object sender, EventArgs e)
        {
            FrmControlClientes clo = new FrmControlClientes();
            clo.Show();
        }

        private void LblTipo_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmControl con = new FrmControl();
            con.tabControl1.SelectedIndex = 1;
            con.Show();      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmControl con = new FrmControl();
            con.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmControl con = new FrmControl();
            con.tabControl1.SelectedIndex = 2;
            con.Show(); 
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                gb1.Visible = true;
                gb2.Visible = true;
                gb3.Visible = false;
                gb4.Visible = false;
            }
            else
            {
                gb1.Visible = false;
                gb2.Visible = false;
                gb3.Visible = true;
                gb4.Visible = true;
            }
        }

      

        
    }
}

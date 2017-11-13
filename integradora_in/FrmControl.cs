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
    public partial class FrmControl : Form
    {
        ControlNuevoDiagnostico newdiag = new ControlNuevoDiagnostico();
        FrmDiagnostico diag = new FrmDiagnostico();
        FrmFinalizar fin = new FrmFinalizar();

        public FrmControl()
        {
            InitializeComponent();
            newdiag.MostrarDiag(TxtBusc.Text,DgvRecibidos);

        }

        private void BtnAgreg_Click(object sender, EventArgs e)
        {
            string val =Convert.ToString(DgvRecibidos[0, DgvRecibidos.CurrentCellAddress.Y].Value);
            if (MessageBox.Show("¿Está seguro que desea cancelarlo?", "Estimado usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                  
                 
                  newdiag.cancelardiag(val);
                  newdiag.MostrarDiag(TxtBusc.Text, DgvRecibidos);
        }

        private void FrmControl_Load(object sender, EventArgs e)
        {
            FiltroDiag2();
            this.tabControl1.TabPages.Remove(this.tabPage4);
            FiltroDiag();
            newdiag.mostrarfinalizados(DgvFinal);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(this.tabPage4);
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Add(this.tabPage4);
            tabControl1.SelectedIndex = 3;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(this.tabPage4);
        }

        private void BtnPasarADiagnosticados_Click(object sender, EventArgs e)
        {
            diag.TextClaveOrden.Text = Convert.ToString(DgvRecibidos[0, DgvRecibidos.CurrentCellAddress.Y].Value);
            diag.TxtNomCliente1.Text = Convert.ToString(DgvRecibidos[1, DgvRecibidos.CurrentCellAddress.Y].Value);
            diag.TxtClaveCli1.Text = Convert.ToString(DgvRecibidos[2, DgvRecibidos.CurrentCellAddress.Y].Value);
            diag.TxtDirec1.Text = Convert.ToString(DgvRecibidos[3, DgvRecibidos.CurrentCellAddress.Y].Value);
            diag.TxtTel1.Text = Convert.ToString(DgvRecibidos[4, DgvRecibidos.CurrentCellAddress.Y].Value);
            diag.TxtEquipo.Text = Convert.ToString(DgvRecibidos[5, DgvRecibidos.CurrentCellAddress.Y].Value);
            diag.TxtClaveEquipo.Text = Convert.ToString(DgvRecibidos[6, DgvRecibidos.CurrentCellAddress.Y].Value);
            diag.TxtDiagnostico.Focus();
            diag.Show();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            string val = Convert.ToString(DgvDiagnosticados[0, DgvDiagnosticados.CurrentCellAddress.Y].Value);

            fin.TextClaveOrden.Text = Convert.ToString(DgvDiagnosticados[0, DgvDiagnosticados.CurrentCellAddress.Y].Value);
            fin.TxtNomCliente.Text = Convert.ToString(DgvDiagnosticados[1, DgvDiagnosticados.CurrentCellAddress.Y].Value);
            fin.TxtClaveCli.Text = Convert.ToString(DgvDiagnosticados[2, DgvDiagnosticados.CurrentCellAddress.Y].Value);
            fin.TxtDirec.Text = Convert.ToString(DgvDiagnosticados[3, DgvDiagnosticados.CurrentCellAddress.Y].Value);
            fin.TxtTel.Text = Convert.ToString(DgvDiagnosticados[4, DgvDiagnosticados.CurrentCellAddress.Y].Value);
            fin.TxtEquipo.Text = Convert.ToString(DgvDiagnosticados[5, DgvDiagnosticados.CurrentCellAddress.Y].Value);
            fin.TxtClaveEquipo.Text = Convert.ToString(DgvDiagnosticados[6, DgvDiagnosticados.CurrentCellAddress.Y].Value);
            fin.TxtInf.Focus();
            newdiag.actualpasoarep(val);
            fin.Show();
        }

        private void DgvRecibidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVerCa_Click(object sender, EventArgs e)
        {
            FrmHerramientas herra = new FrmHerramientas();
            herra.Show();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            FrmHerramientas herra = new FrmHerramientas();
            herra.tabControl1.SelectedIndex = 1;
            herra.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string val = Convert.ToString(DgvFinal[0, DgvFinal.CurrentCellAddress.Y].Value);

            if (MessageBox.Show("¿Está seguro que desea entregar el equipo?", "Estimado usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                     newdiag.entregarEquipo(val);
                     newdiag.mostrarfinalizados(DgvFinal);
        }

        private void TxtBusc_TextChanged(object sender, EventArgs e)
        {
            FiltroDiag();
        }

        public void FiltroDiag()
        {
            newdiag.MostrarDiag(TxtBusc.Text, DgvRecibidos);
        }
         public void FiltroDiag2()
        {
            newdiag.mostrardiagnosticos(DgvDiagnosticados);
        }
        

    }
}

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
    public partial class FrmDiagnostico : Form
    {
        ControlNuevoDiagnostico diag = new ControlNuevoDiagnostico();
        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        private void BtnGuardaDiagnos_Click(object sender, EventArgs e)
        {
            
            FrmControl con = new FrmControl();
            
            
            diag.actualpasoarep(TextClaveOrden.Text);
            diag.AddNewDiagnostico(TextClaveOrden.Text, DtpDiagnos, TxtDiagnostico.Text, Convert.ToSingle(TxtCostos.Text));
            diag.actualpaso(TextClaveOrden.Text);


            MessageBox.Show("Datos Registrados con exito");

            diag.mostrardiagnosticos(con.DgvDiagnosticados);
            con.tabControl1.SelectedIndex = 1;

            
            con.Show();
            this.Hide();
        }

        private void FrmDiagnostico_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

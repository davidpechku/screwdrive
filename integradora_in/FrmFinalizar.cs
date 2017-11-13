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
    public partial class FrmFinalizar : Form
    {
        ControlNuevoDiagnostico diag = new ControlNuevoDiagnostico();
        public FrmFinalizar()
        {
            InitializeComponent();
        }

        private void FrmFinalizar_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {   
            FrmControl con = new FrmControl();
            diag.equiposFinal(TextClaveOrden.Text, DtpFechafINAL, TxtInf.Text);
            //diag.actualpaso(TextClaveOrden.Text);
            MessageBox.Show("Datos Registrados con exito");
           // diag.mostrarfin(con.DgvFinal);
            con.tabControl1.SelectedIndex = 2;
            
            con.Show();
            this.Hide();
        }
    }
}

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
    public partial class FrmAgregaMarca : Form
    {
        ControlEquipos equipo = new ControlEquipos();
        public FrmAgregaMarca()
        {
            InitializeComponent();
        }

        private void BtnGuaMarca_Click(object sender, EventArgs e)
        {
            equipo.newmarca(TxtMarca.Text);
            FrmEquipos equi = new FrmEquipos();
            equi.Show();
            this.Hide();
        }

        private void FrmAgregaMarca_Load(object sender, EventArgs e)
        {
            equipo.LlenaMarca(CmbMarca);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equipo.newmodelo(TxtModelo.Text,Convert.ToInt32(CmbMarca.SelectedValue));
            MessageBox.Show("Datos registrados exitosamente");
            FrmEquipos eq = new FrmEquipos();
            eq.tabControl1.SelectedIndex = 1;
            eq.BtnGuardaModificar.Visible = false;
            eq.Show();
            this.Hide();
        }

        private void BtnGuaMarca_Click_1(object sender, EventArgs e)
        {
            equipo.newmarca(TxtMarca.Text);
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEquipos eq = new FrmEquipos();
            eq.Show();
            this.Hide();
        }

        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

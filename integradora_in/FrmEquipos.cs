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
    public partial class FrmEquipos : Form
    {

        FrameBD conectequi = new FrameBD("192.168.60.2", 3306, "screw", "screw12345", "screw");
        ControlEquipos equifil = new ControlEquipos();
        public FrmEquipos()
        {
            InitializeComponent();
        
           
        }

        private void LlenaComboMarca()
        {
            equifil.LlenaMarca(CmbMarca);
        }

        private void LlenaModelos()
        
        {
            equifil.LlenaModelo(CmbMarca, CmbModelo);
           
        }

        private void LlenaTipos()
        {
            equifil.LlenaTipo(CmbTipo);

        }

        private void FiltroEquipos() 
        {
            equifil.mostrarequipos(TxtBuscaaEquipos.Text,DgvEquipos);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BtnGuardaModificar.Visible = false;
            BtnAgregarEquipo.Visible = true;
            tabControl1.SelectedIndex = 1;
        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            FiltroEquipos();
            LlenaComboMarca();
            LlenaModelos();
            LlenaTipos();
            
        }

        private void BtnAgregarEquipo_Click(object sender, EventArgs e)
        {
            equifil.nuevoequipo(Convert.ToInt32(CmbMarca.SelectedValue), Convert.ToInt32(CmbModelo.SelectedValue), TxtCaracteristicas.Text, Convert.ToInt32(CmbTipo.SelectedValue));
            MessageBox.Show("Guardado");
            FiltroEquipos();
            tabControl1.SelectedIndex=0;

        }

        private void BtnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmAgregaMarca agreg = new FrmAgregaMarca();
            agreg.Show();
            this.Hide();
            
        }

        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnNewModelo_Click(object sender, EventArgs e)
        {
            FrmAgregaMarca agreg = new FrmAgregaMarca();
            agreg.tabControl1.SelectedIndex=1;
            agreg.Show();
            this.Hide();
            
        }

        private void TxtBuscaEquipo_TextChanged(object sender, EventArgs e)
        {
            FiltroEquipos();
        }

        private void CmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenaModelos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LlenaComboMarca();
           
            CmbTipo.SelectedValue = DgvEquipos["id_tipo_equipo", DgvEquipos.CurrentCellAddress.Y].Value;
            CmbMarca.SelectedValue = DgvEquipos["id_marca", DgvEquipos.CurrentCellAddress.Y].Value;
            LlenaModelos();
           // CmbModelo.SelectedValue = DgvEquipos["id_model", DgvEquipos.CurrentCellAddress.Y].Value;
            TxtCaracteristicas.Text = Convert.ToString(DgvEquipos["caracteristicas", DgvEquipos.CurrentCellAddress.Y].Value);
            BtnAgregarEquipo.Visible = false;
            BtnGuardaModificar.Visible = true;
            tabControl1.SelectedIndex = 1;
        }

        private void BtnGuardaModificar_Click(object sender, EventArgs e)
        {
            int valcla=Convert.ToInt32(DgvEquipos[0, DgvEquipos.CurrentCellAddress.Y].Value);
            equifil.modificarequipo(Convert.ToInt32(CmbMarca.SelectedValue),Convert.ToInt32(CmbModelo.SelectedValue), TxtCaracteristicas.Text,Convert.ToInt32(CmbTipo.SelectedValue), valcla);
            TxtCaracteristicas.Clear();
            FiltroEquipos();
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valcla = Convert.ToInt32(DgvEquipos[0, DgvEquipos.CurrentCellAddress.Y].Value);
            if (MessageBox.Show("¿Está seguro que desea eliminar?", "Estimado Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                equifil.eliminarEquipo(valcla);
                FiltroEquipos();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

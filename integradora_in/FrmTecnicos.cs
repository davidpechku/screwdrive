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
    public partial class FrmTecnicos : Form
    {
        ControlTecnicos tec = new ControlTecnicos();
        FrameBD conex = new FrameBD("localhost", 3308, "root", "admin", "screw");
        public FrmTecnicos()
        {
            InitializeComponent();
            
        }

        private void LlenaComboUsers()
        {
            string usuario = "SELECT *" +
                              " FROM tipo_user";

            CmbTipoUser.DataSource = conex.SQLCOMBO(usuario);
            CmbTipoUser.ValueMember = "idnivel";
            CmbTipoUser.DisplayMember = "nomnivel";
        }

        private void FiltroUsers()
        {
            tec.mostrarusuario(TxtBusca.Text, DgvTecnicos);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BtnModi.Visible = false;
            BtnGuar.Visible = true;
            lbl.Visible = true;
            TxtApp.Visible = true;
            TxtName.Clear();
            TxtApp.Clear();
            TxtTel.Clear();
            TxtLoc.Clear();
            TxtPass.Clear();
            TxtCorreo.Clear();
            TxtUser.Clear();
            LlenaComboUsers();
            tabControl1.SelectedIndex = 1;
        }

        private void FrmTecnicos_Load(object sender, EventArgs e)
        {
            LlenaComboUsers();
            FiltroUsers();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string val = Convert.ToString(DgvTecnicos[0, DgvTecnicos.CurrentCellAddress.Y].Value);

            if (MessageBox.Show("Está seguro que desea eliminar","Estimado usuario",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                tec.deleteUser(val);
                FiltroUsers();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BtnGuar.Visible = false;
            lbl.Visible = false;
            TxtApp.Visible = false;
            TxtPass.UseSystemPasswordChar = true;
            TxtName.Text = Convert.ToString(DgvTecnicos[1, DgvTecnicos.CurrentCellAddress.Y].Value);
            //TxtApp.Text = Convert.ToString(DgvTecnicos[2, DgvTecnicos.CurrentCellAddress.Y].Value);
            TxtTel.Text = Convert.ToString(DgvTecnicos[2, DgvTecnicos.CurrentCellAddress.Y].Value);
            TxtCorreo.Text = Convert.ToString(DgvTecnicos[3, DgvTecnicos.CurrentCellAddress.Y].Value);
            TxtLoc.Text = Convert.ToString(DgvTecnicos[4, DgvTecnicos.CurrentCellAddress.Y].Value);
            TxtUser.Text = Convert.ToString(DgvTecnicos[5, DgvTecnicos.CurrentCellAddress.Y].Value);
            TxtPass.Text = Convert.ToString(DgvTecnicos[6, DgvTecnicos.CurrentCellAddress.Y].Value);
            CmbTipoUser.SelectedItem=  DgvTecnicos["Tipo de Usuario", DgvTecnicos.CurrentCellAddress.Y].Value;

            
          
            tabControl1.SelectedIndex = 1;
            
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private string valorradio(RadioButton rdoBtn, RadioButton rdobtnmu)
        {
            string valor = "";
            if (rdoBtn.Checked)
            {
                valor = rdoBtn.Text;
            }
            else
            {
                valor = rdobtnmu.Text;
            }

            return valor;

        }

        private void BtnMod_Click(object sender, EventArgs e)
        {

            tec.registrarUsuario(TxtName.Text, TxtApp.Text, TxtTel.Text, TxtCorreo.Text, TxtLoc.Text, TxtUser.Text, TxtPass.Text, Convert.ToInt32(CmbTipoUser.SelectedValue));

            MessageBox.Show("Datos guardados");
            FiltroUsers();
            TxtName.Clear();
            TxtApp.Clear();
            TxtTel.Clear();
            TxtLoc.Clear();
            TxtPass.Clear();
            TxtCorreo.Clear();
            TxtUser.Clear();
            tabControl1.SelectedIndex = 0;

        }

        private void CbxMosOcu_CheckedChanged(object sender, EventArgs e)
        {
            string text = TxtPass.Text;
            if (CbxMosOcu.Checked)
            {
                TxtPass.UseSystemPasswordChar = false;
                TxtPass.Text = text;

            }
            else
            {
                TxtPass.UseSystemPasswordChar = true;
                TxtPass.Text = text;
            }
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            FiltroUsers();
        }

        private void BtnModi_Click(object sender, EventArgs e)
        {
            int tecn = Convert.ToInt32(DgvTecnicos[0, DgvTecnicos.CurrentCellAddress.Y].Value);
            tec.modificarUser(TxtName.Text, TxtApp.Text, TxtTel.Text, TxtCorreo.Text, TxtLoc.Text, Convert.ToInt32(CmbTipoUser.SelectedValue), TxtUser.Text,TxtPass.Text, tecn);
            FiltroUsers();
            TxtName.Clear();
            TxtApp.Clear();
            TxtTel.Clear();
            TxtLoc.Clear();
            TxtPass.Clear();
            TxtCorreo.Clear();
            TxtUser.Clear();
            tabControl1.SelectedIndex = 0;
        }
    }
}

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
    public partial class FrmRegistro : Form
    {
        FrameBD conex = new FrameBD("192.168.60.2", 3306, "screw", "screw12345", "screw");
        ControlTecnicos ClaseReg = new ControlTecnicos();

        public string cnt1;

        

        public FrmRegistro()
        {
            InitializeComponent();
           // TxtName.Text = cnt1;
        }

       

        private void LlenaComboUsers()
        {
            string usuario = "SELECT *" +
                              " FROM nivel";

            CmbTipoUser.DataSource = conex.SQLCOMBO(usuario);
            CmbTipoUser.ValueMember = "idnivel";
            CmbTipoUser.DisplayMember = "nomnivel";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string radiose = "";
            radiose = Convert.ToString(valorradio(RbtHombre, RbtMujer));

           // ClaseReg.registrarUsuario(TxtName.Text, TxtApp.Text, TxtApm.Text,TxtNumTel.Text,TxtLocalidad.Text,TxtDireccion.Text, TxtNomUser.Text, TxtUser.Text,Convert.ToInt32(CmbTipoUser.SelectedValue),radiose);

            MessageBox.Show("Ahora ya estas registrado, te redirigiremos a la ventana de iniciar sesion " );
            FrmIngresar ig = new FrmIngresar();
            ig.Show();
            this.Hide();       
        }     

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            LlenaComboUsers();
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

        private void CmbTipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RbtMujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmbTipoUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

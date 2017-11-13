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
    public partial class FrmIngresar : Form
    {
        public FrmIngresar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auth verificar = new Auth("usuarios", "user", "pass", TxtUser.Text, TxtPass.Text);
            verificar.DatosUser();



            if (verificar.ExisteUsuario == true)
            {
                if (verificar.PassOk == true)
                {
               
                    MessageBox.Show("Bienvenido a Screwdriver ");
                    FrmPrincipal form = new FrmPrincipal();
                    FrmRepara fr = new FrmRepara();

                    form.DatosAcceso(verificar.QueUsuarioAccede, verificar.QueNivelUsuarioAccede);
                    fr.DatosAccesoo(verificar.QueUsuarioAccede);
                    form.Show();
                    this.Hide();
                }

                else
                    MessageBox.Show("La contraseña es incorrecta");

            }

            else
                MessageBox.Show("El usuario no existe");

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmIngresar_Load(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
          
           

        }

        private void button1_Enter(object sender, EventArgs e)
        {
          
        }

        private void CbxMosPass_CheckedChanged(object sender, EventArgs e)
        {
            string text = TxtPass.Text;
            if (CbxMosPass.Checked)
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

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        } 
    }
}

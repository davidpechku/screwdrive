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
    public partial class FrmControlClientes : Form
    {
        FrameBD client = new FrameBD("192.168.60.2", 3306, "screw", "screw12345", "screw");
        ControlClientes ClaseClie = new ControlClientes();
        public FrmControlClientes()
        {
            InitializeComponent();
            

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Text = "Agregar";
            tabControl1.SelectedIndex = 1;
            BtnGuardarCliente.Visible = true;
            BtnModificarC.Visible = false;
           // TxtClave.ReadOnly = true;
        }

        private void Filtroclientes()
        {
            ClaseClie.mostrarClientes(TxtBuscaCli.Text, DgvCliente);   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardarCliente_Click_1(object sender, EventArgs e)
        {
        

         //   ClaseClie.AgregarCliente(TxtNombre.Text, TxtApellidos.Text, TxtApeM.Text, TxtTelefono.Text, TxtDireccion.Text, TxtLocal.Text, TxtEmail.Text);
            MessageBox.Show("Agregado");
            Filtroclientes();
            tabControl1.SelectedIndex = 0;

            TxtNombre.Clear();
            TxtApellidos.Clear();
           // TxtApeM.Clear();
          //  TxtDireccion.Clear();
            TxtEmail.Clear();
          //  TxtLocal.Clear();
            TxtTelefono.Clear();
            
        }

        private void FrmControlClientes_Load(object sender, EventArgs e)
        {
            Filtroclientes();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        //  TxtClave.Text = Convert.ToString(DgvCliente["Clave", DgvCliente.CurrentCellAddress.Y].Value);
            TxtNombre.Text = Convert.ToString(DgvCliente[1, DgvCliente.CurrentCellAddress.Y].Value);
            TxtApellidos.Text = Convert.ToString(DgvCliente[2, DgvCliente.CurrentCellAddress.Y].Value);
           // TxtApeM.Text = Convert.ToString(DgvCliente[3, DgvCliente.CurrentCellAddress.Y].Value);
            TxtTelefono.Text = Convert.ToString(DgvCliente[4, DgvCliente.CurrentCellAddress.Y].Value);
            //TxtDireccion.Text = Convert.ToString(DgvCliente[5, DgvCliente.CurrentCellAddress.Y].Value);
            //TxtLocal.Text = Convert.ToString(DgvCliente[6, DgvCliente.CurrentCellAddress.Y].Value);
            TxtEmail.Text = Convert.ToString(DgvCliente[7, DgvCliente.CurrentCellAddress.Y].Value);
        // TxtClave.ReadOnly = true;
            tabControl1.SelectedIndex = 1;
            tabControl1.TabPages[1].Text = "Modificar";

            BtnGuardarCliente.Visible = false;
            BtnModificarC.Visible = true;

            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string val = Convert.ToString(DgvCliente[0, DgvCliente.CurrentCellAddress.Y].Value);
            if (MessageBox.Show("¿Está seguro que desea eliminar?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                ClaseClie.eliminarClientes(val);


            Filtroclientes();
        }

        private void BtnBuscaCli_Click(object sender, EventArgs e)
        {

        }

        private void TxtBuscaCli_TextChanged(object sender, EventArgs e)
        {
            Filtroclientes();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificarC_Click(object sender, EventArgs e)
        {
            //ClaseClie.modificarCliente(TxtNombre.Text, TxtApellidos.Text, TxtApeM.Text, TxtTelefono.Text, TxtDireccion.Text, TxtLocal.Text, TxtEmail.Text, (Convert.ToInt32(TxtClave.Text)));
            MessageBox.Show("Datos actualizados correctamente", "Estimado usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtNombre.Clear();
            TxtApellidos.Clear();
            //TxtApeM.Clear();
            //TxtDireccion.Clear();
            TxtEmail.Clear();
           // TxtLocal.Clear();
            TxtTelefono.Clear();
            tabControl1.SelectedIndex = 0;

            Filtroclientes();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           // TxtClave.ReadOnly = true;
            BtnModificar.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}

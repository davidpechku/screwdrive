namespace Integradora_in
{
    partial class FrmControlClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlClientes));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnModificarC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.BtnGuardarCliente = new System.Windows.Forms.Button();
            this.TPrincipal = new System.Windows.Forms.TabPage();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.Búsqueda = new System.Windows.Forms.GroupBox();
            this.BtnBuscaCli = new System.Windows.Forms.Button();
            this.TxtBuscaCli = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.Búsqueda.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.BtnModificarC);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.BtnGuardarCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTelefono);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(38, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 179);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(150, 26);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(267, 26);
            this.TxtTelefono.TabIndex = 5;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(150, 72);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(267, 26);
            this.TxtEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teléfono";
            // 
            // BtnModificarC
            // 
            this.BtnModificarC.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarC.Image")));
            this.BtnModificarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarC.Location = new System.Drawing.Point(542, 360);
            this.BtnModificarC.Name = "BtnModificarC";
            this.BtnModificarC.Size = new System.Drawing.Size(85, 48);
            this.BtnModificarC.TabIndex = 7;
            this.BtnModificarC.Text = "Guardar";
            this.BtnModificarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarC.UseVisualStyleBackColor = true;
            this.BtnModificarC.Click += new System.EventHandler(this.BtnModificarC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtApellidos);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 190);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombre.Location = new System.Drawing.Point(27, 76);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(68, 18);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(150, 76);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(267, 26);
            this.TxtNombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellidos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(150, 115);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(267, 26);
            this.TxtApellidos.TabIndex = 3;
            // 
            // BtnGuardarCliente
            // 
            this.BtnGuardarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardarCliente.AutoEllipsis = true;
            this.BtnGuardarCliente.BackColor = System.Drawing.Color.Silver;
            this.BtnGuardarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarCliente.Image")));
            this.BtnGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarCliente.Location = new System.Drawing.Point(542, 312);
            this.BtnGuardarCliente.Name = "BtnGuardarCliente";
            this.BtnGuardarCliente.Size = new System.Drawing.Size(85, 49);
            this.BtnGuardarCliente.TabIndex = 6;
            this.BtnGuardarCliente.Text = "Guardar";
            this.BtnGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarCliente.UseVisualStyleBackColor = true;
            this.BtnGuardarCliente.Click += new System.EventHandler(this.BtnGuardarCliente_Click_1);
            // 
            // TPrincipal
            // 
            this.TPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TPrincipal.BackgroundImage")));
            this.TPrincipal.Controls.Add(this.BtnAgregar);
            this.TPrincipal.Controls.Add(this.BtnModificar);
            this.TPrincipal.Controls.Add(this.BtnEliminar);
            this.TPrincipal.Controls.Add(this.DgvCliente);
            this.TPrincipal.Controls.Add(this.Búsqueda);
            this.TPrincipal.Location = new System.Drawing.Point(4, 26);
            this.TPrincipal.Name = "TPrincipal";
            this.TPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.TPrincipal.Size = new System.Drawing.Size(677, 449);
            this.TPrincipal.TabIndex = 0;
            this.TPrincipal.Text = "Principal";
            this.TPrincipal.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.Location = new System.Drawing.Point(110, 394);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 40);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.Location = new System.Drawing.Point(303, 394);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(107, 40);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.Location = new System.Drawing.Point(503, 394);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(102, 40);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToAddRows = false;
            this.DgvCliente.AllowUserToDeleteRows = false;
            this.DgvCliente.BackgroundColor = System.Drawing.Color.Black;
            this.DgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.GridColor = System.Drawing.Color.Black;
            this.DgvCliente.Location = new System.Drawing.Point(28, 126);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.ReadOnly = true;
            this.DgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCliente.RowHeadersVisible = false;
            this.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCliente.Size = new System.Drawing.Size(635, 255);
            this.DgvCliente.TabIndex = 1;
            this.DgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Búsqueda
            // 
            this.Búsqueda.Controls.Add(this.BtnBuscaCli);
            this.Búsqueda.Controls.Add(this.TxtBuscaCli);
            this.Búsqueda.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Búsqueda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Búsqueda.Location = new System.Drawing.Point(51, 27);
            this.Búsqueda.Name = "Búsqueda";
            this.Búsqueda.Size = new System.Drawing.Size(594, 77);
            this.Búsqueda.TabIndex = 0;
            this.Búsqueda.TabStop = false;
            this.Búsqueda.Text = "Búsqueda";
            // 
            // BtnBuscaCli
            // 
            this.BtnBuscaCli.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscaCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscaCli.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscaCli.Image")));
            this.BtnBuscaCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscaCli.Location = new System.Drawing.Point(467, 24);
            this.BtnBuscaCli.Name = "BtnBuscaCli";
            this.BtnBuscaCli.Size = new System.Drawing.Size(105, 37);
            this.BtnBuscaCli.TabIndex = 1;
            this.BtnBuscaCli.Text = "Buscar";
            this.BtnBuscaCli.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBuscaCli.UseVisualStyleBackColor = true;
            this.BtnBuscaCli.Click += new System.EventHandler(this.BtnBuscaCli_Click);
            // 
            // TxtBuscaCli
            // 
            this.TxtBuscaCli.Location = new System.Drawing.Point(28, 29);
            this.TxtBuscaCli.Name = "TxtBuscaCli";
            this.TxtBuscaCli.Size = new System.Drawing.Size(407, 25);
            this.TxtBuscaCli.TabIndex = 0;
            this.TxtBuscaCli.TextChanged += new System.EventHandler(this.TxtBuscaCli_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPrincipal);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(31, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 479);
            this.tabControl1.TabIndex = 2;
            // 
            // FrmControlClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmControlClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Clientes";
            this.Load += new System.EventHandler(this.FrmControlClientes_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.Búsqueda.ResumeLayout(false);
            this.Búsqueda.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button BtnGuardarCliente;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TabPage TPrincipal;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox Búsqueda;
        private System.Windows.Forms.Button BtnBuscaCli;
        private System.Windows.Forms.TextBox TxtBuscaCli;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button BtnModificarC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvCliente;


    }
}
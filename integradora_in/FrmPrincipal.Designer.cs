namespace Integradora_in
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblTipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnVerCli = new System.Windows.Forms.Button();
            this.BtnVerEqui = new System.Windows.Forms.Button();
            this.BtnVerTec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb4 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb4.SuspendLayout();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1116, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuario,
            this.toolStripStatusLabel2,
            this.LblTipo,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1367, 27);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripStatusLabel1.Text = "Ingresó: ";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // LblTipo
            // 
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(0, 22);
            this.LblTipo.Click += new System.EventHandler(this.LblTipo_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 22);
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnVerCli
            // 
            this.BtnVerCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerCli.BackgroundImage")));
            this.BtnVerCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerCli.Location = new System.Drawing.Point(550, 61);
            this.BtnVerCli.Name = "BtnVerCli";
            this.BtnVerCli.Size = new System.Drawing.Size(207, 110);
            this.BtnVerCli.TabIndex = 7;
            this.BtnVerCli.UseVisualStyleBackColor = true;
            this.BtnVerCli.Click += new System.EventHandler(this.BtnVerCli_Click);
            // 
            // BtnVerEqui
            // 
            this.BtnVerEqui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerEqui.BackgroundImage")));
            this.BtnVerEqui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerEqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerEqui.Location = new System.Drawing.Point(60, 61);
            this.BtnVerEqui.Name = "BtnVerEqui";
            this.BtnVerEqui.Size = new System.Drawing.Size(207, 110);
            this.BtnVerEqui.TabIndex = 9;
            this.BtnVerEqui.UseVisualStyleBackColor = true;
            this.BtnVerEqui.Click += new System.EventHandler(this.BtnVerEqui_Click);
            // 
            // BtnVerTec
            // 
            this.BtnVerTec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerTec.BackgroundImage")));
            this.BtnVerTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerTec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerTec.Location = new System.Drawing.Point(992, 61);
            this.BtnVerTec.Name = "BtnVerTec";
            this.BtnVerTec.Size = new System.Drawing.Size(207, 110);
            this.BtnVerTec.TabIndex = 11;
            this.BtnVerTec.Text = " ";
            this.BtnVerTec.UseVisualStyleBackColor = true;
            this.BtnVerTec.Click += new System.EventHandler(this.BtnVerTec_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(60, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 110);
            this.button2.TabIndex = 8;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(369, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 108);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(728, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 108);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.button11);
            this.gb1.Controls.Add(this.button2);
            this.gb1.Controls.Add(this.button1);
            this.gb1.Controls.Add(this.button3);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb1.Location = new System.Drawing.Point(28, 65);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(1305, 200);
            this.gb1.TabIndex = 14;
            this.gb1.TabStop = false;
            this.gb1.Text = "Reparaciones";
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(1064, 50);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(207, 110);
            this.button11.TabIndex = 14;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // gb2
            // 
            this.gb2.BackColor = System.Drawing.Color.Transparent;
            this.gb2.Controls.Add(this.BtnVerTec);
            this.gb2.Controls.Add(this.BtnVerEqui);
            this.gb2.Controls.Add(this.BtnVerCli);
            this.gb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb2.Location = new System.Drawing.Point(28, 340);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(1305, 216);
            this.gb2.TabIndex = 15;
            this.gb2.TabStop = false;
            this.gb2.Text = "Catálogos";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(23, 28);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 19;
            this.rb1.TabStop = true;
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(86, 28);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 20;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(630, 659);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 47);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // gb4
            // 
            this.gb4.BackColor = System.Drawing.Color.Transparent;
            this.gb4.Controls.Add(this.button10);
            this.gb4.Controls.Add(this.button12);
            this.gb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb4.Location = new System.Drawing.Point(548, 295);
            this.gb4.Name = "gb4";
            this.gb4.Size = new System.Drawing.Size(300, 336);
            this.gb4.TabIndex = 23;
            this.gb4.TabStop = false;
            this.gb4.Text = "Herramientas";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(61, 196);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(207, 113);
            this.button10.TabIndex = 8;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(61, 45);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(207, 108);
            this.button12.TabIndex = 13;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // gb3
            // 
            this.gb3.BackColor = System.Drawing.Color.Transparent;
            this.gb3.Controls.Add(this.button4);
            this.gb3.Controls.Add(this.button5);
            this.gb3.Controls.Add(this.button6);
            this.gb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb3.Location = new System.Drawing.Point(34, 49);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(1305, 200);
            this.gb3.TabIndex = 22;
            this.gb3.TabStop = false;
            this.gb3.Text = "Caja";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(156, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 110);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(550, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 109);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(992, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 109);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 736);
            this.Controls.Add(this.gb4);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Screwdriver";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb4.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel LblTipo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button BtnVerCli;
        private System.Windows.Forms.Button BtnVerEqui;
        private System.Windows.Forms.Button BtnVerTec;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox gb4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
    }
}
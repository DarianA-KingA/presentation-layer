
namespace Capa_presentacion
{
    partial class bg_changer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bg_changer));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.main_lay = new System.Windows.Forms.TableLayoutPanel();
            this.btn_opc_panel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.op_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl_botones = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_hide = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_maximum = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_lay = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.random_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.main_lay.SuspendLayout();
            this.btn_opc_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximum)).BeginInit();
            this.btn_lay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.random_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // main_lay
            // 
            this.main_lay.BackColor = System.Drawing.SystemColors.Control;
            this.main_lay.ColumnCount = 1;
            this.main_lay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_lay.Controls.Add(this.btn_opc_panel, 0, 0);
            this.main_lay.Controls.Add(this.btn_lay, 0, 2);
            this.main_lay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_lay.Location = new System.Drawing.Point(0, 0);
            this.main_lay.Name = "main_lay";
            this.main_lay.RowCount = 3;
            this.main_lay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.23729F));
            this.main_lay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.76271F));
            this.main_lay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.main_lay.Size = new System.Drawing.Size(491, 401);
            this.main_lay.TabIndex = 2;
            this.main_lay.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_opc_panel
            // 
            this.btn_opc_panel.BackColor = System.Drawing.Color.Gray;
            this.btn_opc_panel.ColumnCount = 2;
            this.btn_opc_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.96323F));
            this.btn_opc_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.03676F));
            this.btn_opc_panel.Controls.Add(this.menuStrip1, 0, 0);
            this.btn_opc_panel.Controls.Add(this.tbl_botones, 1, 0);
            this.btn_opc_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_opc_panel.Location = new System.Drawing.Point(3, 3);
            this.btn_opc_panel.Name = "btn_opc_panel";
            this.btn_opc_panel.RowCount = 1;
            this.btn_opc_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btn_opc_panel.Size = new System.Drawing.Size(485, 36);
            this.btn_opc_panel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op_menu});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(110, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // op_menu
            // 
            this.op_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator4,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator3,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem,
            this.toolStripSeparator5,
            this.ajustesToolStripMenuItem,
            this.toolStripSeparator2,
            this.ayudaToolStripMenuItem});
            this.op_menu.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_menu.Name = "op_menu";
            this.op_menu.Size = new System.Drawing.Size(102, 22);
            this.op_menu.Text = "Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.guardarToolStripMenuItem.Text = "Guardar...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajustesToolStripMenuItem.Image")));
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tbl_botones
            // 
            this.tbl_botones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_botones.ColumnCount = 3;
            this.tbl_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_botones.Controls.Add(this.btn_close, 2, 0);
            this.tbl_botones.Controls.Add(this.btn_hide, 0, 0);
            this.tbl_botones.Controls.Add(this.btn_maximum, 1, 0);
            this.tbl_botones.Location = new System.Drawing.Point(390, 3);
            this.tbl_botones.Name = "tbl_botones";
            this.tbl_botones.RowCount = 1;
            this.tbl_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_botones.Size = new System.Drawing.Size(92, 30);
            this.tbl_botones.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(63, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 24);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 4;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.ImageActive = null;
            this.btn_hide.Location = new System.Drawing.Point(3, 3);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(24, 24);
            this.btn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_hide.TabIndex = 3;
            this.btn_hide.TabStop = false;
            this.btn_hide.Zoom = 10;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_maximum
            // 
            this.btn_maximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximum.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximum.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximum.Image")));
            this.btn_maximum.ImageActive = null;
            this.btn_maximum.Location = new System.Drawing.Point(33, 3);
            this.btn_maximum.Name = "btn_maximum";
            this.btn_maximum.Size = new System.Drawing.Size(24, 24);
            this.btn_maximum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximum.TabIndex = 2;
            this.btn_maximum.TabStop = false;
            this.btn_maximum.Zoom = 10;
            this.btn_maximum.Click += new System.EventHandler(this.btn_maximum_Click);
            // 
            // btn_lay
            // 
            this.btn_lay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_lay.ColumnCount = 2;
            this.btn_lay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btn_lay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btn_lay.Controls.Add(this.bunifuImageButton1, 0, 0);
            this.btn_lay.Controls.Add(this.random_btn, 0, 0);
            this.btn_lay.Location = new System.Drawing.Point(145, 298);
            this.btn_lay.Name = "btn_lay";
            this.btn_lay.RowCount = 1;
            this.btn_lay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btn_lay.Size = new System.Drawing.Size(200, 100);
            this.btn_lay.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(114, 14);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // random_btn
            // 
            this.random_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.random_btn.BackColor = System.Drawing.Color.Transparent;
            this.random_btn.Image = ((System.Drawing.Image)(resources.GetObject("random_btn.Image")));
            this.random_btn.ImageActive = null;
            this.random_btn.Location = new System.Drawing.Point(14, 14);
            this.random_btn.Name = "random_btn";
            this.random_btn.Size = new System.Drawing.Size(71, 71);
            this.random_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.random_btn.TabIndex = 2;
            this.random_btn.TabStop = false;
            this.random_btn.Zoom = 10;
            this.random_btn.Click += new System.EventHandler(this.random_btn_Click);
            // 
            // bg_changer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 401);
            this.Controls.Add(this.main_lay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bg_changer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bg_changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bg_changer_FormClosing);
            this.main_lay.ResumeLayout(false);
            this.btn_opc_panel.ResumeLayout(false);
            this.btn_opc_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximum)).EndInit();
            this.btn_lay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.random_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel main_lay;
        private System.Windows.Forms.TableLayoutPanel btn_lay;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton random_btn;
        private System.Windows.Forms.TableLayoutPanel btn_opc_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tbl_botones;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_hide;
        private Bunifu.Framework.UI.BunifuImageButton btn_maximum;
        private System.Windows.Forms.ToolStripMenuItem op_menu;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

namespace Capa_presentacion
{
    partial class text_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(text_editor));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.master_panel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_opc_panel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.op_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.gaurdarCómoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl_botones = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_hide = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_maximum = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_field = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.master_panel.SuspendLayout();
            this.btn_opc_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximum)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // master_panel
            // 
            this.master_panel.BackColor = System.Drawing.Color.Transparent;
            this.master_panel.ColumnCount = 1;
            this.master_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.master_panel.Controls.Add(this.btn_opc_panel, 0, 0);
            this.master_panel.Controls.Add(this.txt_field, 0, 1);
            this.master_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.master_panel.Location = new System.Drawing.Point(0, 0);
            this.master_panel.Margin = new System.Windows.Forms.Padding(1);
            this.master_panel.Name = "master_panel";
            this.master_panel.RowCount = 2;
            this.master_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.master_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.master_panel.Size = new System.Drawing.Size(550, 450);
            this.master_panel.TabIndex = 0;
            this.master_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.master_panel_Paint);
            // 
            // btn_opc_panel
            // 
            this.btn_opc_panel.BackColor = System.Drawing.Color.Gray;
            this.btn_opc_panel.ColumnCount = 3;
            this.btn_opc_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59559F));
            this.btn_opc_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.25735F));
            this.btn_opc_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.96324F));
            this.btn_opc_panel.Controls.Add(this.menuStrip1, 0, 0);
            this.btn_opc_panel.Controls.Add(this.tbl_botones, 2, 0);
            this.btn_opc_panel.Controls.Add(this.label1, 1, 0);
            this.btn_opc_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_opc_panel.Location = new System.Drawing.Point(3, 3);
            this.btn_opc_panel.Name = "btn_opc_panel";
            this.btn_opc_panel.RowCount = 1;
            this.btn_opc_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btn_opc_panel.Size = new System.Drawing.Size(544, 39);
            this.btn_opc_panel.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(110, 29);
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
            this.toolStripSeparator6,
            this.gaurdarCómoToolStripMenuItem,
            this.toolStripSeparator1,
            this.ajustesToolStripMenuItem,
            this.toolStripSeparator5,
            this.salirToolStripMenuItem,
            this.toolStripSeparator2,
            this.ayudaToolStripMenuItem});
            this.op_menu.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_menu.Name = "op_menu";
            this.op_menu.Size = new System.Drawing.Size(102, 25);
            this.op_menu.Text = "Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(227, 6);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.guardarToolStripMenuItem.Text = "Guardar...";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(227, 6);
            // 
            // gaurdarCómoToolStripMenuItem
            // 
            this.gaurdarCómoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gaurdarCómoToolStripMenuItem.Image")));
            this.gaurdarCómoToolStripMenuItem.Name = "gaurdarCómoToolStripMenuItem";
            this.gaurdarCómoToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.gaurdarCómoToolStripMenuItem.Text = "Guardar como...";
            this.gaurdarCómoToolStripMenuItem.Click += new System.EventHandler(this.gaurdarCómoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajustesToolStripMenuItem.Image")));
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            this.ajustesToolStripMenuItem.Click += new System.EventHandler(this.ajustesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(227, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
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
            this.tbl_botones.Location = new System.Drawing.Point(438, 3);
            this.tbl_botones.Name = "tbl_botones";
            this.tbl_botones.RowCount = 1;
            this.tbl_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_botones.Size = new System.Drawing.Size(103, 33);
            this.tbl_botones.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(71, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 27);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 4;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.ImageActive = null;
            this.btn_hide.Location = new System.Drawing.Point(3, 3);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(28, 27);
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
            this.btn_maximum.Location = new System.Drawing.Point(37, 3);
            this.btn_maximum.Name = "btn_maximum";
            this.btn_maximum.Size = new System.Drawing.Size(28, 27);
            this.btn_maximum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximum.TabIndex = 2;
            this.btn_maximum.TabStop = false;
            this.btn_maximum.Zoom = 10;
            this.btn_maximum.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Madino", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Editor de texto";
            // 
            // txt_field
            // 
            this.txt_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_field.Location = new System.Drawing.Point(0, 45);
            this.txt_field.Margin = new System.Windows.Forms.Padding(0);
            this.txt_field.Name = "txt_field";
            this.txt_field.Size = new System.Drawing.Size(100, 96);
            this.txt_field.TabIndex = 1;
            this.txt_field.Text = "";
            this.txt_field.BackColorChanged += new System.EventHandler(this.txt_field_BackColorChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt_file|*.rtf";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "text_file|*.rtf";
            // 
            // text_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.master_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "text_editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "text_editor";
            this.FontChanged += new System.EventHandler(this.text_editor_FontChanged);
            this.VisibleChanged += new System.EventHandler(this.text_editor_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_editor_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.text_editor_MouseMove);
            this.master_panel.ResumeLayout(false);
            this.btn_opc_panel.ResumeLayout(false);
            this.btn_opc_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel master_panel;
        private System.Windows.Forms.TableLayoutPanel btn_opc_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem op_menu;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuImageButton btn_maximum;
        private System.Windows.Forms.TableLayoutPanel tbl_botones;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_hide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.RichTextBox txt_field;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem gaurdarCómoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
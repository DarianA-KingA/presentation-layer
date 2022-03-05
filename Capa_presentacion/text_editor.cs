using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capa_presentacion
{
    public partial class text_editor : Form
    {
        public text_editor()
        {
            InitializeComponent();
            txt_field.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Normal;
            openFileDialog.Title = "Seleccione un archivo";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;

        }
        private void master_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quieres cerrar?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                Main_menu.Instance.Close();
                //Environment.Exit(0);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            //Main_menu main =  new Main_menu();
            //main.Show();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                txt_field.SaveFile(saveFileDialog.FileName);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                //txt_field.LoadFile(Path.GetFullPath(openFileDialog.FileName.ToString()).ToString());

                txt_field.LoadFile(openFileDialog.SafeFileName);
                //txt_field.Text += "\n\n" + Path.GetFullPath(openFileDialog.SafeFileName.ToString()).ToString();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_field.Text = "";
        }

        private void text_editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_menu.Instance.Show();
        }
    }
}

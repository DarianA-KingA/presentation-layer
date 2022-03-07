using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class bg_changer : Form
    {
        public bg_changer()
        {
            InitializeComponent();
            
        }


        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Main_menu.Instance.Close();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;

        }

        private void random_btn_Click(object sender, EventArgs e) 
        {
             main_lay.BackColor = this.shuffle();
        }
        public Color shuffle()
        {
            Random random = new Random();
            return  Color.FromArgb( random.Next(250), random.Next(250), random.Next(250));

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bg_changer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_menu.Instance.Show();
        }
    }
}

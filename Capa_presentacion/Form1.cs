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
    public sealed partial class Main_menu : Form 
    {
        public static Main_menu Instance { get; set; } = new Main_menu();

        private Main_menu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            text_editor text = new text_editor();
            text.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bg_changer bg = new bg_changer();
            bg.Show();
        }
    }
}

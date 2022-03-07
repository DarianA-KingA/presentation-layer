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
    public  sealed partial class Opciones_txt_editor : Form
    {
        public Font fuente;
        public Color color = new Color();
        public static Opciones_txt_editor Instance { get; set; } = new Opciones_txt_editor();
        private Opciones_txt_editor()
        {
            InitializeComponent();
            combo_fuente.Items.Add("Tahoma");
            combo_fuente.Items.Add("Madino");
            combo_fuente.Items.Add("Madino");
            for (int i=1; i<=30; i++)
            {
                combo_heigt.Items.Add(Convert.ToString(i));
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void cambios()
        {
            //estilo,fuente y height
            Object cap = FontStyle.Regular;
            if (normal.Checked)
            {
                fuente = new Font(combo_fuente.Text, Int32.Parse(combo_heigt.Text), FontStyle.Regular);
            }
            else if (bold.Checked)
            {
                fuente = new Font(combo_fuente.Text, Int32.Parse(combo_heigt.Text), FontStyle.Bold);
            }
            else if (italic.Checked)
            {

                fuente = new Font(combo_fuente.Text, Int32.Parse(combo_heigt.Text), FontStyle.Italic);
            }
            else if (subrayada.Checked)
            {
                fuente = new Font(combo_fuente.Text, Int32.Parse(combo_heigt.Text), FontStyle.Underline);
            }
            text_editor.Instance.Font = fuente;
            text_editor.Instance.Size = new Size(550,450);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                color = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bg color 
            if (colorDialog1.ShowDialog() == DialogResult.OK)

                text_editor.Instance.BackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cambios();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public sealed partial class text_editor : Form
    {
        public static text_editor Instance { get; set; } = new text_editor();
        private text_editor()
        {
            InitializeComponent();
            txt_field.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Normal;
            openFileDialog.Title = "Seleccione un archivo";
            saveFileDialog.Title = "Nuevo documnto";
            //txt_field.SelectionFont = new Font("Tahoma", 30, FontStyle.Regular);
            txt_field.SelectionColor = new Color();
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
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "texto sin formato|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                txt_field.SaveFile(saveFileDialog.FileName);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "all files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txt_field.LoadFile(openFileDialog.FileName);
        }
        private void gaurdarCómoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Documento de word|*.docx|Documentos habilitados con macros de word|*.docm|Documento de word 97-2003|*.doc|Plantilla word|*.dotx|Plantilla word|*.dotx|Documento Open XML estricto|*.docx|Plantilla de Word 97-2003|*.dot|Plantilla habilitada con macros de Word|*.dotm|Página web|*.htm, .html|Página web, filtrada|*.htm, .html|Página web de un solo archivo|*.mht; .mhtml|Texto de OpenDocument|*.odt|PDF|*.pdf|Formato de texto enriquecido|*.rtf|Texto sin formato|*.txt|Documento de Works 6-9|*.wps|Documento XML de Word 2003|*.xml|Documento XML de Word|*.xml|Documento XPS|*.xps";
                                    /*"Documento de word|*.docx|" +
                                    "Documentos habilitados con macros de word|*.docm|" +
                                    "Documento de word 97-2003|*.doc|" +
                                    "Plantilla word|*.dotx|" +
                                    "Documento Open XML estricto|*.docx|" +
                                    "Plantilla de Word 97-2003|*.dot|" +
                                    "Plantilla habilitada con macros de Word|*.dotm|" +
                                    "Página web|*.htm, .html|" +
                                    "Página web, filtrada|*.htm, .html|" +
                                    "Página web de un solo archivo|*.mht; .mhtml|" +
                                    "Texto de OpenDocument|*.odt|" +
                                    "PDF|*.pdf|" +
                                    "Formato de texto enriquecido|*.rtf|" +
                                    "Texto sin formato|*.txt|" +
                                    "Documento de Works 6-9|*.wps|" +
                                    "Documento XML de Word 2003|*.xml|" +
                                    "Documento XML de Word|*.xml|" +
                                    "Documento XPS|*.xps|";*/
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                txt_field.SaveFile(saveFileDialog.FileName);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_field.Clear();
        }

        private void text_editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_menu.Instance.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si necesita ayuda o asistencia puede contactarnos a nuestro correo o telefono: \n\n" +
                "XXX-XXX-XXXX\n\n" +
                "XXXXXXX@email.com ","Ayuda");
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones_txt_editor.Instance.Show();
        }

        private void text_editor_FontChanged(object sender, EventArgs e)
        {
            txt_field.SelectionColor = Opciones_txt_editor.Instance.color;
        }
        
        private void text_editor_MouseMove(object sender, MouseEventArgs e)
        {
            txt_field.SelectionColor = Opciones_txt_editor.Instance.color;
            txt_field.BackColor = master_panel.BackColor;
        }

        private void master_panel_MouseHover(object sender, EventArgs e)
        {
            txt_field.SelectionFont = Opciones_txt_editor.Instance.fuente;
        }
    }
}

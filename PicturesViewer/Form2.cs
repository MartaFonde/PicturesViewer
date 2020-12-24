using System;
using System.IO;
using System.Windows.Forms;

namespace PicturesViewer
{
    public partial class Form2 : Form
    {
        Form1 f1;
        internal FileInfo file;
        FileInfo[] files;

        public Form2(Form1 f1)
        {
            InitializeComponent();

            this.f1 = f1;

            siguienteToolStripMenuItem.Tag = f1.btnAvance.Tag.ToString();
            anteriorToolStripMenuItem.Tag = f1.btnRetroceso.Tag.ToString();
            file = f1.file;
        }

        private void cambioImagen(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            DirectoryInfo dir = new DirectoryInfo(file.DirectoryName);
            files = dir.GetFiles();
            f1.pasarImagen(files, item.Tag.ToString());            
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                siguienteToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                anteriorToolStripMenuItem.PerformClick();
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            f1.file = file;
            f1.f2 = this;
            f1.infoFile(file);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.file = null;
            f1.lblInfo.Text = "";
            f1.Text = f1.titulo;
            f1.lblInfo.Text = "";
            f1.lblDir.Text = "";
        }
    }
}

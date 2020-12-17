using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesViewer
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void cambioImagen(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(item.Tag.ToString() == "siguiente")
            {
                f1.btnAvance.PerformClick();
            }
            else 
            {
                f1.btnRetroceso.PerformClick();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.file = null;
            f1.lblInfo.Text = "";
            f1.Text = f1.titulo;
            f1.btnAvance.Enabled = false;
            f1.btnRetroceso.Enabled = false;
            this.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            f1.Form1_KeyDown(sender, e);
        }
    }
}

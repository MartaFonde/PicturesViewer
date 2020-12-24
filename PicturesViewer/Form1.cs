using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesViewer
{
    public partial class Form1 : Form
    {
        internal string titulo = "Visor de imágenes";
        internal Form2 f2 = null;
        internal FileInfo file = null;
        string path;
        FileInfo[] files;
        DirectoryInfo dir;
        public Form1()
        {
            InitializeComponent();
            lblDir.Text = Environment.CurrentDirectory;
            lblInfo.Text = "";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Abrir imagen";
            op.Filter = "Todos los archivos|*.*|JPEG|*.jpeg|JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif|ICO|*.ico";
            op.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (op.ShowDialog() == DialogResult.OK)
            {
                f2 = new Form2(this);
                path = op.FileName;
                if (verImagen(path))
                {
                    file = new FileInfo(path);
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Error al abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal bool verImagen(string path)
        {
            file = new FileInfo(path);
            if (f2 != null && file.Extension == ".jpeg" || file.Extension == ".jpg" || file.Extension == ".bmp" ||  file.Extension == ".png"||file.Extension == ".gif" || file.Extension == ".ico")
            {                
                try
                {
                    f2.pictureBox.Image = Image.FromFile(path);                   
                }
                catch (Exception ex) when (ex is ArgumentException || ex is FileNotFoundException || ex is OutOfMemoryException)
                {
                    file = null;
                    return false;
                }
                //------------------------------------- Non saltan excep
                f2.file = file;
                f2.Size = new System.Drawing.Size(f2.pictureBox.Image.Size.Width, f2.pictureBox.Image.Size.Height);
                f2.pictureBox.Tag = path;
                f2.Text = file.Name;
                
                infoFile(file);
                return true;                             
            }
            else
            {
                file = null;
                return false;
            }
        }

        internal void infoFile(FileInfo file)
        {
            bool otrasImgDir = false;

            this.Text = titulo + " - " + file.Name;
            lblDir.Text = file.DirectoryName;
            lblInfo.Text = string.Format("Nombre: {1}{0}Tamaño: {2}{0}Resolución horizontal: {3} ppp{0}" +
                "Resolución vertical: {4} ppp{0}Dimensiones: {5} x {6} píxeles",
                Environment.NewLine,
                file.Name,
                file.Length / 1024 < 1024 ? Math.Round(file.Length / Math.Pow(2, 10), 2) + " KB" : Math.Round(file.Length / Math.Pow(2, 20), 2) + " MB",
                f2.pictureBox.Image.HorizontalResolution,
                f2.pictureBox.Image.VerticalResolution,
                f2.pictureBox.Image.Width,
                f2.pictureBox.Image.Height);

            dir = new DirectoryInfo(file.DirectoryName);
            files = dir.GetFiles();
            if(files.Length > 1)
            {
                for (int i = 0; i < files.Length && !otrasImgDir; i++)
                {
                    if (files[i].FullName != file.FullName && (files[i].Extension == ".jpeg" || files[i].Extension == ".jpg" || files[i].Extension == ".bmp" ||
                        files[i].Extension == ".png" || files[i].Extension == ".gif" || files[i].Extension == ".ico"))
                    {
                        btnAvance.Enabled = true;
                        btnRetroceso.Enabled = true;
                        f2.siguienteToolStripMenuItem.Enabled = true;
                        f2.anteriorToolStripMenuItem.Enabled = true;
                        otrasImgDir = true;
                    }
                }
            }
            
            if (!otrasImgDir)
            {
                btnAvance.Enabled = false;
                btnRetroceso.Enabled = false;
                f2.siguienteToolStripMenuItem.Enabled = false;
                f2.anteriorToolStripMenuItem.Enabled = false;
            }
        }

        internal void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                btnRetroceso.PerformClick();
            }else if(e.KeyCode == Keys.D)
            {
                btnAvance.PerformClick();
            }
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (f2 != null && file != null)
            {
                dir = new DirectoryInfo(file.DirectoryName);
                files = dir.GetFiles();
                pasarImagen(files, btn.Tag.ToString());                
            }
        }

        internal bool pasarImagen(FileInfo[] files, string tag)
        {
            if(files.Length > 1)
            {
                bool valido = false;
                for (int i = 0; i < files.Length && !valido; i++)
                {
                    if (files[i].FullName == file.FullName)
                    {
                        if (tag == btnAvance.Tag.ToString())    //"siguiente"
                        {
                            while (!valido)
                            {
                                valido = verImagen(files[i = i + 1 > files.Length - 1 ? 0 : ++i].FullName);
                            }
                        }
                        else if (tag == btnRetroceso.Tag.ToString())    //"anterior"
                        {
                            while (!valido)
                            {
                                valido = verImagen(files[i = i - 1 < 0 ? files.Length - 1 : --i].FullName);
                            }
                        }
                        if (valido)
                        {
                            
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                return false;
            }                        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás segura de que quieres salir?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}


namespace PicturesViewer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnAvance = new System.Windows.Forms.Button();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbrir.Location = new System.Drawing.Point(74, 24);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(500, 41);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.toolTip1.SetToolTip(this.btnAbrir, "Pulsa para abrir una imagen");
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnAvance
            // 
            this.btnAvance.BackColor = System.Drawing.Color.LightBlue;
            this.btnAvance.Enabled = false;
            this.btnAvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvance.Location = new System.Drawing.Point(363, 268);
            this.btnAvance.Name = "btnAvance";
            this.btnAvance.Size = new System.Drawing.Size(211, 23);
            this.btnAvance.TabIndex = 2;
            this.btnAvance.Tag = "siguiente";
            this.btnAvance.Text = "→";
            this.toolTip1.SetToolTip(this.btnAvance, "Ver imagen siguiente");
            this.btnAvance.UseVisualStyleBackColor = false;
            this.btnAvance.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.BackColor = System.Drawing.Color.LightBlue;
            this.btnRetroceso.Enabled = false;
            this.btnRetroceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceso.Location = new System.Drawing.Point(74, 268);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(211, 23);
            this.btnRetroceso.TabIndex = 1;
            this.btnRetroceso.Tag = "anterior";
            this.btnRetroceso.Text = "←";
            this.toolTip1.SetToolTip(this.btnRetroceso, "Ver imagen anterior");
            this.btnRetroceso.UseVisualStyleBackColor = false;
            this.btnRetroceso.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directorio actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Información sobre la imagen:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(134, 106);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(35, 13);
            this.lblDir.TabIndex = 5;
            this.lblDir.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 154);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "label2";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAbrir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 352);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.btnAvance);
            this.Controls.Add(this.btnAbrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Visor de imágenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDir;
        internal System.Windows.Forms.Button btnAvance;
        internal System.Windows.Forms.Button btnRetroceso;
        internal System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


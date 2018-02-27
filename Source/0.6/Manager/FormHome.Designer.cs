namespace Manager
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pbWoman = new System.Windows.Forms.PictureBox();
            this.gbProcess = new System.Windows.Forms.GroupBox();
            this.lvProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.KillProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tmReloadProcess = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbWoman)).BeginInit();
            this.gbProcess.SuspendLayout();
            this.cmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWoman
            // 
            this.pbWoman.BackColor = System.Drawing.Color.Transparent;
            this.pbWoman.Image = ((System.Drawing.Image)(resources.GetObject("pbWoman.Image")));
            this.pbWoman.Location = new System.Drawing.Point(552, 13);
            this.pbWoman.Name = "pbWoman";
            this.pbWoman.Size = new System.Drawing.Size(108, 385);
            this.pbWoman.TabIndex = 1;
            this.pbWoman.TabStop = false;
            this.pbWoman.Click += new System.EventHandler(this.pbWoman_Click);
            // 
            // gbProcess
            // 
            this.gbProcess.BackColor = System.Drawing.Color.Transparent;
            this.gbProcess.Controls.Add(this.lvProcess);
            this.gbProcess.ForeColor = System.Drawing.Color.Lime;
            this.gbProcess.Location = new System.Drawing.Point(12, 115);
            this.gbProcess.Name = "gbProcess";
            this.gbProcess.Size = new System.Drawing.Size(528, 282);
            this.gbProcess.TabIndex = 2;
            this.gbProcess.TabStop = false;
            this.gbProcess.Text = "Process";
            // 
            // lvProcess
            // 
            this.lvProcess.BackColor = System.Drawing.Color.Black;
            this.lvProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProcess.ContextMenuStrip = this.cmsOpciones;
            this.lvProcess.ForeColor = System.Drawing.Color.Lime;
            this.lvProcess.FullRowSelect = true;
            this.lvProcess.Location = new System.Drawing.Point(15, 32);
            this.lvProcess.Name = "lvProcess";
            this.lvProcess.Size = new System.Drawing.Size(496, 233);
            this.lvProcess.TabIndex = 0;
            this.lvProcess.UseCompatibleStateImageBehavior = false;
            this.lvProcess.View = System.Windows.Forms.View.Details;
            this.lvProcess.Click += new System.EventHandler(this.lvProcess_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Priority";
            this.columnHeader5.Width = 97;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refresh,
            this.KillProcess,
            this.About,
            this.Exit});
            this.cmsOpciones.Name = "contextMenuStrip1";
            this.cmsOpciones.Size = new System.Drawing.Size(134, 92);
            this.cmsOpciones.Text = "Exit";
            this.cmsOpciones.Click += new System.EventHandler(this.cmsOpciones_Click);
            // 
            // Refresh
            // 
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(133, 22);
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // KillProcess
            // 
            this.KillProcess.Name = "KillProcess";
            this.KillProcess.Size = new System.Drawing.Size(133, 22);
            this.KillProcess.Text = "Kill Process";
            this.KillProcess.Click += new System.EventHandler(this.KillProcess_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(133, 22);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(27, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(496, 84);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // tmReloadProcess
            // 
            this.tmReloadProcess.Enabled = true;
            this.tmReloadProcess.Interval = 60000;
            this.tmReloadProcess.Tick += new System.EventHandler(this.tmReloadProcess_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 410);
            this.Controls.Add(this.gbProcess);
            this.Controls.Add(this.pbWoman);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = " - Fenix Process Manager 0.6 - © Ismael Heredia , Argentina , 2017 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.Click += new System.EventHandler(this.FormHome_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbWoman)).EndInit();
            this.gbProcess.ResumeLayout(false);
            this.cmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWoman;
        private System.Windows.Forms.GroupBox gbProcess;
        private System.Windows.Forms.ListView lvProcess;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem Refresh;
        private System.Windows.Forms.ToolStripMenuItem KillProcess;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Timer tmReloadProcess;

    }
}


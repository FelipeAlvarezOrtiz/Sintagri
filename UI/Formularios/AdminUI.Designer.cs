namespace Sintagri
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SectionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PerfilOpcionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.MidSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.PerfilBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainLayout.SuspendLayout();
            this.SectionLayout.SuspendLayout();
            this.PerfilOpcionLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerfilBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.MainLayout.Controls.Add(this.PerfilOpcionLayout, 0, 0);
            this.MainLayout.Controls.Add(this.SectionLayout, 2, 0);
            this.MainLayout.Controls.Add(this.MidSeparator, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(1559, 761);
            this.MainLayout.TabIndex = 0;
            // 
            // SectionLayout
            // 
            this.SectionLayout.ColumnCount = 1;
            this.SectionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SectionLayout.Controls.Add(this.MainPanel, 0, 1);
            this.SectionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionLayout.Location = new System.Drawing.Point(173, 3);
            this.SectionLayout.Name = "SectionLayout";
            this.SectionLayout.RowCount = 2;
            this.SectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.SectionLayout.Size = new System.Drawing.Size(1383, 755);
            this.SectionLayout.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 63);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1377, 689);
            this.MainPanel.TabIndex = 0;
            // 
            // PerfilOpcionLayout
            // 
            this.PerfilOpcionLayout.ColumnCount = 1;
            this.PerfilOpcionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PerfilOpcionLayout.Controls.Add(this.SideMenuPanel, 0, 1);
            this.PerfilOpcionLayout.Controls.Add(this.PerfilBox, 0, 0);
            this.PerfilOpcionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerfilOpcionLayout.Location = new System.Drawing.Point(3, 3);
            this.PerfilOpcionLayout.Name = "PerfilOpcionLayout";
            this.PerfilOpcionLayout.RowCount = 3;
            this.PerfilOpcionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.89404F));
            this.PerfilOpcionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.61589F));
            this.PerfilOpcionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.357616F));
            this.PerfilOpcionLayout.Size = new System.Drawing.Size(149, 755);
            this.PerfilOpcionLayout.TabIndex = 2;
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideMenuPanel.Location = new System.Drawing.Point(3, 123);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(143, 580);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // MidSeparator
            // 
            this.MidSeparator.BackColor = System.Drawing.Color.Transparent;
            this.MidSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.MidSeparator.LineThickness = 2;
            this.MidSeparator.Location = new System.Drawing.Point(159, 4);
            this.MidSeparator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MidSeparator.Name = "MidSeparator";
            this.MidSeparator.Size = new System.Drawing.Size(7, 753);
            this.MidSeparator.TabIndex = 3;
            this.MidSeparator.Transparency = 255;
            this.MidSeparator.Vertical = true;
            // 
            // PerfilBox
            // 
            this.PerfilBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.PerfilBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerfilBox.Image = ((System.Drawing.Image)(resources.GetObject("PerfilBox.Image")));
            this.PerfilBox.ImageActive = null;
            this.PerfilBox.Location = new System.Drawing.Point(3, 3);
            this.PerfilBox.Name = "PerfilBox";
            this.PerfilBox.Size = new System.Drawing.Size(143, 114);
            this.PerfilBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PerfilBox.TabIndex = 1;
            this.PerfilBox.TabStop = false;
            this.PerfilBox.Zoom = 10;
            this.PerfilBox.Click += new System.EventHandler(this.ObtenerPerfil_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1559, 761);
            this.Controls.Add(this.MainLayout);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion SINTAGRI";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MainLayout.ResumeLayout(false);
            this.SectionLayout.ResumeLayout(false);
            this.PerfilOpcionLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerfilBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel SectionLayout;
        private System.Windows.Forms.TableLayoutPanel PerfilOpcionLayout;
        private System.Windows.Forms.Panel SideMenuPanel;
        private Bunifu.Framework.UI.BunifuSeparator MidSeparator;
        private Bunifu.Framework.UI.BunifuImageButton PerfilBox;
        public System.Windows.Forms.Panel MainPanel;
    }
}


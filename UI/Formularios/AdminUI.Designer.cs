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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PerfilOpcionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SectionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.MainLayout.SuspendLayout();
            this.SectionLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.633098F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.36691F));
            this.MainLayout.Controls.Add(this.PerfilOpcionLayout, 0, 0);
            this.MainLayout.Controls.Add(this.SectionLayout, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(1559, 761);
            this.MainLayout.TabIndex = 0;
            // 
            // PerfilOpcionLayout
            // 
            this.PerfilOpcionLayout.ColumnCount = 1;
            this.PerfilOpcionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PerfilOpcionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerfilOpcionLayout.Location = new System.Drawing.Point(3, 3);
            this.PerfilOpcionLayout.Name = "PerfilOpcionLayout";
            this.PerfilOpcionLayout.RowCount = 3;
            this.PerfilOpcionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.03973F));
            this.PerfilOpcionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.4702F));
            this.PerfilOpcionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.357616F));
            this.PerfilOpcionLayout.Size = new System.Drawing.Size(112, 755);
            this.PerfilOpcionLayout.TabIndex = 0;
            // 
            // SectionLayout
            // 
            this.SectionLayout.ColumnCount = 1;
            this.SectionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SectionLayout.Controls.Add(this.PanelInfo, 0, 1);
            this.SectionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionLayout.Location = new System.Drawing.Point(121, 3);
            this.SectionLayout.Name = "SectionLayout";
            this.SectionLayout.RowCount = 2;
            this.SectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.03973F));
            this.SectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.96027F));
            this.SectionLayout.Size = new System.Drawing.Size(1435, 755);
            this.SectionLayout.TabIndex = 1;
            // 
            // PanelInfo
            // 
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInfo.Location = new System.Drawing.Point(3, 108);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(1429, 644);
            this.PanelInfo.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel PerfilOpcionLayout;
        private System.Windows.Forms.TableLayoutPanel SectionLayout;
        private System.Windows.Forms.Panel PanelInfo;
    }
}


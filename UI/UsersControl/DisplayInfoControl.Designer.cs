namespace Sintagri.UI.UsersControl
{
    partial class DisplayInfoControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayInfoControl));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CheckboxPanel = new System.Windows.Forms.Panel();
            this.CheckboxInput = new System.Windows.Forms.CheckedListBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.Aceptar_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cancelar_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MainLayout.SuspendLayout();
            this.ButtonLayout.SuspendLayout();
            this.CheckboxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.White;
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.Controls.Add(this.ButtonLayout, 1, 3);
            this.MainLayout.Controls.Add(this.CheckboxPanel, 1, 2);
            this.MainLayout.Controls.Add(this.InfoLabel, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 5;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.930818F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.905661F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.7673F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20755F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.Size = new System.Drawing.Size(540, 636);
            this.MainLayout.TabIndex = 0;
            // 
            // ButtonLayout
            // 
            this.ButtonLayout.ColumnCount = 2;
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayout.Controls.Add(this.Cancelar_Button, 0, 0);
            this.ButtonLayout.Controls.Add(this.Aceptar_Button, 1, 0);
            this.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLayout.Location = new System.Drawing.Point(57, 522);
            this.ButtonLayout.Name = "ButtonLayout";
            this.ButtonLayout.RowCount = 1;
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayout.Size = new System.Drawing.Size(426, 78);
            this.ButtonLayout.TabIndex = 0;
            // 
            // CheckboxPanel
            // 
            this.CheckboxPanel.Controls.Add(this.CheckboxInput);
            this.CheckboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckboxPanel.Location = new System.Drawing.Point(57, 91);
            this.CheckboxPanel.Name = "CheckboxPanel";
            this.CheckboxPanel.Size = new System.Drawing.Size(426, 425);
            this.CheckboxPanel.TabIndex = 1;
            // 
            // CheckboxInput
            // 
            this.CheckboxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckboxInput.CheckOnClick = true;
            this.CheckboxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckboxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxInput.FormattingEnabled = true;
            this.CheckboxInput.Items.AddRange(new object[] {
            "Predio Nueva Vida",
            "Predio paguenme Ahora"});
            this.CheckboxInput.Location = new System.Drawing.Point(0, 0);
            this.CheckboxInput.Margin = new System.Windows.Forms.Padding(5);
            this.CheckboxInput.Name = "CheckboxInput";
            this.CheckboxInput.Size = new System.Drawing.Size(426, 425);
            this.CheckboxInput.TabIndex = 0;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(57, 28);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(3);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(426, 57);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "Seleccione uno o más valores";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Aceptar_Button
            // 
            this.Aceptar_Button.ActiveBorderThickness = 1;
            this.Aceptar_Button.ActiveCornerRadius = 20;
            this.Aceptar_Button.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(94)))));
            this.Aceptar_Button.ActiveForecolor = System.Drawing.Color.White;
            this.Aceptar_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(94)))));
            this.Aceptar_Button.BackColor = System.Drawing.Color.White;
            this.Aceptar_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aceptar_Button.BackgroundImage")));
            this.Aceptar_Button.ButtonText = "Aceptar";
            this.Aceptar_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aceptar_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Aceptar_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar_Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Aceptar_Button.IdleBorderThickness = 1;
            this.Aceptar_Button.IdleCornerRadius = 20;
            this.Aceptar_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(213)))), ((int)(((byte)(129)))));
            this.Aceptar_Button.IdleForecolor = System.Drawing.Color.White;
            this.Aceptar_Button.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Aceptar_Button.Location = new System.Drawing.Point(218, 5);
            this.Aceptar_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Aceptar_Button.Name = "Aceptar_Button";
            this.Aceptar_Button.Size = new System.Drawing.Size(203, 68);
            this.Aceptar_Button.TabIndex = 2;
            this.Aceptar_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.ActiveBorderThickness = 1;
            this.Cancelar_Button.ActiveCornerRadius = 20;
            this.Cancelar_Button.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(94)))));
            this.Cancelar_Button.ActiveForecolor = System.Drawing.Color.White;
            this.Cancelar_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(94)))));
            this.Cancelar_Button.BackColor = System.Drawing.Color.White;
            this.Cancelar_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelar_Button.BackgroundImage")));
            this.Cancelar_Button.ButtonText = "Cancelar";
            this.Cancelar_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancelar_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Cancelar_Button.IdleBorderThickness = 1;
            this.Cancelar_Button.IdleCornerRadius = 20;
            this.Cancelar_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(213)))), ((int)(((byte)(129)))));
            this.Cancelar_Button.IdleForecolor = System.Drawing.Color.White;
            this.Cancelar_Button.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Cancelar_Button.Location = new System.Drawing.Point(5, 5);
            this.Cancelar_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(203, 68);
            this.Cancelar_Button.TabIndex = 3;
            this.Cancelar_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayout);
            this.Name = "DisplayInfoControl";
            this.Size = new System.Drawing.Size(540, 636);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.ButtonLayout.ResumeLayout(false);
            this.CheckboxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel ButtonLayout;
        private System.Windows.Forms.Panel CheckboxPanel;
        private System.Windows.Forms.CheckedListBox CheckboxInput;
        private System.Windows.Forms.Label InfoLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancelar_Button;
        private Bunifu.Framework.UI.BunifuThinButton2 Aceptar_Button;
    }
}

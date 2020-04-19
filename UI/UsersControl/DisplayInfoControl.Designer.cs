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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.CheckboxPanel = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CheckboxInput = new System.Windows.Forms.CheckedListBox();
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
            this.ButtonLayout.Controls.Add(this.AceptarButton, 1, 0);
            this.ButtonLayout.Controls.Add(this.CancelarButton, 0, 0);
            this.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLayout.Location = new System.Drawing.Point(57, 522);
            this.ButtonLayout.Name = "ButtonLayout";
            this.ButtonLayout.RowCount = 1;
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayout.Size = new System.Drawing.Size(426, 78);
            this.ButtonLayout.TabIndex = 0;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AceptarButton.Location = new System.Drawing.Point(228, 15);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(15);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(183, 48);
            this.AceptarButton.TabIndex = 0;
            this.AceptarButton.Text = "Ingresar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelarButton.Location = new System.Drawing.Point(15, 15);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(15);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(183, 48);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
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
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
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
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Panel CheckboxPanel;
        private System.Windows.Forms.CheckedListBox CheckboxInput;
        private System.Windows.Forms.Label InfoLabel;
    }
}

namespace Sintagri.UI.UsersControl
{
    partial class PropiedadesControl
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
            this.InfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TipoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.TipoCB = new System.Windows.Forms.ComboBox();
            this.CategoriaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CategoriaTB = new System.Windows.Forms.TextBox();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.UnidadMedidaLabel = new System.Windows.Forms.TableLayoutPanel();
            this.UnidadMedidaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorLabel = new System.Windows.Forms.TableLayoutPanel();
            this.ValorTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.BotonesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AgregarPropiedad = new System.Windows.Forms.Button();
            this.MainLayout.SuspendLayout();
            this.InfoLayout.SuspendLayout();
            this.TipoLayout.SuspendLayout();
            this.CategoriaLayout.SuspendLayout();
            this.UnidadMedidaLabel.SuspendLayout();
            this.ValorLabel.SuspendLayout();
            this.NombreLayout.SuspendLayout();
            this.BotonesLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.White;
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.Controls.Add(this.InfoLayout, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.Size = new System.Drawing.Size(745, 456);
            this.MainLayout.TabIndex = 0;
            // 
            // InfoLayout
            // 
            this.InfoLayout.ColumnCount = 1;
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InfoLayout.Controls.Add(this.TipoLayout, 0, 5);
            this.InfoLayout.Controls.Add(this.CategoriaLayout, 0, 4);
            this.InfoLayout.Controls.Add(this.UnidadMedidaLabel, 0, 3);
            this.InfoLayout.Controls.Add(this.ValorLabel, 0, 2);
            this.InfoLayout.Controls.Add(this.NombreLayout, 0, 1);
            this.InfoLayout.Controls.Add(this.TituloLabel, 0, 0);
            this.InfoLayout.Controls.Add(this.BotonesLayout, 0, 6);
            this.InfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLayout.Location = new System.Drawing.Point(40, 25);
            this.InfoLayout.Name = "InfoLayout";
            this.InfoLayout.RowCount = 7;
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.80812F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.39114F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42066F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.02214F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94465F));
            this.InfoLayout.Size = new System.Drawing.Size(664, 404);
            this.InfoLayout.TabIndex = 0;
            // 
            // TipoLayout
            // 
            this.TipoLayout.ColumnCount = 2;
            this.TipoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TipoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TipoLayout.Controls.Add(this.TipoLabel, 0, 0);
            this.TipoLayout.Controls.Add(this.TipoCB, 1, 0);
            this.TipoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoLayout.Location = new System.Drawing.Point(3, 288);
            this.TipoLayout.Name = "TipoLayout";
            this.TipoLayout.RowCount = 1;
            this.TipoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TipoLayout.Size = new System.Drawing.Size(658, 50);
            this.TipoLayout.TabIndex = 6;
            // 
            // TipoLabel
            // 
            this.TipoLabel.AutoSize = true;
            this.TipoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoLabel.Location = new System.Drawing.Point(3, 0);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(224, 50);
            this.TipoLabel.TabIndex = 2;
            this.TipoLabel.Text = "Tipo";
            this.TipoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TipoCB
            // 
            this.TipoCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCB.FormattingEnabled = true;
            this.TipoCB.Items.AddRange(new object[] {
            "Ingrediente",
            "Propiedad Fisico/Quimica"});
            this.TipoCB.Location = new System.Drawing.Point(233, 7);
            this.TipoCB.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.TipoCB.Name = "TipoCB";
            this.TipoCB.Size = new System.Drawing.Size(422, 33);
            this.TipoCB.TabIndex = 3;
            // 
            // CategoriaLayout
            // 
            this.CategoriaLayout.ColumnCount = 2;
            this.CategoriaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.CategoriaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.CategoriaLayout.Controls.Add(this.CategoriaTB, 0, 0);
            this.CategoriaLayout.Controls.Add(this.CategoriaLabel, 0, 0);
            this.CategoriaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriaLayout.Location = new System.Drawing.Point(3, 231);
            this.CategoriaLayout.Name = "CategoriaLayout";
            this.CategoriaLayout.RowCount = 1;
            this.CategoriaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CategoriaLayout.Size = new System.Drawing.Size(658, 51);
            this.CategoriaLayout.TabIndex = 5;
            // 
            // CategoriaTB
            // 
            this.CategoriaTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaTB.Location = new System.Drawing.Point(233, 9);
            this.CategoriaTB.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.CategoriaTB.Name = "CategoriaTB";
            this.CategoriaTB.Size = new System.Drawing.Size(422, 34);
            this.CategoriaTB.TabIndex = 3;
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(3, 0);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(224, 51);
            this.CategoriaLabel.TabIndex = 2;
            this.CategoriaLabel.Text = "Categoria";
            this.CategoriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnidadMedidaLabel
            // 
            this.UnidadMedidaLabel.ColumnCount = 2;
            this.UnidadMedidaLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.UnidadMedidaLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.UnidadMedidaLabel.Controls.Add(this.UnidadMedidaTB, 0, 0);
            this.UnidadMedidaLabel.Controls.Add(this.label2, 0, 0);
            this.UnidadMedidaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnidadMedidaLabel.Location = new System.Drawing.Point(3, 174);
            this.UnidadMedidaLabel.Name = "UnidadMedidaLabel";
            this.UnidadMedidaLabel.RowCount = 1;
            this.UnidadMedidaLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UnidadMedidaLabel.Size = new System.Drawing.Size(658, 51);
            this.UnidadMedidaLabel.TabIndex = 4;
            // 
            // UnidadMedidaTB
            // 
            this.UnidadMedidaTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnidadMedidaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnidadMedidaTB.Location = new System.Drawing.Point(233, 9);
            this.UnidadMedidaTB.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.UnidadMedidaTB.Name = "UnidadMedidaTB";
            this.UnidadMedidaTB.Size = new System.Drawing.Size(422, 34);
            this.UnidadMedidaTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad de Medida";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValorLabel
            // 
            this.ValorLabel.ColumnCount = 2;
            this.ValorLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ValorLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.ValorLabel.Controls.Add(this.ValorTB, 0, 0);
            this.ValorLabel.Controls.Add(this.label1, 0, 0);
            this.ValorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValorLabel.Location = new System.Drawing.Point(3, 108);
            this.ValorLabel.Name = "ValorLabel";
            this.ValorLabel.RowCount = 1;
            this.ValorLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ValorLabel.Size = new System.Drawing.Size(658, 60);
            this.ValorLabel.TabIndex = 3;
            // 
            // ValorTB
            // 
            this.ValorTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTB.Location = new System.Drawing.Point(233, 9);
            this.ValorTB.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.ValorTB.Name = "ValorTB";
            this.ValorTB.Size = new System.Drawing.Size(422, 34);
            this.ValorTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor en Porcentaje";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreLayout
            // 
            this.NombreLayout.ColumnCount = 2;
            this.NombreLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.NombreLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.NombreLayout.Controls.Add(this.NombreLabel, 0, 0);
            this.NombreLayout.Controls.Add(this.NombreTB, 1, 0);
            this.NombreLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreLayout.Location = new System.Drawing.Point(3, 50);
            this.NombreLayout.Name = "NombreLayout";
            this.NombreLayout.RowCount = 1;
            this.NombreLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NombreLayout.Size = new System.Drawing.Size(658, 52);
            this.NombreLayout.TabIndex = 2;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(3, 0);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(224, 52);
            this.NombreLabel.TabIndex = 0;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreTB
            // 
            this.NombreTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTB.Location = new System.Drawing.Point(233, 9);
            this.NombreTB.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(422, 34);
            this.NombreTB.TabIndex = 1;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.TituloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(3, 3);
            this.TituloLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(658, 41);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Propiedades e Ingredientes";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonesLayout
            // 
            this.BotonesLayout.ColumnCount = 1;
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.Controls.Add(this.AgregarPropiedad, 0, 0);
            this.BotonesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonesLayout.Location = new System.Drawing.Point(3, 344);
            this.BotonesLayout.Name = "BotonesLayout";
            this.BotonesLayout.RowCount = 1;
            this.BotonesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.Size = new System.Drawing.Size(658, 57);
            this.BotonesLayout.TabIndex = 1;
            // 
            // AgregarPropiedad
            // 
            this.AgregarPropiedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.AgregarPropiedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgregarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarPropiedad.Location = new System.Drawing.Point(5, 5);
            this.AgregarPropiedad.Margin = new System.Windows.Forms.Padding(5);
            this.AgregarPropiedad.Name = "AgregarPropiedad";
            this.AgregarPropiedad.Size = new System.Drawing.Size(648, 47);
            this.AgregarPropiedad.TabIndex = 0;
            this.AgregarPropiedad.Text = "Agregar";
            this.AgregarPropiedad.UseVisualStyleBackColor = false;
            this.AgregarPropiedad.Click += new System.EventHandler(this.AgregarPropiedad_Click);
            // 
            // PropiedadesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayout);
            this.Name = "PropiedadesControl";
            this.Size = new System.Drawing.Size(745, 456);
            this.MainLayout.ResumeLayout(false);
            this.InfoLayout.ResumeLayout(false);
            this.InfoLayout.PerformLayout();
            this.TipoLayout.ResumeLayout(false);
            this.TipoLayout.PerformLayout();
            this.CategoriaLayout.ResumeLayout(false);
            this.CategoriaLayout.PerformLayout();
            this.UnidadMedidaLabel.ResumeLayout(false);
            this.UnidadMedidaLabel.PerformLayout();
            this.ValorLabel.ResumeLayout(false);
            this.ValorLabel.PerformLayout();
            this.NombreLayout.ResumeLayout(false);
            this.NombreLayout.PerformLayout();
            this.BotonesLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel InfoLayout;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.TableLayoutPanel TipoLayout;
        private System.Windows.Forms.TableLayoutPanel CategoriaLayout;
        private System.Windows.Forms.TableLayoutPanel UnidadMedidaLabel;
        private System.Windows.Forms.TableLayoutPanel ValorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel NombreLayout;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TableLayoutPanel BotonesLayout;
        private System.Windows.Forms.Label TipoLabel;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox ValorTB;
        private System.Windows.Forms.ComboBox TipoCB;
        private System.Windows.Forms.TextBox CategoriaTB;
        private System.Windows.Forms.TextBox UnidadMedidaTB;
        private System.Windows.Forms.Button AgregarPropiedad;
    }
}

namespace Sintagri.UI.UsersControl
{
    partial class InventarioControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioControl));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.InfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InventarioGridView = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manofacturera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModoAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AgregarProducto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DetalleProducto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BusquedaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BusquedaInputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BusquedaLabel = new System.Windows.Forms.Label();
            this.BusquedaInputText = new System.Windows.Forms.TextBox();
            this.BuscarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SeparatorTOP = new Bunifu.Framework.UI.BunifuSeparator();
            this.MainLayout.SuspendLayout();
            this.InfoLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.BusquedaLayout.SuspendLayout();
            this.BusquedaInputLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.White;
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.289925F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.28307F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.427005F));
            this.MainLayout.Controls.Add(this.bunifuSeparator2, 2, 0);
            this.MainLayout.Controls.Add(this.bunifuSeparator1, 0, 0);
            this.MainLayout.Controls.Add(this.InfoLayout, 1, 1);
            this.MainLayout.Controls.Add(this.SeparatorTOP, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.Size = new System.Drawing.Size(1459, 785);
            this.MainLayout.TabIndex = 0;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(94)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(1413, 4);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(42, 31);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(94)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 4);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(40, 31);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // InfoLayout
            // 
            this.InfoLayout.ColumnCount = 1;
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoLayout.Controls.Add(this.InventarioGridView, 0, 1);
            this.InfoLayout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.InfoLayout.Controls.Add(this.BusquedaLayout, 0, 0);
            this.InfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLayout.Location = new System.Drawing.Point(51, 42);
            this.InfoLayout.Name = "InfoLayout";
            this.InfoLayout.RowCount = 3;
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.57143F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.57143F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InfoLayout.Size = new System.Drawing.Size(1355, 700);
            this.InfoLayout.TabIndex = 0;
            // 
            // InventarioGridView
            // 
            this.InventarioGridView.AllowUserToAddRows = false;
            this.InventarioGridView.AllowUserToDeleteRows = false;
            this.InventarioGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventarioGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InventarioGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventarioGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InventarioGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventarioGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.NombreComercial,
            this.Tipo_Producto,
            this.NumeroSAG,
            this.Manofacturera,
            this.ModoAccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventarioGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.InventarioGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventarioGridView.Location = new System.Drawing.Point(3, 139);
            this.InventarioGridView.Name = "InventarioGridView";
            this.InventarioGridView.RowHeadersWidth = 51;
            this.InventarioGridView.RowTemplate.Height = 24;
            this.InventarioGridView.Size = new System.Drawing.Size(1349, 476);
            this.InventarioGridView.TabIndex = 0;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            // 
            // NombreComercial
            // 
            this.NombreComercial.HeaderText = "Nombre Comercial";
            this.NombreComercial.MinimumWidth = 6;
            this.NombreComercial.Name = "NombreComercial";
            // 
            // Tipo_Producto
            // 
            this.Tipo_Producto.HeaderText = "Tipo de Producto";
            this.Tipo_Producto.MinimumWidth = 6;
            this.Tipo_Producto.Name = "Tipo_Producto";
            // 
            // NumeroSAG
            // 
            this.NumeroSAG.HeaderText = "Numero SAG";
            this.NumeroSAG.MinimumWidth = 6;
            this.NumeroSAG.Name = "NumeroSAG";
            // 
            // Manofacturera
            // 
            this.Manofacturera.HeaderText = "Manofacturera";
            this.Manofacturera.MinimumWidth = 6;
            this.Manofacturera.Name = "Manofacturera";
            // 
            // ModoAccion
            // 
            this.ModoAccion.HeaderText = "Modo de Acción";
            this.ModoAccion.MinimumWidth = 6;
            this.ModoAccion.Name = "ModoAccion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.AgregarProducto, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DetalleProducto, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 621);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1349, 76);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.ActiveBorderThickness = 1;
            this.AgregarProducto.ActiveCornerRadius = 20;
            this.AgregarProducto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.ActiveForecolor = System.Drawing.Color.White;
            this.AgregarProducto.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.BackColor = System.Drawing.Color.White;
            this.AgregarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgregarProducto.BackgroundImage")));
            this.AgregarProducto.ButtonText = "Ingresar un Nuevo Producto";
            this.AgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProducto.ForeColor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.IdleBorderThickness = 2;
            this.AgregarProducto.IdleCornerRadius = 20;
            this.AgregarProducto.IdleFillColor = System.Drawing.Color.White;
            this.AgregarProducto.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.Location = new System.Drawing.Point(1016, 5);
            this.AgregarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(328, 66);
            this.AgregarProducto.TabIndex = 3;
            this.AgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AgregarProducto.Click += new System.EventHandler(this.IngresarProducto_Click);
            // 
            // DetalleProducto
            // 
            this.DetalleProducto.ActiveBorderThickness = 1;
            this.DetalleProducto.ActiveCornerRadius = 20;
            this.DetalleProducto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DetalleProducto.ActiveForecolor = System.Drawing.Color.White;
            this.DetalleProducto.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DetalleProducto.BackColor = System.Drawing.Color.White;
            this.DetalleProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DetalleProducto.BackgroundImage")));
            this.DetalleProducto.ButtonText = "Ver Detalle de Producto";
            this.DetalleProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetalleProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetalleProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleProducto.ForeColor = System.Drawing.Color.SeaGreen;
            this.DetalleProducto.IdleBorderThickness = 2;
            this.DetalleProducto.IdleCornerRadius = 20;
            this.DetalleProducto.IdleFillColor = System.Drawing.Color.White;
            this.DetalleProducto.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.DetalleProducto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DetalleProducto.Location = new System.Drawing.Point(5, 5);
            this.DetalleProducto.Margin = new System.Windows.Forms.Padding(5);
            this.DetalleProducto.Name = "DetalleProducto";
            this.DetalleProducto.Size = new System.Drawing.Size(327, 66);
            this.DetalleProducto.TabIndex = 0;
            this.DetalleProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BusquedaLayout
            // 
            this.BusquedaLayout.ColumnCount = 2;
            this.BusquedaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BusquedaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 651F));
            this.BusquedaLayout.Controls.Add(this.BusquedaInputLayout, 0, 0);
            this.BusquedaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaLayout.Location = new System.Drawing.Point(3, 3);
            this.BusquedaLayout.Name = "BusquedaLayout";
            this.BusquedaLayout.RowCount = 1;
            this.BusquedaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BusquedaLayout.Size = new System.Drawing.Size(1349, 130);
            this.BusquedaLayout.TabIndex = 2;
            // 
            // BusquedaInputLayout
            // 
            this.BusquedaInputLayout.ColumnCount = 1;
            this.BusquedaInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BusquedaInputLayout.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.BusquedaInputLayout.Controls.Add(this.BuscarButton, 0, 1);
            this.BusquedaInputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaInputLayout.Location = new System.Drawing.Point(3, 3);
            this.BusquedaInputLayout.Name = "BusquedaInputLayout";
            this.BusquedaInputLayout.RowCount = 2;
            this.BusquedaInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BusquedaInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BusquedaInputLayout.Size = new System.Drawing.Size(692, 124);
            this.BusquedaInputLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.31778F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.68222F));
            this.tableLayoutPanel2.Controls.Add(this.BusquedaLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BusquedaInputText, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 56);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BusquedaLabel
            // 
            this.BusquedaLabel.AutoSize = true;
            this.BusquedaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaLabel.Location = new System.Drawing.Point(3, 0);
            this.BusquedaLabel.Name = "BusquedaLabel";
            this.BusquedaLabel.Size = new System.Drawing.Size(249, 56);
            this.BusquedaLabel.TabIndex = 0;
            this.BusquedaLabel.Text = "Buscar";
            this.BusquedaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BusquedaInputText
            // 
            this.BusquedaInputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusquedaInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaInputText.Location = new System.Drawing.Point(258, 10);
            this.BusquedaInputText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BusquedaInputText.Name = "BusquedaInputText";
            this.BusquedaInputText.Size = new System.Drawing.Size(425, 34);
            this.BusquedaInputText.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.ActiveBorderThickness = 1;
            this.BuscarButton.ActiveCornerRadius = 20;
            this.BuscarButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BuscarButton.ActiveForecolor = System.Drawing.Color.White;
            this.BuscarButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BuscarButton.BackColor = System.Drawing.Color.White;
            this.BuscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarButton.BackgroundImage")));
            this.BuscarButton.ButtonText = "Buscar";
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.BuscarButton.IdleBorderThickness = 3;
            this.BuscarButton.IdleCornerRadius = 20;
            this.BuscarButton.IdleFillColor = System.Drawing.Color.White;
            this.BuscarButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BuscarButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BuscarButton.Location = new System.Drawing.Point(15, 67);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(662, 52);
            this.BuscarButton.TabIndex = 1;
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarEvent_Click);
            // 
            // SeparatorTOP
            // 
            this.SeparatorTOP.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorTOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeparatorTOP.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(94)))));
            this.SeparatorTOP.LineThickness = 2;
            this.SeparatorTOP.Location = new System.Drawing.Point(52, 4);
            this.SeparatorTOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeparatorTOP.Name = "SeparatorTOP";
            this.SeparatorTOP.Size = new System.Drawing.Size(1353, 31);
            this.SeparatorTOP.TabIndex = 1;
            this.SeparatorTOP.Transparency = 255;
            this.SeparatorTOP.Vertical = false;
            // 
            // InventarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayout);
            this.Name = "InventarioControl";
            this.Size = new System.Drawing.Size(1459, 785);
            this.MainLayout.ResumeLayout(false);
            this.InfoLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventarioGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.BusquedaLayout.ResumeLayout(false);
            this.BusquedaInputLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel InfoLayout;
        private System.Windows.Forms.DataGridView InventarioGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 AgregarProducto;
        private Bunifu.Framework.UI.BunifuThinButton2 DetalleProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manofacturera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModoAccion;
        private System.Windows.Forms.TableLayoutPanel BusquedaLayout;
        private System.Windows.Forms.TableLayoutPanel BusquedaInputLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label BusquedaLabel;
        private System.Windows.Forms.TextBox BusquedaInputText;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator SeparatorTOP;
        private Bunifu.Framework.UI.BunifuThinButton2 BuscarButton;
    }
}

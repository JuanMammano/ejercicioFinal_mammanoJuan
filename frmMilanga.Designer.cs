namespace ejercicioFinal_mammanoJuan
{
    partial class frmMilanga
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvVentas;
        private Button btnValidar;
        private Button btnMozoDelDia;
        private TextBox txtMozoDelDia;
        private Label lblTotalMozo;
        private TextBox txtTotalMozo;
        private Button btnTotales;
        private Label lblTotalComidas;
        private TextBox txtTotalComidas;
        private Label lblTotalBebidasSinAlcohol;
        private TextBox txtTotalBebidasSinAlcohol;
        private Label lblTotalBebidasConAlcohol;
        private TextBox txtTotalBebidasConAlcohol;
        private Label lblTotalPostres;
        private TextBox txtTotalPostres;
        private Label lblTotalGeneral;
        private TextBox txtTotalGeneral;
        private Button btnSalir;

        /// <summary>
        /// Libera los recursos utilizados por el formulario.
        /// </summary>
        /// <param name="disposing">Indica si también deben liberarse los recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Crea los controles de la ventana y configura sus propiedades iniciales y eventos.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            btnValidar = new Button();
            btnMozoDelDia = new Button();
            txtMozoDelDia = new TextBox();
            lblTotalMozo = new Label();
            txtTotalMozo = new TextBox();
            btnTotales = new Button();
            lblTotalComidas = new Label();
            txtTotalComidas = new TextBox();
            lblTotalBebidasSinAlcohol = new Label();
            txtTotalBebidasSinAlcohol = new TextBox();
            lblTotalBebidasConAlcohol = new Label();
            txtTotalBebidasConAlcohol = new TextBox();
            lblTotalPostres = new Label();
            txtTotalPostres = new TextBox();
            lblTotalGeneral = new Label();
            txtTotalGeneral = new TextBox();
            btnSalir = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvVentas.Location = new Point(20, 65);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 120;
            dgvVentas.Size = new Size(880, 270);
            dgvVentas.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(20, 355);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(150, 35);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Enabled = false;
            btnMozoDelDia.Location = new Point(20, 410);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(150, 35);
            btnMozoDelDia.TabIndex = 2;
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            // 
            // txtMozoDelDia
            // 
            txtMozoDelDia.Location = new Point(185, 416);
            txtMozoDelDia.Name = "txtMozoDelDia";
            txtMozoDelDia.ReadOnly = true;
            txtMozoDelDia.Size = new Size(190, 23);
            txtMozoDelDia.TabIndex = 3;
            // 
            // lblTotalMozo
            // 
            lblTotalMozo.AutoSize = true;
            lblTotalMozo.Location = new Point(400, 420);
            lblTotalMozo.Name = "lblTotalMozo";
            lblTotalMozo.Size = new Size(36, 15);
            lblTotalMozo.TabIndex = 4;
            lblTotalMozo.Text = "Total:";
            // 
            // txtTotalMozo
            // 
            txtTotalMozo.Location = new Point(445, 416);
            txtTotalMozo.Name = "txtTotalMozo";
            txtTotalMozo.ReadOnly = true;
            txtTotalMozo.Size = new Size(150, 23);
            txtTotalMozo.TabIndex = 5;
            // 
            // btnTotales
            // 
            btnTotales.Enabled = false;
            btnTotales.Location = new Point(20, 480);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(150, 35);
            btnTotales.TabIndex = 6;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // lblTotalComidas
            // 
            lblTotalComidas.AutoSize = true;
            lblTotalComidas.Location = new Point(185, 465);
            lblTotalComidas.Name = "lblTotalComidas";
            lblTotalComidas.Size = new Size(54, 15);
            lblTotalComidas.TabIndex = 7;
            lblTotalComidas.Text = "Comidas";
            // 
            // txtTotalComidas
            // 
            txtTotalComidas.Location = new Point(185, 485);
            txtTotalComidas.Name = "txtTotalComidas";
            txtTotalComidas.ReadOnly = true;
            txtTotalComidas.Size = new Size(125, 23);
            txtTotalComidas.TabIndex = 8;
            // 
            // lblTotalBebidasSinAlcohol
            // 
            lblTotalBebidasSinAlcohol.AutoSize = true;
            lblTotalBebidasSinAlcohol.Location = new Point(320, 465);
            lblTotalBebidasSinAlcohol.Name = "lblTotalBebidasSinAlcohol";
            lblTotalBebidasSinAlcohol.Size = new Size(108, 15);
            lblTotalBebidasSinAlcohol.TabIndex = 9;
            lblTotalBebidasSinAlcohol.Text = "Bebidas sin alcohol";
            // 
            // txtTotalBebidasSinAlcohol
            // 
            txtTotalBebidasSinAlcohol.Location = new Point(320, 485);
            txtTotalBebidasSinAlcohol.Name = "txtTotalBebidasSinAlcohol";
            txtTotalBebidasSinAlcohol.ReadOnly = true;
            txtTotalBebidasSinAlcohol.Size = new Size(125, 23);
            txtTotalBebidasSinAlcohol.TabIndex = 10;
            // 
            // lblTotalBebidasConAlcohol
            // 
            lblTotalBebidasConAlcohol.AutoSize = true;
            lblTotalBebidasConAlcohol.Location = new Point(455, 465);
            lblTotalBebidasConAlcohol.Name = "lblTotalBebidasConAlcohol";
            lblTotalBebidasConAlcohol.Size = new Size(113, 15);
            lblTotalBebidasConAlcohol.TabIndex = 11;
            lblTotalBebidasConAlcohol.Text = "Bebidas con alcohol";
            // 
            // txtTotalBebidasConAlcohol
            // 
            txtTotalBebidasConAlcohol.Location = new Point(455, 485);
            txtTotalBebidasConAlcohol.Name = "txtTotalBebidasConAlcohol";
            txtTotalBebidasConAlcohol.ReadOnly = true;
            txtTotalBebidasConAlcohol.Size = new Size(125, 23);
            txtTotalBebidasConAlcohol.TabIndex = 12;
            // 
            // lblTotalPostres
            // 
            lblTotalPostres.AutoSize = true;
            lblTotalPostres.Location = new Point(590, 465);
            lblTotalPostres.Name = "lblTotalPostres";
            lblTotalPostres.Size = new Size(45, 15);
            lblTotalPostres.TabIndex = 13;
            lblTotalPostres.Text = "Postres";
            // 
            // txtTotalPostres
            // 
            txtTotalPostres.Location = new Point(590, 485);
            txtTotalPostres.Name = "txtTotalPostres";
            txtTotalPostres.ReadOnly = true;
            txtTotalPostres.Size = new Size(125, 23);
            txtTotalPostres.TabIndex = 14;
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(725, 465);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(75, 15);
            lblTotalGeneral.TabIndex = 15;
            lblTotalGeneral.Text = "Total general";
            // 
            // txtTotalGeneral
            // 
            txtTotalGeneral.Location = new Point(725, 485);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.ReadOnly = true;
            txtTotalGeneral.Size = new Size(125, 23);
            txtTotalGeneral.TabIndex = 16;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(750, 555);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 35);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Cerrar aplicación";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Comidas";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Bebidas sin alcohol";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Bebidas con alcohol";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Postres";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 620);
            Controls.Add(btnSalir);
            Controls.Add(txtTotalGeneral);
            Controls.Add(lblTotalGeneral);
            Controls.Add(txtTotalPostres);
            Controls.Add(lblTotalPostres);
            Controls.Add(txtTotalBebidasConAlcohol);
            Controls.Add(lblTotalBebidasConAlcohol);
            Controls.Add(txtTotalBebidasSinAlcohol);
            Controls.Add(lblTotalBebidasSinAlcohol);
            Controls.Add(txtTotalComidas);
            Controls.Add(lblTotalComidas);
            Controls.Add(btnTotales);
            Controls.Add(txtTotalMozo);
            Controls.Add(lblTotalMozo);
            Controls.Add(txtMozoDelDia);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnValidar);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar La Milanga - Ventas diarias";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

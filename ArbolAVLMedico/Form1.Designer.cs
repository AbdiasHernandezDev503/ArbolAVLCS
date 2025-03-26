namespace ArbolAVLMedico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelContenedor = new Panel();
            pbArbol = new PictureBox();
            panel1 = new Panel();
            btnAnalisis = new Button();
            btnExportar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnAgregar = new Button();
            cbPresion = new ComboBox();
            lblPresion = new Label();
            cbTipoSangre = new ComboBox();
            lblTipoSangre = new Label();
            cbGenero = new ComboBox();
            lblGenero = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDatos = new Label();
            toolTipBtn = new ToolTip(components);
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArbol).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.AutoScroll = true;
            panelContenedor.BorderStyle = BorderStyle.FixedSingle;
            panelContenedor.Controls.Add(pbArbol);
            panelContenedor.Location = new Point(11, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1081, 683);
            panelContenedor.TabIndex = 0;
            // 
            // pbArbol
            // 
            pbArbol.Location = new Point(0, -1);
            pbArbol.Name = "pbArbol";
            pbArbol.Size = new Size(1077, 657);
            pbArbol.TabIndex = 0;
            pbArbol.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnAnalisis);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cbPresion);
            panel1.Controls.Add(lblPresion);
            panel1.Controls.Add(cbTipoSangre);
            panel1.Controls.Add(lblTipoSangre);
            panel1.Controls.Add(cbGenero);
            panel1.Controls.Add(lblGenero);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblDatos);
            panel1.Location = new Point(1109, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 620);
            panel1.TabIndex = 1;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Cursor = Cursors.Hand;
            btnAnalisis.Location = new Point(263, 431);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(140, 35);
            btnAnalisis.TabIndex = 16;
            btnAnalisis.Text = "Análisis";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnExportar
            // 
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.Location = new Point(27, 483);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(376, 38);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar como PNG";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(25, 540);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(378, 35);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(145, 431);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 35);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(27, 431);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 36);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(25, 377);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(369, 39);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbPresion
            // 
            cbPresion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPresion.FormattingEnabled = true;
            cbPresion.Items.AddRange(new object[] { "SELECCIONAR", "Alta", "Media", "Baja" });
            cbPresion.Location = new Point(25, 328);
            cbPresion.Name = "cbPresion";
            cbPresion.Size = new Size(369, 28);
            cbPresion.TabIndex = 9;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresion.Location = new Point(26, 301);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(64, 24);
            lblPresion.TabIndex = 8;
            lblPresion.Text = "Presión";
            // 
            // cbTipoSangre
            // 
            cbTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoSangre.FormattingEnabled = true;
            cbTipoSangre.Items.AddRange(new object[] { "SELECCIONAR", "A", "B", "AB", "O" });
            cbTipoSangre.Location = new Point(25, 259);
            cbTipoSangre.Name = "cbTipoSangre";
            cbTipoSangre.Size = new Size(369, 28);
            cbTipoSangre.TabIndex = 7;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoSangre.Location = new Point(25, 229);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(118, 24);
            lblTipoSangre.TabIndex = 6;
            lblTipoSangre.Text = "Tipo de sangre";
            // 
            // cbGenero
            // 
            cbGenero.Cursor = Cursors.Hand;
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "SELECCIONAR", "FEMENINO", "MASCULINO" });
            cbGenero.Location = new Point(25, 181);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(369, 28);
            cbGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Cursor = Cursors.IBeam;
            lblGenero.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.Black;
            lblGenero.Location = new Point(25, 155);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(64, 24);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Cursor = Cursors.IBeam;
            lblNombre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(25, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(161, 24);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre del paciente";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(369, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.Location = new Point(25, 15);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(248, 32);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "Datos del paciente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1531, 707);
            Controls.Add(panel1);
            Controls.Add(panelContenedor);
            Name = "Form1";
            Text = "Form1";
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArbol).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panel1;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDatos;
        private ComboBox cbGenero;
        private Label lblGenero;
        private Label lblTipoSangre;
        private ComboBox cbTipoSangre;
        private ComboBox cbPresion;
        private Label lblPresion;
        private Button btnAgregar;
        private PictureBox pbArbol;
        private Button btnBuscar;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnExportar;
        private Button btnAnalisis;
        private ToolTip toolTipBtn;
    }
}
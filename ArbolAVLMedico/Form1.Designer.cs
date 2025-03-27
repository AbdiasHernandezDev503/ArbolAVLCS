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
            panelContenedor.Location = new Point(10, 9);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(946, 513);
            panelContenedor.TabIndex = 0;
            // 
            // pbArbol
            // 
            pbArbol.Location = new Point(0, -1);
            pbArbol.Margin = new Padding(3, 2, 3, 2);
            pbArbol.Name = "pbArbol";
            pbArbol.Size = new Size(942, 493);
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
            panel1.Location = new Point(970, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 466);
            panel1.TabIndex = 1;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Cursor = Cursors.Hand;
            btnAnalisis.Location = new Point(230, 323);
            btnAnalisis.Margin = new Padding(3, 2, 3, 2);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(122, 26);
            btnAnalisis.TabIndex = 16;
            btnAnalisis.Text = "Análisis";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnExportar
            // 
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.Location = new Point(24, 362);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(329, 28);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar como PNG";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(22, 405);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(331, 26);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(127, 323);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 26);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(24, 323);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 27);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(22, 283);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(323, 29);
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
            cbPresion.Location = new Point(22, 246);
            cbPresion.Margin = new Padding(3, 2, 3, 2);
            cbPresion.Name = "cbPresion";
            cbPresion.Size = new Size(323, 23);
            cbPresion.TabIndex = 9;
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresion.Location = new Point(23, 226);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(55, 20);
            lblPresion.TabIndex = 8;
            lblPresion.Text = "Presión";
            // 
            // cbTipoSangre
            // 
            cbTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoSangre.FormattingEnabled = true;
            cbTipoSangre.Items.AddRange(new object[] { "SELECCIONAR", "A", "B", "AB", "O" });
            cbTipoSangre.Location = new Point(22, 194);
            cbTipoSangre.Margin = new Padding(3, 2, 3, 2);
            cbTipoSangre.Name = "cbTipoSangre";
            cbTipoSangre.Size = new Size(323, 23);
            cbTipoSangre.TabIndex = 7;
            // 
            // lblTipoSangre
            // 
            lblTipoSangre.AutoSize = true;
            lblTipoSangre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoSangre.Location = new Point(22, 172);
            lblTipoSangre.Name = "lblTipoSangre";
            lblTipoSangre.Size = new Size(100, 20);
            lblTipoSangre.TabIndex = 6;
            lblTipoSangre.Text = "Tipo de sangre";
            // 
            // cbGenero
            // 
            cbGenero.Cursor = Cursors.Hand;
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "SELECCIONAR", "FEMENINO", "MASCULINO" });
            cbGenero.Location = new Point(22, 136);
            cbGenero.Margin = new Padding(3, 2, 3, 2);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(323, 23);
            cbGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Cursor = Cursors.IBeam;
            lblGenero.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.Black;
            lblGenero.Location = new Point(22, 116);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(54, 20);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Cursor = Cursors.IBeam;
            lblNombre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(22, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(135, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre del paciente";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 80);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(323, 23);
            txtNombre.TabIndex = 1;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.Location = new Point(22, 11);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(209, 27);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "Datos del paciente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1340, 530);
            Controls.Add(panel1);
            Controls.Add(panelContenedor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Sistema de Gestión de Pacientes";
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
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
            panelDibujo = new Panel();
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDibujo
            // 
            panelDibujo.BorderStyle = BorderStyle.FixedSingle;
            panelDibujo.Location = new Point(11, 12);
            panelDibujo.Name = "panelDibujo";
            panelDibujo.Size = new Size(978, 642);
            panelDibujo.TabIndex = 0;
            panelDibujo.Paint += panelDibujo_Paint;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
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
            panel1.Size = new Size(412, 489);
            panel1.TabIndex = 1;
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
            ClientSize = new Size(1531, 707);
            Controls.Add(panel1);
            Controls.Add(panelDibujo);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDibujo;
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
    }
}
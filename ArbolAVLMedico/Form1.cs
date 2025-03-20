namespace ArbolAVLMedico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblNombre.Font = new Font("Arial", 12);
            lblGenero.Font = new Font("Arial", 12);
            lblGenero.ForeColor = Color.Blue;
            lblTipoSangre.Font = new Font("Arial", 12);
            lblTipoSangre.ForeColor = Color.Blue;
            lblPresion.Font = new Font("Arial", 12);
            lblPresion.ForeColor = Color.Blue;

            cbGenero.SelectedIndex = 0;
            cbTipoSangre.SelectedIndex = 0;
            cbPresion.SelectedIndex = 0;
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            lblNombre.Location = new Point(txtNombre.Left, txtNombre.Top - 20);
            lblNombre.ForeColor = Color.Blue;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblNombre.Font = new Font("Arial", 12);
                lblNombre.Location = new Point(txtNombre.Left, txtNombre.Top + 3);
                lblNombre.ForeColor = Color.Gray;
                lblNombre.BackColor = Color.Transparent;
            }

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
    }
}
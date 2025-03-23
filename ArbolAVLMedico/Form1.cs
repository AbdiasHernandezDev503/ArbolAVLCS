namespace ArbolAVLMedico
{
    public partial class Form1 : Form
    {
        private ArbolPaciente arbol;
        Dictionary<NodoPaciente, Point> posiciones = new Dictionary<NodoPaciente, Point>();
        int nextX = 40;  // Posición X inicial para ir colocando nodos
        int espacioHorizontal = 100;
        int espacioVertical = 60;

        public Form1()
        {
            InitializeComponent();

            arbol = new ArbolPaciente();
            this.DoubleBuffered = true; // Suaviza el renderizado
            this.Paint += panelDibujo_Paint;

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
            if (arbol?.Raiz != null)
            {
                posiciones.Clear();
                nextX = 40;

                CalcularPosiciones(arbol.Raiz, 0);
                DibujarArbol(e.Graphics, arbol.Raiz);
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string genero = cbGenero.SelectedItem?.ToString();
            string tipoSangre = cbTipoSangre.SelectedItem?.ToString();
            string presion = cbPresion.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombre) || genero == null || tipoSangre == null || presion == null)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Paciente paciente = new Paciente(nombre, genero, tipoSangre, presion);
            arbol.AgregarPaciente(paciente);

            panelDibujo.Invalidate(); // Esto fuerza el evento Paint
        }

        void CalcularPosiciones(NodoPaciente nodo, int nivel)
        {
            int y = nivel * espacioVertical;

            if (nodo.Hijos.Count == 0)
            {
                posiciones[nodo] = new Point(nextX, y);
                nextX += espacioHorizontal;
            }
            else
            {
                foreach (var hijo in nodo.Hijos)
                {
                    CalcularPosiciones(hijo, nivel + 1);
                }

                // Centrar nodo padre entre el primero y último hijo
                int xInicio = posiciones[nodo.Hijos.First()].X;
                int xFin = posiciones[nodo.Hijos.Last()].X;
                int xCentro = (xInicio + xFin) / 2;
                posiciones[nodo] = new Point(xCentro, y);
            }
        }

        void DibujarArbol(Graphics g, NodoPaciente nodo)
        {
            Font font = new Font("Arial", 9);
            Point punto = posiciones[nodo];

            SizeF size = g.MeasureString(nodo.Categoria, font);
            Rectangle rect = new Rectangle(punto.X, punto.Y, (int)size.Width + 10, 25);

            g.FillEllipse(Brushes.White, rect);
            g.DrawEllipse(Pens.Black, rect);
            g.DrawString(nodo.Categoria, font, Brushes.Black, rect.X + 5, rect.Y + 5);

            foreach (var hijo in nodo.Hijos)
            {
                Point hijoPunto = posiciones[hijo];
                g.DrawLine(Pens.Black,
                    punto.X + rect.Width / 2, punto.Y + rect.Height,
                    hijoPunto.X + 30, hijoPunto.Y);
                DibujarArbol(g, hijo);
            }
        }


        private void DibujarNodo(Graphics g, NodoPaciente nodo, Font font, int x, int y)
        {
            SizeF size = g.MeasureString(nodo.Categoria, font);
            Rectangle rect = new Rectangle(x, y, 60, 25);
            g.FillEllipse(Brushes.White, rect);
            g.DrawEllipse(Pens.Black, rect);
            g.DrawString(nodo.Categoria, font, Brushes.Black, x + 5, y + 5);
        }
    }
}
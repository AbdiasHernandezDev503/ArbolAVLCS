namespace ArbolAVLMedico
{
    public partial class Form1 : Form
    {
        private ArbolPaciente arbol;
        private Dictionary<NodoPaciente, Point> posiciones = new Dictionary<NodoPaciente, Point>();
        private int nextX = 40;
        private int espacioHorizontal = 100;
        private int espacioVertical = 60;
        int nivelMax = 0;
        private Point posicionRaiz;

        public Form1()
        {
            InitializeComponent();

            arbol = new ArbolPaciente();

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

        private void DibujarArbolEnImagen()
        {
            // Calcular las posiciones primero para determinar el tamaño
            posiciones.Clear();
            nextX = 40;
            nivelMax = 0;
            CalcularPosiciones(arbol.Raiz, 0);

            int ancho = nextX + 100;
            int alto = (nivelMax + 1) * espacioVertical + 100;

            Bitmap bmp = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                DibujarArbol(g, arbol.Raiz);
            }

            pbArbol.Image = bmp;
            pbArbol.Size = bmp.Size;

            // Mueve el scroll hacia la raíz después de dibujar
            panelContenedor.ScrollControlIntoView(pbArbol);
            panelContenedor.AutoScrollPosition = new Point(
                Math.Max(0, posicionRaiz.X - panelContenedor.Width / 2),
                Math.Max(0, posicionRaiz.Y - panelContenedor.Height / 4)
            );

            // Desplaza el scroll horizontal al final si la imagen creció
            if (pbArbol.Width > panelContenedor.ClientSize.Width)
            {
                panelContenedor.HorizontalScroll.Value = panelContenedor.HorizontalScroll.Maximum;
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
            string sangre = cbTipoSangre.SelectedItem?.ToString();
            string presion = cbPresion.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || genero == null || sangre == null || presion == null)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Agrega el paciente al árbol dinámicamente
            AgregarPacienteDesdeFormulario(genero, sangre, presion, nombre);

            // Limpiar campos opcionalmente
            txtNombre.Clear();
            cbGenero.SelectedIndex = -1;
            cbTipoSangre.SelectedIndex = -1;
            cbPresion.SelectedIndex = -1;
        }

        // Método para calcular la posición de los nodos
        private void CalcularPosiciones(NodoPaciente nodo, int nivel)
        {
            nivelMax = Math.Max(nivelMax, nivel);
            int y = nivel * espacioVertical;

            if (nodo.Hijos.Count == 0)
            {
                posiciones[nodo] = new Point(nextX, y);
                nextX += espacioHorizontal;

                if (nivel == 0)
                    posicionRaiz = posiciones[nodo];
            }
            else
            {
                foreach (var hijo in nodo.Hijos)
                {
                    CalcularPosiciones(hijo, nivel + 1);
                }

                int xInicio = posiciones[nodo.Hijos.First()].X;
                int xFin = posiciones[nodo.Hijos.Last()].X;
                int xCentro = (xInicio + xFin) / 2;
                posiciones[nodo] = new Point(xCentro, y);

                if (nivel == 0)
                    posicionRaiz = posiciones[nodo];
            }
        }

        private void DibujarArbol(Graphics g, NodoPaciente nodo)
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

                // Centro inferior del nodo padre
                int padreX = punto.X + rect.Width / 2;
                int padreY = punto.Y + rect.Height;

                // Calcular tamaño del hijo para conectar al centro exacto
                SizeF hijoSize = g.MeasureString(hijo.Categoria, font);
                Rectangle hijoRect = new Rectangle(hijoPunto.X, hijoPunto.Y, (int)hijoSize.Width + 10, 25);

                int hijoX = hijoRect.X + hijoRect.Width / 2;
                int hijoY = hijoRect.Y;

                g.DrawLine(Pens.Black, padreX, padreY, hijoX, hijoY);

                DibujarArbol(g, hijo);
            }
        }

        private void AgregarPacienteDesdeFormulario(string genero, string sangre, string presion, string nombre)
        {
            // Validar si el paciente ya existe en el árbol
            if (arbol.Raiz.ExistePaciente(nombre))
            {
                MessageBox.Show("Ese paciente ya ha sido registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente paciente = new Paciente();
            paciente.Nombre = nombre;
            paciente.Genero = genero;
            paciente.TipoSangre = sangre;
            paciente.Presion = presion;

            arbol.AgregarPaciente(paciente);
            DibujarArbolEnImagen();
        }
    }
}
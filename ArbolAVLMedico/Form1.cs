using System.Drawing.Printing;

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
        private List<NodoPaciente> nodosResaltados = new List<NodoPaciente>();
        private string contenidoParaImprimir = "";
        private string rutaPDF = "";

        public Form1()
        {
            InitializeComponent();

            arbol = new ArbolPaciente();

            this.BackColor = Color.FromArgb(242, 242, 242); // Fondo general

            panelContenedor.BackColor = Color.White;
            panelContenedor.BorderStyle = BorderStyle.FixedSingle;

            lblNombre.Font = new Font("Segoe UI", 12);
            lblGenero.Font = new Font("Segoe UI", 12);
            lblTipoSangre.Font = new Font("Segoe UI", 12);
            lblPresion.Font = new Font("Segoe UI", 12);

            lblNombre.ForeColor = Color.FromArgb(33, 37, 41);
            lblGenero.ForeColor = Color.FromArgb(33, 37, 41);
            lblTipoSangre.ForeColor = Color.FromArgb(33, 37, 41);
            lblPresion.ForeColor = Color.FromArgb(33, 37, 41);

            txtNombre.BackColor = Color.FromArgb(245, 245, 245);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;

            cbGenero.BackColor = Color.FromArgb(245, 245, 245);
            cbGenero.FlatStyle = FlatStyle.Flat;

            cbTipoSangre.BackColor = Color.FromArgb(245, 245, 245);
            cbTipoSangre.FlatStyle = FlatStyle.Flat;

            cbPresion.BackColor = Color.FromArgb(245, 245, 245);
            cbPresion.FlatStyle = FlatStyle.Flat;

            EstilizarBoton(btnAgregar, "agregar");
            EstilizarBoton(btnBuscar, "buscar");
            EstilizarBoton(btnEliminar, "eliminar");
            EstilizarBoton(btnSalir, "salir");
            EstilizarBoton(btnExportar, "agregar");  // Seteamos el mismo estilo que el botón de agregar
            EstilizarBoton(btnAnalisis, "salir");  // Seteamos el mismo estilo que el botón de salir

            // Agregar tooltip a los botones informativos para saber que hace cada uno
            toolTipBtn.SetToolTip(btnAgregar, "Agregar nuevo paciente al árbol");
            toolTipBtn.SetToolTip(btnBuscar, "Buscar paciente por nombre");
            toolTipBtn.SetToolTip(btnEliminar, "Eliminar paciente por nombre");
            toolTipBtn.SetToolTip(btnSalir, "Cerrar la aplicación");
            toolTipBtn.SetToolTip(btnExportar, "Exportar el árbol como imagen PNG");
            toolTipBtn.SetToolTip(btnAnalisis, "Analizar pacientes según filtros seleccionados");

            toolTipBtn.AutoPopDelay = 5000;
            toolTipBtn.InitialDelay = 500;
            toolTipBtn.ReshowDelay = 100;
            toolTipBtn.ShowAlways = true;

            cbGenero.SelectedIndex = 0;
            cbTipoSangre.SelectedIndex = 0;
            cbPresion.SelectedIndex = 0;

            btnExportar.Visible = false;
        }

        private void EstilizarBoton(Button boton, string tipo)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.ForeColor = Color.Black;
            boton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
            boton.Height = 35;

            Color backColor, hoverColor;

            switch (tipo.ToLower())
            {
                case "agregar":
                    backColor = ColorTranslator.FromHtml("#A9DFBF");   // Verde suave
                    hoverColor = ColorTranslator.FromHtml("#7DCEA0");  // Verde medio
                    break;
                case "buscar":
                    backColor = ColorTranslator.FromHtml("#AED6F1");   // Azul suave
                    hoverColor = ColorTranslator.FromHtml("#85C1E9");  // Azul medio
                    break;
                case "eliminar":
                    backColor = ColorTranslator.FromHtml("#F5B7B1");   // Rojo suave
                    hoverColor = ColorTranslator.FromHtml("#EC7063");  // Rojo medio
                    break;
                case "salir":
                    backColor = ColorTranslator.FromHtml("#D5DBDB");   // Gris claro
                    hoverColor = ColorTranslator.FromHtml("#BFC9CA");  // Gris medio
                    break;
                default:
                    backColor = Color.LightGray;
                    hoverColor = Color.Gray;
                    break;
            }

            boton.BackColor = backColor;
            boton.FlatAppearance.MouseOverBackColor = hoverColor;

            boton.MouseEnter += (s, e) =>
            {
                boton.FlatAppearance.BorderSize = 1;
                boton.FlatAppearance.BorderColor = Color.DarkGray;
            };

            boton.MouseLeave += (s, e) =>
            {
                boton.FlatAppearance.BorderSize = 0;
            };
        }



        private void DibujarArbolEnImagen()
        {
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

            panelContenedor.ScrollControlIntoView(pbArbol);
            panelContenedor.AutoScrollPosition = new Point(
                Math.Max(0, posicionRaiz.X - panelContenedor.Width / 2),
                Math.Max(0, posicionRaiz.Y - panelContenedor.Height / 4)
            );

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

            AgregarPacienteDesdeFormulario(nombre, genero, sangre, presion);

            btnExportar.Visible = true;

            txtNombre.Clear();
            cbGenero.SelectedIndex = -1;
            cbTipoSangre.SelectedIndex = -1;
            cbPresion.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombreBuscar))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            nodosResaltados.Clear();
            BuscarTodosLosPacientes(arbol.Raiz, nombreBuscar);

            if (nodosResaltados.Count == 0)
            {
                MessageBox.Show("Paciente no encontrado.");
            }

            DibujarArbolEnImagen();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreEliminar = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombreEliminar))
            {
                MessageBox.Show("Ingrese un nombre para eliminar.");
                return;
            }

            EliminarPacientesPorNombre(arbol.Raiz, nombreEliminar);
            MessageBox.Show("Eliminación completada.");

            nodosResaltados.Clear();
            DibujarArbolEnImagen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarArbolComoImagen();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            string genero = cbGenero.SelectedItem?.ToString();
            string sangre = cbTipoSangre.SelectedItem?.ToString();
            string presion = cbPresion.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(sangre) || string.IsNullOrEmpty(presion))
            {
                MessageBox.Show("Por favor selecciona todos los filtros antes de analizar.", "Filtros incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pacientes = BuscarPacientesEspecificos(genero, sangre, presion);
            MarcarPacientesResaltados(genero, sangre, presion);
            DibujarArbolEnImagen();

            if (pacientes.Count > 0)
            {
                string mensaje = $"Se encontraron {pacientes.Count} paciente(s) con:\n\n" +
                                 $"📍 Género: {genero}\n🩸 Sangre: {sangre}\n📈 Presión: {presion}\n\n" +
                                 $"Nombres: {string.Join(", ", pacientes)}";

                // Mensaje si la presión NO es MEDIA o NORMAL
                if (!presion.Equals("MEDIA", StringComparison.OrdinalIgnoreCase))
                {
                    mensaje += "\n\n⚠️ Este grupo está en posible riesgo de:\n\n";
                }

                // Riesgos combinados según tipo de sangre y presión
                if (sangre.Equals("A", StringComparison.OrdinalIgnoreCase))
                {
                    if (presion.Equals("ALTA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " ❤️  Riesgo elevado de infarto\n" +
                                   " 🧠 ACV (derrame cerebral)\n" +
                                   " 🫀  Insuficiencia cardíaca.";
                    }
                    else if (presion.Equals("BAJA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " 😵 Mareos, debilidad y desmayos\n" +
                                   " ☣️ Riesgo de shock si hay coagulopatías";
                    }
                    else
                    {
                        mensaje += "\n\n 🩺  Recomendación:\n" +
                                   " 🩺  Chequeos regulares\n" +
                                   " 🥗 Dieta balanceada";

                    }
                }
                else if (sangre.Equals("B", StringComparison.OrdinalIgnoreCase))
                {
                    if (presion.Equals("ALTA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " 🍬 Riesgo de diabetes tipo 2\n" +
                                   " 🧬 Daño renal ";
                    }
                    else if (presion.Equals("BAJA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " 🤕 Dolores de cabeza\n" +
                                   " 🪫 Fatiga frecuente";
                    }
                    else
                    {
                        mensaje += "\n\n 🩺  Recomendación:\n" +
                                   " 🧪 Control glucémico\n" +
                                   " 🏃 Actividad física recomendada";
                    }
                }
                else if (sangre.Equals("AB", StringComparison.OrdinalIgnoreCase))
                {
                    if (presion.Equals("ALTA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " 🧠 Riesgo alto de deterioro cognitivo\n" +
                                   " 🧓 Posible demencia vascular";
                    }
                    else if (presion.Equals("BAJA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " 😴 Dificultad para concentrarse o dormir\n" +
                                   " 🤸‍♂️ Inestabilidad física";
                    }
                    else
                    {
                        mensaje += "\n\n 🩺  Recomendación:\n" +
                                   " 🌿 Estilo de vida activo recomendado\n" +
                                   " 🧠 Control neurocognitivo";
                    }
                }
                else if (sangre.Equals("O", StringComparison.OrdinalIgnoreCase))
                {
                    if (presion.Equals("ALTA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " 💥 Riesgo de sangrado cerebral si hay debilidad vascular";
                    }
                    else if (presion.Equals("BAJA", StringComparison.OrdinalIgnoreCase))
                    {
                        mensaje += " 🩸 Riesgo de anemia\n" +
                                   " 🪫 Fatiga";
                    }
                    else
                    {
                        mensaje += "\n\n 🩺  Recomendación:\n" +
                                   " 🧻 Prevención digestiva\n" +
                                   " 🩸 Control de hierro";
                    }
                }

                MessageBox.Show(mensaje, "Análisis de pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (presion.Equals("ALTA", StringComparison.OrdinalIgnoreCase))
                {
                    DialogResult respuesta = MessageBox.Show(
                        "¿Deseas descargar un reporte de los pacientes con posibles riesgos de salud?",
                        "Generar reporte PDF",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        // Ejecutar método para imprimir el contenido en un PDF
                        ImprimirComoPDF(mensaje);
                    }
                }

            }
            else
            {
                MessageBox.Show("No se encontraron pacientes con esos filtros.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            cbGenero.SelectedIndex = -1;
            cbTipoSangre.SelectedIndex = -1;
            cbPresion.SelectedIndex = -1;
        }

        private void ImprimirComoPDF(string contenido)
        {
            contenidoParaImprimir = contenido;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.Title = "Guardar análisis como PDF";
                sfd.FileName = "Reporte_Pacientes_Presion_Alta.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    rutaPDF = sfd.FileName;

                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(PrintPage);
                    pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    pd.PrinterSettings.PrintToFile = true;
                    pd.PrinterSettings.PrintFileName = rutaPDF;

                    try
                    {
                        pd.Print();
                        MessageBox.Show("📄 PDF generado correctamente en:\n" + rutaPDF, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Segoe UI Emoji", 12);
            float y = e.MarginBounds.Top;
            int saltoLinea = 25;

            using (StringReader sr = new StringReader(contenidoParaImprimir))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    e.Graphics.DrawString(linea, font, Brushes.Black, e.MarginBounds.Left, y);
                    y += saltoLinea;
                }
            }
        }

        private void BuscarTodosLosPacientes(NodoPaciente nodo, string nombre)
        {
            if (nodo == null) return;

            if (nodo.Categoria.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                nodosResaltados.Add(nodo);
            }

            foreach (var hijo in nodo.Hijos)
            {
                BuscarTodosLosPacientes(hijo, nombre);
            }
        }

        private bool EliminarPacientesPorNombre(NodoPaciente nodo, string nombre)
        {
            if (nodo == null) return false;

            bool eliminado = false;

            for (int i = nodo.Hijos.Count - 1; i >= 0; i--)
            {
                var hijo = nodo.Hijos[i];

                // Si el hijo es el paciente
                if (hijo.Categoria.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    nodo.Hijos.RemoveAt(i);
                    eliminado = true;
                    continue;
                }

                // Recorremos hijos recursivamente
                bool hijoEliminado = EliminarPacientesPorNombre(hijo, nombre);
                if (hijoEliminado)
                {
                    // Si después de eliminar, el hijo quedó vacío y no es categoría base ni valor permitido, lo eliminamos
                    if (hijo.Hijos.Count == 0 && !EsCategoriaBase(hijo.Categoria) && !EsValorDeCategoria(hijo))
                    {
                        nodo.Hijos.RemoveAt(i);
                    }
                    eliminado = true;
                }

                if (!EsCategoriaBase(hijo.Categoria) && EsValorDeCategoria(hijo))
                {
                    if (hijo.Hijos.Count == 0)
                    {
                        // MessageBox.Show($"El nodo {hijo.Categoria} ya no tiene hijos y será eliminado.");
                        nodo.Hijos.RemoveAt(i);
                    }
                }
            }

            return eliminado;
        }

        private bool EsCategoriaBase(string categoria)
        {
            return categoria.Equals("Género", StringComparison.OrdinalIgnoreCase)
                || categoria.Equals("Sangre", StringComparison.OrdinalIgnoreCase)
                || categoria.Equals("Presión", StringComparison.OrdinalIgnoreCase);
        }

        private bool EsValorDeCategoria(NodoPaciente nodo)
        {
            string[] valoresPermitidos =
            {
                "FEMENINO", "MASCULINO",
                "A", "B", "AB", "O",
                "ALTA", "MEDIA", "BAJA"
            };

            return valoresPermitidos.Contains(nodo.Categoria.ToUpper());
        }


        private void CalcularPosiciones(NodoPaciente nodo, int nivel)
        {
            if (nodo == null) return;

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
            if (nodo == null) return;

            Font font = new Font("Arial", 9);
            Point punto = posiciones[nodo];

            SizeF size = g.MeasureString(nodo.Categoria, font);
            Rectangle rect = new Rectangle(punto.X, punto.Y, (int)size.Width + 10, 25);

            Brush fondo = Brushes.White;
            Pen borde = Pens.Black;

            if (nodosResaltados.Contains(nodo))
            {
                fondo = Brushes.Yellow;
                borde = Pens.Red;
            }
            else if (EsCategoriaBase(nodo.Categoria))
            {
                fondo = Brushes.LightSteelBlue;  // Género, Sangre, Presión
                borde = Pens.SteelBlue;
            }
            else if (EsValorDeCategoria(nodo))
            {
                fondo = Brushes.Honeydew; // MASCULINO, O, Alta, etc.
                borde = Pens.Green;
            }
            else
            {
                fondo = Brushes.LightSalmon; // Pacientes
                borde = Pens.DarkRed;
            }

            g.FillEllipse(fondo, rect);
            g.DrawEllipse(borde, rect);
            g.DrawString(nodo.Categoria, font, Brushes.Black, rect.X + 5, rect.Y + 5);

            foreach (var hijo in nodo.Hijos)
            {
                Point hijoPunto = posiciones[hijo];

                int padreX = punto.X + rect.Width / 2;
                int padreY = punto.Y + rect.Height;

                SizeF hijoSize = g.MeasureString(hijo.Categoria, font);
                Rectangle hijoRect = new Rectangle(hijoPunto.X, hijoPunto.Y, (int)hijoSize.Width + 10, 25);

                int hijoX = hijoRect.X + hijoRect.Width / 2;
                int hijoY = hijoRect.Y;

                g.DrawLine(Pens.Black, padreX, padreY, hijoX, hijoY);

                DibujarArbol(g, hijo);
            }
        }

        private void AgregarPacienteDesdeFormulario(string nombre, string genero, string sangre, string presion)
        {
            // Validar si el paciente ya existe en el arbol
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


        private void ExportarArbolComoImagen()
        {
            if (pbArbol.Image != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo PNG (*.png)|*.png";
                    sfd.Title = "Guardar árbol como imagen";
                    sfd.FileName = "ArbolPacientes.png";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pbArbol.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Árbol exportado exitosamente!!", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay imagen que exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> BuscarPacientesEspecificos(string genero, string tipoSangre, string presion)
        {
            List<string> encontrados = new List<string>();

            var nodoGenero = arbol.Raiz.Hijos.FirstOrDefault(n => n.Categoria == "Género")?
                .Hijos.FirstOrDefault(h => h.Categoria.Equals(genero, StringComparison.OrdinalIgnoreCase));

            var nodoSangre = arbol.Raiz.Hijos.FirstOrDefault(n => n.Categoria == "Sangre")?
                .Hijos.FirstOrDefault(h => h.Categoria.Equals(tipoSangre, StringComparison.OrdinalIgnoreCase));

            var nodoPresion = arbol.Raiz.Hijos.FirstOrDefault(n => n.Categoria == "Presión")?
                .Hijos.FirstOrDefault(h => h.Categoria.Equals(presion, StringComparison.OrdinalIgnoreCase));

            if (nodoGenero != null && nodoSangre != null && nodoPresion != null)
            {
                var enGenero = nodoGenero.Hijos.Select(p => p.Categoria).ToList();
                var enSangre = nodoSangre.Hijos.Select(p => p.Categoria).ToList();
                var enPresion = nodoPresion.Hijos.Select(p => p.Categoria).ToList();

                encontrados = enGenero.Intersect(enSangre).Intersect(enPresion).ToList();
            }

            return encontrados;
        }

        private void MarcarPacientesResaltados(string genero, string sangre, string presion)
        {
            nodosResaltados.Clear();

            var nombres = BuscarPacientesEspecificos(genero, sangre, presion);

            // Recorre todo el árbol para encontrar los nodos que coinciden
            void BuscarYMarcar(NodoPaciente nodo)
            {
                if (nombres.Contains(nodo.Categoria, StringComparer.OrdinalIgnoreCase))
                {
                    nodosResaltados.Add(nodo);
                }

                foreach (var hijo in nodo.Hijos)
                {
                    BuscarYMarcar(hijo);
                }
            }

            BuscarYMarcar(arbol.Raiz);
        }

    }
}

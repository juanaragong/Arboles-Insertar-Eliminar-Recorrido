using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace P1U4_0080_0510_ED3B
{
    public partial class Form1 : Form
    {
        readonly ErrorProvider error = new ErrorProvider();
        string transicion;
        readonly Arbol_Binario arbolito = new Arbol_Binario(null);//crear el objeto del arbol
        Graphics g;
        ToolTip viñetaBoton = new ToolTip();
        ToolTip viñetaRadioBtn = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            RedondearBoton(btn_guardar,30);
            RedondearBoton(Btn_profundidad, 30);
            RedondearBoton(Btn_recorrer, 30);
            viñetaBoton.SetToolTip(Btn_mostrarInfo, "Información del Arbol");
            viñetaBoton.SetToolTip(Btn_mostrarOcultar, "Opciones");
            viñetaBoton.SetToolTip(Btn_vaciarTodo, "Borrar Arbol");
            viñetaBoton.SetToolTip(btn_guardar, "Inicio");
            viñetaBoton.SetToolTip(Btn_profundidad, "Profundidad de un nodo");
            viñetaBoton.SetToolTip(Btn_recorrer,"Recorrido del arbol");
            viñetaRadioBtn.SetToolTip(Rb_inorden, "Izquierda - Nodo - Derecha");
            viñetaRadioBtn.SetToolTip(Rb_preOrden, "Nodo - Izquierda - Derecha");
            viñetaRadioBtn.SetToolTip(Rb_postOrden, "Izquierda, Derecha, Nodo");
            viñetaRadioBtn.InitialDelay = 100;
            viñetaBoton.IsBalloon = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            arbolito.DibujarArbol(g, this.Font, Pens.Black, Brushes.White);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            error.Clear();
            try
            {
                if (string.IsNullOrEmpty(txt_nodo.Text))
                {
                    error.SetError(txt_nodo, "El campo no puede estar vacío.");
                    SystemSounds.Hand.Play();
                    return;
                }
                if (!rb_insertar.Checked && !rb_eliminar.Checked && !rb_buscar.Checked)
                {
                    MessageBox.Show("Seleccione una acción (Insertar, Eliminar o Buscar) antes de continuar.", "ERROR - ARBOL BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txt_nodo.Text, out int dato))
                {
                    txt_nodo.Clear();
                    throw new FormatException("El valor de 'NODO' debe contener un valor númerico valido.");
                }

                if (dato <= 0 || dato >= 100)
                {
                    error.SetError(txt_nodo, "El valor de ´NODO´ debe de estar entre 1 y 99.");
                    SystemSounds.Hand.Play();
                    return;
                }
                else
                {
                    if (rb_insertar.Checked)
                    {
                        Console.Beep(700, 400);
                        arbolito.Insertar(dato);
                        txt_nodo.Clear();
                        txt_nodo.Focus();
                        Refresh();
                    }
                    else if (rb_eliminar.Checked)
                    {
                        if (!arbolito.BuscarExisteNodo(dato))
                        {
                            MessageBox.Show("El nodo no existe en el árbol. No se puede eliminar.", "ERROR - NODO NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_nodo.Clear();
                            txt_nodo.Focus();
                            return;
                        }
                        Console.Beep(700, 400);
                        arbolito.Eliminar(dato);
                        txt_nodo.Clear();
                        txt_nodo.Focus();
                        Refresh();
                    }
                    else if (rb_buscar.Checked)
                    {
                        Console.Beep(700, 400);
                        arbolito.Buscar(dato);
                        txt_nodo.Clear();
                        txt_nodo.Focus();
                        Refresh();
                    }
                    lb_alturaArbol.Text = arbolito.ObtenerAltura(arbolito.Raiz).ToString();
                    lb_nodosArbol.Text = arbolito.ContarTotalNodos().ToString();
                    lb_sumavalorNodos.Text = arbolito.SumarNodos(arbolito.Raiz).ToString();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR DE FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_profundidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (arbolito.Raiz == null)
                {
                    MessageBox.Show("Debe haber por lo menos una inserción en el árbol. No se puede obtener profundidad", "ERROR - ÁRBOL VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string mensaje = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nodo del que desea conocer su profundidad: ", "PROFUNDIDAD - ARBOL BINARIO", "", -1, -1);

                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("Ingrese un valor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(mensaje, out int nodoBuscar))
                {
                    MessageBox.Show("Ingrese un valor numérico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int profundidad = arbolito.ObtenerProfundidad(nodoBuscar);


                if (profundidad == -1)
                {
                    MessageBox.Show("El nodo no existe en el árbol.", "SIN ENCONTRAR - ARBOL BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("La profundidad del nodo " +nodoBuscar+ " desde la raíz es: " +profundidad, "PROFUNDIDAD - ARBOL BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_recorrer_Click(object sender, EventArgs e)
        {
            lb_resultado.Text = "";
            if (arbolito.Raiz == null)
            {
                MessageBox.Show("El árbol está vacío. No se puede realizar el recorrido.", "ERROR - ÁRBOL VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Rb_inorden.Checked && !Rb_postOrden.Checked && !Rb_preOrden.Checked)
            {
                MessageBox.Show("Seleccione un tipo de recorrido (Inorden, Postorden o Preorden) antes de continuar.", "ERROR - TIPO DE RECORRIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Rb_preOrden.Checked)
            {
                lb_resultado.ForeColor = Color.Gold;
                lb_resultado.Text = "PreOr " + arbolito.recorrer(false, false, true);
            }
            else if (Rb_inorden.Checked)
            {
                lb_resultado.ForeColor = Color.YellowGreen;
                lb_resultado.Text = "InOr " + arbolito.recorrer(true, false, false);
            }
            else if (Rb_postOrden.Checked)
            {
                lb_resultado.ForeColor = Color.Turquoise;
                lb_resultado.Text = "PosOr " + arbolito.recorrer(false, true, false);
            }
        }

        private void Btn_vaciarTodo_Click(object sender, EventArgs e)
        {
            arbolito.Vaciar();
            rb_buscar.Checked = false;
            rb_eliminar.Checked = false;
            rb_insertar.Checked = false;
            lb_alturaArbol.Text = "0";
            lb_nodosArbol.Text = "0";
            lb_resultado.Text = "Recorrido";
            lb_sumavalorNodos.Text = "0";
            Refresh();
            MessageBox.Show("Nuevo Arbol Binario", "ARBOL BINARIO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        #region TransicionForm
        private void Form1_Load(object sender, EventArgs e)
        {
            transicion = "Entrada";
            this.Top += 15;
            tmTransicion.Start();
            TmPanel.Interval = 20;
            pnl_infoarbol.Height = 0;
        }

        private void TmTransicion_Tick(object sender, EventArgs e)
        {
            if (transicion == "Entrada")
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                    this.Top -= 2;
                }
                else
                {
                    tmTransicion.Stop(); 
                }
            }

            else if (transicion == "Cerrar")
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                    this.Left += 2;
                }
                else
                {
                    tmTransicion.Stop();
                    Application.Exit();
                }
            }

            else if (transicion == "Minimizar")
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05; 
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Opacity = 1; 
                    tmTransicion.Stop(); 
                }
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar la aplicación?", "ARBOL BINARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                transicion = "Cerrar";
                tmTransicion.Start();
            }
        }

        private void Btn_minimizr_Click(object sender, EventArgs e)
        {
            transicion = "Minimizar";
            tmTransicion.Start();
            SystemSounds.Beep.Play();
        }

        public void RedondearBoton(Button boton, int radio)
        {
            Rectangle rectangulo = new Rectangle(0, 0, boton.Width, boton.Height); //rectángulo con los mismos límites que el botón
            using (GraphicsPath borde = new GraphicsPath()) //gráfico para el botón
            {
                borde.AddArc(rectangulo.X, rectangulo.Y, radio, radio, 180, 90);
                borde.AddArc(rectangulo.X + rectangulo.Width - radio, rectangulo.Y, radio, radio, 270, 90);
                borde.AddArc(rectangulo.X + rectangulo.Width - radio, rectangulo.Y + rectangulo.Height - radio, radio, radio, 0, 90);
                borde.AddArc(rectangulo.X, rectangulo.Y + rectangulo.Height - radio, radio, radio, 90, 90);
                borde.CloseFigure();
                boton.Region = new Region(borde); //aplicar la forma al botón
            }
        }

        #endregion

        #region TransicionMenuOpciones
        bool panelExpandidoMENUOPCIONES = true;
        readonly int panelAnchoMaxMENU = 170;
        readonly int panelAnchoMinMENU = 35;
        readonly int velocidad = 5;

        private void Btn_mostrarOcultar_Click(object sender, EventArgs e)
        {
            panelExpandidoMENUOPCIONES = !panelExpandidoMENUOPCIONES;
            TmPanel.Start();
        }

        private void TmPanel_Tick(object sender, EventArgs e)
        {
            if (panelExpandidoMENUOPCIONES) //expandir panel
            {
                if (pnl_menuOpciones.Width < panelAnchoMaxMENU)  //si el panel no ha alcanzado su tamaño máximo
                {
                    //expandir el ancho de los paneles y su contenido
                    pnl_menuOpciones.Width = Math.Min(pnl_menuOpciones.Width + velocidad, panelAnchoMaxMENU);
                    panel1.Width = pnl_menuOpciones.Width;
                    panel5.Width = pnl_menuOpciones.Width;
                }
                else
                {
                    TmPanel.Stop(); //si el panel alcanzo su tamaño máximo, el temporizador se detiene
                    pnl_menuOpciones.Width = panelAnchoMaxMENU;
                    panel1.Width = pnl_menuOpciones.Width;
                    panel5.Width = pnl_menuOpciones.Width;
                    panel1.Visible = true;
                    panel5.Visible = true;
                }
            }
            else //contraer paneles
            {
                if (pnl_menuOpciones.Width > panelAnchoMinMENU) //si el panel no ha alcanzado su tamaño minimo
                {
                    //reducir el ancho del panel y su contenido
                    pnl_menuOpciones.Width = Math.Max(pnl_menuOpciones.Width - velocidad, panelAnchoMinMENU);
                    panel1.Width = pnl_menuOpciones.Width;
                    panel5.Width = pnl_menuOpciones.Width;
                }
                else
                {
                    TmPanel.Stop(); //si paneles alcanzaron su tam minimo temporizador se detiene
                    pnl_menuOpciones.Width = panelAnchoMinMENU;
                    panel1.Width = pnl_menuOpciones.Width;
                    panel5.Width = pnl_menuOpciones.Width;
                    panel1.Visible = false;
                    panel5.Visible = false;
                }
            }
            Btn_mostrarOcultar.Location = new Point(pnl_menuOpciones.Width + 10, Btn_mostrarOcultar.Location.Y); //mover los botones a la par de los paneles
            Btn_vaciarTodo.Location = new Point(pnl_menuOpciones.Width + 12, Btn_vaciarTodo.Location.Y);
            Btn_mostrarInfo.Location = new Point(pnl_menuOpciones.Width + 12,Btn_mostrarInfo.Location.Y);
        }
        #endregion

        #region TransicionMenuInformacion
        private int alturapanelInfo = 80;
        private int panelAnimacion = 10;
        private bool panelVisible = false;

        private void Tm_OcultarPanel_Tick(object sender, EventArgs e)
        {
            if (pnl_infoarbol.Height > 0) //si la altura del panel es mayor a 0 reducir la altura del panel
            {
                pnl_infoarbol.Height -= panelAnimacion; //ir reduciendo la altura del panel
            }
            else
            {
                Tm_OcultarPanel.Stop(); //detener cuando el panel está oculto
            }
        }

        private void Tm_MostrarPanel_Tick(object sender, EventArgs e)
        {
            if (pnl_infoarbol.Height < alturapanelInfo) //si la altura del panel es menor a la establecida incrementar la altura
            {
                pnl_infoarbol.Height += panelAnimacion; //ir aumentando la altura del panel
            }
            else
            {
                Tm_MostrarPanel.Stop(); //detener cuando el panel está visible
            }
        }

        private void Btn_mostrarInfo_Click(object sender, EventArgs e)
        {
            if (panelVisible)
            { //si panel es visible, timer para ocultar el panel
                Tm_MostrarPanel.Stop(); 
                Tm_OcultarPanel.Start();
                panelVisible = false;
            }
            else
            {//si el panel esta oculto, timer para mostrar el panel
                Tm_OcultarPanel.Stop(); 
                Tm_MostrarPanel.Start();
                panelVisible = true;
            }
        }
        #endregion
    }
}

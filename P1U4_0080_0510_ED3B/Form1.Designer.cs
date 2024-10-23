namespace P1U4_0080_0510_ED3B
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nodo = new System.Windows.Forms.TextBox();
            this.rb_insertar = new System.Windows.Forms.RadioButton();
            this.rb_eliminar = new System.Windows.Forms.RadioButton();
            this.rb_buscar = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.tmTransicion = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lb_alturaArbol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_infoarbol = new System.Windows.Forms.Panel();
            this.lb_sumavalorNodos = new System.Windows.Forms.Label();
            this.Btn_profundidad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_nodosArbol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizr = new System.Windows.Forms.Button();
            this.Btn_mostrarOcultar = new System.Windows.Forms.Button();
            this.TmPanel = new System.Windows.Forms.Timer(this.components);
            this.Btn_vaciarTodo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Rb_postOrden = new System.Windows.Forms.RadioButton();
            this.Rb_inorden = new System.Windows.Forms.RadioButton();
            this.Rb_preOrden = new System.Windows.Forms.RadioButton();
            this.Btn_recorrer = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_menuOpciones = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_mostrarInfo = new System.Windows.Forms.Button();
            this.Tm_OcultarPanel = new System.Windows.Forms.Timer(this.components);
            this.Tm_MostrarPanel = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_infoarbol.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_menuOpciones.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NODO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELECCIONAR OPCIÓN:";
            // 
            // txt_nodo
            // 
            this.txt_nodo.Location = new System.Drawing.Point(107, 23);
            this.txt_nodo.Name = "txt_nodo";
            this.txt_nodo.Size = new System.Drawing.Size(77, 26);
            this.txt_nodo.TabIndex = 2;
            // 
            // rb_insertar
            // 
            this.rb_insertar.AutoSize = true;
            this.rb_insertar.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_insertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_insertar.Location = new System.Drawing.Point(68, 96);
            this.rb_insertar.Name = "rb_insertar";
            this.rb_insertar.Size = new System.Drawing.Size(103, 28);
            this.rb_insertar.TabIndex = 3;
            this.rb_insertar.TabStop = true;
            this.rb_insertar.Text = "Insertar";
            this.rb_insertar.UseVisualStyleBackColor = true;
            // 
            // rb_eliminar
            // 
            this.rb_eliminar.AutoSize = true;
            this.rb_eliminar.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_eliminar.Location = new System.Drawing.Point(68, 127);
            this.rb_eliminar.Name = "rb_eliminar";
            this.rb_eliminar.Size = new System.Drawing.Size(107, 28);
            this.rb_eliminar.TabIndex = 4;
            this.rb_eliminar.TabStop = true;
            this.rb_eliminar.Text = "Eliminar";
            this.rb_eliminar.UseVisualStyleBackColor = true;
            // 
            // rb_buscar
            // 
            this.rb_buscar.AutoSize = true;
            this.rb_buscar.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_buscar.Location = new System.Drawing.Point(68, 160);
            this.rb_buscar.Name = "rb_buscar";
            this.rb_buscar.Size = new System.Drawing.Size(93, 28);
            this.rb_buscar.TabIndex = 5;
            this.rb_buscar.TabStop = true;
            this.rb_buscar.Text = "Buscar";
            this.rb_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(255)))), ((int)(((byte)(201)))));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(188)))), ((int)(((byte)(165)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(34, 201);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(169, 35);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // tmTransicion
            // 
            this.tmTransicion.Enabled = true;
            this.tmTransicion.Interval = 20;
            this.tmTransicion.Tick += new System.EventHandler(this.TmTransicion_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Altura";
            // 
            // lb_alturaArbol
            // 
            this.lb_alturaArbol.AutoSize = true;
            this.lb_alturaArbol.BackColor = System.Drawing.Color.Transparent;
            this.lb_alturaArbol.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alturaArbol.ForeColor = System.Drawing.Color.White;
            this.lb_alturaArbol.Location = new System.Drawing.Point(75, 41);
            this.lb_alturaArbol.Name = "lb_alturaArbol";
            this.lb_alturaArbol.Size = new System.Drawing.Size(18, 22);
            this.lb_alturaArbol.TabIndex = 8;
            this.lb_alturaArbol.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.Btn_profundidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rb_eliminar);
            this.panel1.Controls.Add(this.rb_insertar);
            this.panel1.Controls.Add(this.txt_nodo);
            this.panel1.Controls.Add(this.rb_buscar);
            this.panel1.Location = new System.Drawing.Point(18, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 307);
            this.panel1.TabIndex = 99;
            // 
            // pnl_infoarbol
            // 
            this.pnl_infoarbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.pnl_infoarbol.Controls.Add(this.panel2);
            this.pnl_infoarbol.Location = new System.Drawing.Point(553, 432);
            this.pnl_infoarbol.Name = "pnl_infoarbol";
            this.pnl_infoarbol.Size = new System.Drawing.Size(460, 111);
            this.pnl_infoarbol.TabIndex = 99;
            // 
            // lb_sumavalorNodos
            // 
            this.lb_sumavalorNodos.AutoSize = true;
            this.lb_sumavalorNodos.BackColor = System.Drawing.Color.Transparent;
            this.lb_sumavalorNodos.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sumavalorNodos.ForeColor = System.Drawing.Color.White;
            this.lb_sumavalorNodos.Location = new System.Drawing.Point(419, 39);
            this.lb_sumavalorNodos.Name = "lb_sumavalorNodos";
            this.lb_sumavalorNodos.Size = new System.Drawing.Size(18, 22);
            this.lb_sumavalorNodos.TabIndex = 13;
            this.lb_sumavalorNodos.Text = "0";
            // 
            // Btn_profundidad
            // 
            this.Btn_profundidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
            this.Btn_profundidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_profundidad.FlatAppearance.BorderSize = 0;
            this.Btn_profundidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(107)))), ((int)(((byte)(80)))));
            this.Btn_profundidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_profundidad.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_profundidad.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btn_profundidad.Location = new System.Drawing.Point(34, 253);
            this.Btn_profundidad.Name = "Btn_profundidad";
            this.Btn_profundidad.Size = new System.Drawing.Size(169, 38);
            this.Btn_profundidad.TabIndex = 7;
            this.Btn_profundidad.Text = "PROFUNDIDAD";
            this.Btn_profundidad.UseVisualStyleBackColor = false;
            this.Btn_profundidad.Click += new System.EventHandler(this.Btn_profundidad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(280, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Suma  de Nodos";
            // 
            // lb_nodosArbol
            // 
            this.lb_nodosArbol.AutoSize = true;
            this.lb_nodosArbol.BackColor = System.Drawing.Color.Transparent;
            this.lb_nodosArbol.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nodosArbol.ForeColor = System.Drawing.Color.White;
            this.lb_nodosArbol.Location = new System.Drawing.Point(245, 41);
            this.lb_nodosArbol.Name = "lb_nodosArbol";
            this.lb_nodosArbol.Size = new System.Drawing.Size(18, 22);
            this.lb_nodosArbol.TabIndex = 11;
            this.lb_nodosArbol.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(107)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(104, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "DATOS DEL ÁRBOL BINARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(111, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad Nodos";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(991, 9);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(22, 18);
            this.Btn_cerrar.TabIndex = 97;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_minimizr
            // 
            this.Btn_minimizr.BackColor = System.Drawing.Color.Transparent;
            this.Btn_minimizr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizr.BackgroundImage")));
            this.Btn_minimizr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_minimizr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_minimizr.FlatAppearance.BorderSize = 0;
            this.Btn_minimizr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.Btn_minimizr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.Btn_minimizr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizr.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_minimizr.Location = new System.Drawing.Point(955, 7);
            this.Btn_minimizr.Name = "Btn_minimizr";
            this.Btn_minimizr.Size = new System.Drawing.Size(20, 21);
            this.Btn_minimizr.TabIndex = 96;
            this.Btn_minimizr.UseVisualStyleBackColor = false;
            this.Btn_minimizr.Click += new System.EventHandler(this.Btn_minimizr_Click);
            // 
            // Btn_mostrarOcultar
            // 
            this.Btn_mostrarOcultar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_mostrarOcultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_mostrarOcultar.BackgroundImage")));
            this.Btn_mostrarOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_mostrarOcultar.FlatAppearance.BorderSize = 0;
            this.Btn_mostrarOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mostrarOcultar.Location = new System.Drawing.Point(264, 53);
            this.Btn_mostrarOcultar.Name = "Btn_mostrarOcultar";
            this.Btn_mostrarOcultar.Size = new System.Drawing.Size(28, 26);
            this.Btn_mostrarOcultar.TabIndex = 98;
            this.Btn_mostrarOcultar.UseVisualStyleBackColor = false;
            this.Btn_mostrarOcultar.Click += new System.EventHandler(this.Btn_mostrarOcultar_Click);
            // 
            // TmPanel
            // 
            this.TmPanel.Tick += new System.EventHandler(this.TmPanel_Tick);
            // 
            // Btn_vaciarTodo
            // 
            this.Btn_vaciarTodo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_vaciarTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_vaciarTodo.BackgroundImage")));
            this.Btn_vaciarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_vaciarTodo.FlatAppearance.BorderSize = 0;
            this.Btn_vaciarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_vaciarTodo.Location = new System.Drawing.Point(266, 503);
            this.Btn_vaciarTodo.Name = "Btn_vaciarTodo";
            this.Btn_vaciarTodo.Size = new System.Drawing.Size(28, 31);
            this.Btn_vaciarTodo.TabIndex = 99;
            this.Btn_vaciarTodo.UseVisualStyleBackColor = false;
            this.Btn_vaciarTodo.Click += new System.EventHandler(this.Btn_vaciarTodo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "SELECCIONAR RECORRIDO:";
            // 
            // Rb_postOrden
            // 
            this.Rb_postOrden.AutoSize = true;
            this.Rb_postOrden.BackColor = System.Drawing.Color.Transparent;
            this.Rb_postOrden.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_postOrden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rb_postOrden.Location = new System.Drawing.Point(58, 86);
            this.Rb_postOrden.Name = "Rb_postOrden";
            this.Rb_postOrden.Size = new System.Drawing.Size(126, 28);
            this.Rb_postOrden.TabIndex = 9;
            this.Rb_postOrden.TabStop = true;
            this.Rb_postOrden.Text = "PostOrden";
            this.Rb_postOrden.UseVisualStyleBackColor = false;
            // 
            // Rb_inorden
            // 
            this.Rb_inorden.AutoSize = true;
            this.Rb_inorden.BackColor = System.Drawing.Color.Transparent;
            this.Rb_inorden.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_inorden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rb_inorden.Location = new System.Drawing.Point(58, 55);
            this.Rb_inorden.Name = "Rb_inorden";
            this.Rb_inorden.Size = new System.Drawing.Size(103, 28);
            this.Rb_inorden.TabIndex = 8;
            this.Rb_inorden.TabStop = true;
            this.Rb_inorden.Text = "Inorden";
            this.Rb_inorden.UseVisualStyleBackColor = false;
            // 
            // Rb_preOrden
            // 
            this.Rb_preOrden.AutoSize = true;
            this.Rb_preOrden.BackColor = System.Drawing.Color.Transparent;
            this.Rb_preOrden.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_preOrden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rb_preOrden.Location = new System.Drawing.Point(58, 119);
            this.Rb_preOrden.Name = "Rb_preOrden";
            this.Rb_preOrden.Size = new System.Drawing.Size(118, 28);
            this.Rb_preOrden.TabIndex = 10;
            this.Rb_preOrden.TabStop = true;
            this.Rb_preOrden.Text = "PreOrden";
            this.Rb_preOrden.UseVisualStyleBackColor = false;
            // 
            // Btn_recorrer
            // 
            this.Btn_recorrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(242)))), ((int)(((byte)(4)))));
            this.Btn_recorrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_recorrer.FlatAppearance.BorderSize = 0;
            this.Btn_recorrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.Btn_recorrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_recorrer.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_recorrer.ForeColor = System.Drawing.Color.Black;
            this.Btn_recorrer.Location = new System.Drawing.Point(35, 163);
            this.Btn_recorrer.Name = "Btn_recorrer";
            this.Btn_recorrer.Size = new System.Drawing.Size(169, 39);
            this.Btn_recorrer.TabIndex = 7;
            this.Btn_recorrer.Text = "RECORRER";
            this.Btn_recorrer.UseVisualStyleBackColor = false;
            this.Btn_recorrer.Click += new System.EventHandler(this.Btn_recorrer_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_resultado.Location = new System.Drawing.Point(17, 73);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(95, 24);
            this.lb_resultado.TabIndex = 100;
            this.lb_resultado.Text = "Recorrido";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.Btn_cerrar);
            this.panel3.Controls.Add(this.Btn_minimizr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 37);
            this.panel3.TabIndex = 0;
            // 
            // pnl_menuOpciones
            // 
            this.pnl_menuOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.pnl_menuOpciones.Controls.Add(this.panel1);
            this.pnl_menuOpciones.Controls.Add(this.panel5);
            this.pnl_menuOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menuOpciones.Location = new System.Drawing.Point(0, 37);
            this.pnl_menuOpciones.Name = "pnl_menuOpciones";
            this.pnl_menuOpciones.Size = new System.Drawing.Size(259, 518);
            this.pnl_menuOpciones.TabIndex = 101;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.Btn_recorrer);
            this.panel5.Controls.Add(this.Rb_preOrden);
            this.panel5.Controls.Add(this.Rb_inorden);
            this.panel5.Controls.Add(this.Rb_postOrden);
            this.panel5.Location = new System.Drawing.Point(18, 297);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 221);
            this.panel5.TabIndex = 100;
            // 
            // Btn_mostrarInfo
            // 
            this.Btn_mostrarInfo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_mostrarInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_mostrarInfo.BackgroundImage")));
            this.Btn_mostrarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_mostrarInfo.FlatAppearance.BorderSize = 0;
            this.Btn_mostrarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mostrarInfo.Location = new System.Drawing.Point(266, 456);
            this.Btn_mostrarInfo.Name = "Btn_mostrarInfo";
            this.Btn_mostrarInfo.Size = new System.Drawing.Size(28, 31);
            this.Btn_mostrarInfo.TabIndex = 102;
            this.Btn_mostrarInfo.UseVisualStyleBackColor = false;
            this.Btn_mostrarInfo.Click += new System.EventHandler(this.Btn_mostrarInfo_Click);
            // 
            // Tm_OcultarPanel
            // 
            this.Tm_OcultarPanel.Interval = 20;
            this.Tm_OcultarPanel.Tick += new System.EventHandler(this.Tm_OcultarPanel_Tick);
            // 
            // Tm_MostrarPanel
            // 
            this.Tm_MostrarPanel.Interval = 20;
            this.Tm_MostrarPanel.Tick += new System.EventHandler(this.Tm_MostrarPanel_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_sumavalorNodos);
            this.panel2.Controls.Add(this.lb_resultado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_nodosArbol);
            this.panel2.Controls.Add(this.lb_alturaArbol);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 103);
            this.panel2.TabIndex = 103;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1025, 555);
            this.Controls.Add(this.Btn_mostrarInfo);
            this.Controls.Add(this.pnl_infoarbol);
            this.Controls.Add(this.pnl_menuOpciones);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Btn_vaciarTodo);
            this.Controls.Add(this.Btn_mostrarOcultar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_infoarbol.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_menuOpciones.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nodo;
        private System.Windows.Forms.RadioButton rb_insertar;
        private System.Windows.Forms.RadioButton rb_eliminar;
        private System.Windows.Forms.RadioButton rb_buscar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Timer tmTransicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_alturaArbol;
        private System.Windows.Forms.Label lb_nodosArbol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_profundidad;
        private System.Windows.Forms.Label lb_sumavalorNodos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizr;
        private System.Windows.Forms.Button Btn_mostrarOcultar;
        private System.Windows.Forms.Timer TmPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_infoarbol;
        private System.Windows.Forms.Button Btn_vaciarTodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Rb_postOrden;
        private System.Windows.Forms.RadioButton Rb_inorden;
        private System.Windows.Forms.RadioButton Rb_preOrden;
        private System.Windows.Forms.Button Btn_recorrer;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_menuOpciones;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_mostrarInfo;
        private System.Windows.Forms.Timer Tm_OcultarPanel;
        private System.Windows.Forms.Timer Tm_MostrarPanel;
        private System.Windows.Forms.Panel panel2;
    }
}


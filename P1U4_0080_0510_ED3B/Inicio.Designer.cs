namespace P1U4_0080_0510_ED3B
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Btn_iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TmTransicion = new System.Windows.Forms.Timer(this.components);
            this.pgbar_carga = new System.Windows.Forms.ProgressBar();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizr = new System.Windows.Forms.Button();
            this.pnl_barra = new System.Windows.Forms.Panel();
            this.lb_mensaje = new System.Windows.Forms.Label();
            this.TmCarga = new System.Windows.Forms.Timer(this.components);
            this.pnl_datos.SuspendLayout();
            this.pnl_barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_iniciar
            // 
            this.Btn_iniciar.BackColor = System.Drawing.Color.Gold;
            this.Btn_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_iniciar.FlatAppearance.BorderSize = 0;
            this.Btn_iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iniciar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_iniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_iniciar.Location = new System.Drawing.Point(131, 363);
            this.Btn_iniciar.Name = "Btn_iniciar";
            this.Btn_iniciar.Size = new System.Drawing.Size(183, 38);
            this.Btn_iniciar.TabIndex = 7;
            this.Btn_iniciar.Text = "INICIAR";
            this.Btn_iniciar.UseVisualStyleBackColor = false;
            this.Btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(98, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Árbol Binario";
            // 
            // TmTransicion
            // 
            this.TmTransicion.Enabled = true;
            this.TmTransicion.Interval = 20;
            this.TmTransicion.Tick += new System.EventHandler(this.TmTransicion_Tick);
            // 
            // pgbar_carga
            // 
            this.pgbar_carga.Location = new System.Drawing.Point(16, 14);
            this.pgbar_carga.Name = "pgbar_carga";
            this.pgbar_carga.Size = new System.Drawing.Size(370, 23);
            this.pgbar_carga.TabIndex = 9;
            // 
            // pnl_datos
            // 
            this.pnl_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_datos.Controls.Add(this.label2);
            this.pnl_datos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_datos.Location = new System.Drawing.Point(23, 262);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(399, 74);
            this.pnl_datos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maria Fernanda Ibarra Ibarra || 232310080\r\nGabriel Rodriguez Sanchez || 232310510" +
    "\r\n";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.Btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(410, 12);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(18, 16);
            this.Btn_cerrar.TabIndex = 99;
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
            this.Btn_minimizr.Location = new System.Drawing.Point(381, 11);
            this.Btn_minimizr.Name = "Btn_minimizr";
            this.Btn_minimizr.Size = new System.Drawing.Size(16, 19);
            this.Btn_minimizr.TabIndex = 98;
            this.Btn_minimizr.UseVisualStyleBackColor = false;
            this.Btn_minimizr.Click += new System.EventHandler(this.Btn_minimizr_Click);
            // 
            // pnl_barra
            // 
            this.pnl_barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_barra.Controls.Add(this.lb_mensaje);
            this.pnl_barra.Controls.Add(this.pgbar_carga);
            this.pnl_barra.Location = new System.Drawing.Point(21, 260);
            this.pnl_barra.Name = "pnl_barra";
            this.pnl_barra.Size = new System.Drawing.Size(399, 85);
            this.pnl_barra.TabIndex = 11;
            this.pnl_barra.Visible = false;
            // 
            // lb_mensaje
            // 
            this.lb_mensaje.AutoSize = true;
            this.lb_mensaje.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mensaje.Location = new System.Drawing.Point(155, 47);
            this.lb_mensaje.Name = "lb_mensaje";
            this.lb_mensaje.Size = new System.Drawing.Size(0, 29);
            this.lb_mensaje.TabIndex = 1;
            // 
            // TmCarga
            // 
            this.TmCarga.Tick += new System.EventHandler(this.TmCarga_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 428);
            this.Controls.Add(this.Btn_cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_minimizr);
            this.Controls.Add(this.Btn_iniciar);
            this.Controls.Add(this.pnl_datos);
            this.Controls.Add(this.pnl_barra);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            this.pnl_barra.ResumeLayout(false);
            this.pnl_barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TmTransicion;
        private System.Windows.Forms.ProgressBar pgbar_carga;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizr;
        private System.Windows.Forms.Panel pnl_barra;
        private System.Windows.Forms.Timer TmCarga;
        private System.Windows.Forms.Label lb_mensaje;
    }
}
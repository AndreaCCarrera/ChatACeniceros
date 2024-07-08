namespace ChatACeniceros
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.txtConversacion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btArrancar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.lbNick = new System.Windows.Forms.Label();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConversacion
            // 
            this.txtConversacion.Location = new System.Drawing.Point(61, 110);
            this.txtConversacion.Multiline = true;
            this.txtConversacion.Name = "txtConversacion";
            this.txtConversacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConversacion.Size = new System.Drawing.Size(326, 244);
            this.txtConversacion.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(61, 364);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(261, 28);
            this.txtMensaje.TabIndex = 2;
            // 
            // btEnviar
            // 
            this.btEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEnviar.FlatAppearance.BorderSize = 0;
            this.btEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviar.Location = new System.Drawing.Point(328, 364);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(59, 28);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "ENVIAR";
            this.btEnviar.UseVisualStyleBackColor = false;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // btArrancar
            // 
            this.btArrancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btArrancar.FlatAppearance.BorderSize = 0;
            this.btArrancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btArrancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArrancar.Location = new System.Drawing.Point(61, 19);
            this.btArrancar.Name = "btArrancar";
            this.btArrancar.Size = new System.Drawing.Size(87, 32);
            this.btArrancar.TabIndex = 4;
            this.btArrancar.Text = "ARRANCAR";
            this.btArrancar.UseVisualStyleBackColor = false;
            this.btArrancar.Click += new System.EventHandler(this.btArrancar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCerrar.FlatAppearance.BorderSize = 0;
            this.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCerrar.Location = new System.Drawing.Point(176, 415);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(92, 32);
            this.btCerrar.TabIndex = 5;
            this.btCerrar.Text = "SALIR";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btParar
            // 
            this.btParar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btParar.FlatAppearance.BorderSize = 0;
            this.btParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btParar.Location = new System.Drawing.Point(177, 19);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(90, 32);
            this.btParar.TabIndex = 6;
            this.btParar.Text = "PARAR";
            this.btParar.UseVisualStyleBackColor = false;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNick.Location = new System.Drawing.Point(64, 77);
            this.lbNick.Name = "lbNick";
            this.lbNick.Padding = new System.Windows.Forms.Padding(5);
            this.lbNick.Size = new System.Drawing.Size(172, 23);
            this.lbNick.TabIndex = 7;
            this.lbNick.Text = "USUARIO SELECCIONADO";
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(242, 79);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(145, 21);
            this.comboBoxUsuarios.TabIndex = 8;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLimpiar.FlatAppearance.BorderSize = 0;
            this.btLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(297, 19);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(90, 32);
            this.btLimpiar.TabIndex = 9;
            this.btLimpiar.Text = "LIMPIAR";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 465);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Controls.Add(this.lbNick);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btArrancar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtConversacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chat";
            this.Text = "Chatdrea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConversacion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Button btArrancar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Button btLimpiar;
    }
}


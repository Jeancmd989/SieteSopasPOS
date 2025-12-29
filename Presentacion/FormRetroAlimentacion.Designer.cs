namespace Presentacion
{
    partial class FormRetroAlimentacion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.cbIdCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarRetroalimentacion = new System.Windows.Forms.Button();
            this.cbTipoComentario = new System.Windows.Forms.ComboBox();
            this.cbCalificacion = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cbMesaRetroalimentacion = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbComenarioRetro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(81, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.Ivory;
            this.groupBox15.Controls.Add(this.tbComenarioRetro);
            this.groupBox15.Controls.Add(this.cbIdCliente);
            this.groupBox15.Controls.Add(this.label1);
            this.groupBox15.Controls.Add(this.btSalir);
            this.groupBox15.Controls.Add(this.dtFecha);
            this.groupBox15.Controls.Add(this.btnRegistrarRetroalimentacion);
            this.groupBox15.Controls.Add(this.cbTipoComentario);
            this.groupBox15.Controls.Add(this.cbCalificacion);
            this.groupBox15.Controls.Add(this.label25);
            this.groupBox15.Controls.Add(this.label26);
            this.groupBox15.Controls.Add(this.label27);
            this.groupBox15.Controls.Add(this.label28);
            this.groupBox15.Controls.Add(this.cbMesaRetroalimentacion);
            this.groupBox15.Controls.Add(this.label30);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(551, 13);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox15.Size = new System.Drawing.Size(497, 600);
            this.groupBox15.TabIndex = 104;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Filtro de calificación";
            // 
            // cbIdCliente
            // 
            this.cbIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdCliente.FormattingEnabled = true;
            this.cbIdCliente.Items.AddRange(new object[] {
            "M_01",
            "M_02",
            "M_03",
            "M_04",
            "M_05",
            "M_06",
            "M_07",
            "M_08",
            "M_09",
            "M_010",
            "M_011",
            "M_012",
            "M_013",
            "M_014",
            "M_015",
            "M_016",
            "M_017",
            "M_018"});
            this.cbIdCliente.Location = new System.Drawing.Point(288, 79);
            this.cbIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbIdCliente.Name = "cbIdCliente";
            this.cbIdCliente.Size = new System.Drawing.Size(160, 33);
            this.cbIdCliente.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 114;
            this.label1.Text = "Id Cliente:";
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSalir.Location = new System.Drawing.Point(110, 549);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(276, 37);
            this.btSalir.TabIndex = 113;
            this.btSalir.Text = "Salir de Retroalimentacion";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(288, 129);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(160, 30);
            this.dtFecha.TabIndex = 112;
            // 
            // btnRegistrarRetroalimentacion
            // 
            this.btnRegistrarRetroalimentacion.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrarRetroalimentacion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarRetroalimentacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarRetroalimentacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarRetroalimentacion.Location = new System.Drawing.Point(110, 504);
            this.btnRegistrarRetroalimentacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarRetroalimentacion.Name = "btnRegistrarRetroalimentacion";
            this.btnRegistrarRetroalimentacion.Size = new System.Drawing.Size(276, 37);
            this.btnRegistrarRetroalimentacion.TabIndex = 111;
            this.btnRegistrarRetroalimentacion.Text = "Enviar Retroalimentación";
            this.btnRegistrarRetroalimentacion.UseVisualStyleBackColor = false;
            this.btnRegistrarRetroalimentacion.Click += new System.EventHandler(this.btnRegistrarRetroalimentacion_Click);
            // 
            // cbTipoComentario
            // 
            this.cbTipoComentario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoComentario.FormattingEnabled = true;
            this.cbTipoComentario.Items.AddRange(new object[] {
            "Por la comida",
            "Por el ambiente",
            "Por el servicio"});
            this.cbTipoComentario.Location = new System.Drawing.Point(288, 224);
            this.cbTipoComentario.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoComentario.Name = "cbTipoComentario";
            this.cbTipoComentario.Size = new System.Drawing.Size(160, 33);
            this.cbTipoComentario.TabIndex = 108;
            // 
            // cbCalificacion
            // 
            this.cbCalificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalificacion.FormattingEnabled = true;
            this.cbCalificacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCalificacion.Location = new System.Drawing.Point(288, 178);
            this.cbCalificacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbCalificacion.Name = "cbCalificacion";
            this.cbCalificacion.Size = new System.Drawing.Size(160, 33);
            this.cbCalificacion.TabIndex = 107;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(31, 227);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(163, 25);
            this.label25.TabIndex = 105;
            this.label25.Text = "Tipo Comentario:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(29, 182);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 25);
            this.label26.TabIndex = 104;
            this.label26.Text = "Puntuacion:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(31, 134);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 25);
            this.label27.TabIndex = 102;
            this.label27.Text = "Fecha:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(29, 273);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(123, 25);
            this.label28.TabIndex = 101;
            this.label28.Text = "Comentario";
            // 
            // cbMesaRetroalimentacion
            // 
            this.cbMesaRetroalimentacion.FormattingEnabled = true;
            this.cbMesaRetroalimentacion.Items.AddRange(new object[] {
            "M_01",
            "M_02",
            "M_03",
            "M_04",
            "M_05",
            "M_06",
            "M_07"});
            this.cbMesaRetroalimentacion.Location = new System.Drawing.Point(81, -39);
            this.cbMesaRetroalimentacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbMesaRetroalimentacion.Name = "cbMesaRetroalimentacion";
            this.cbMesaRetroalimentacion.Size = new System.Drawing.Size(160, 33);
            this.cbMesaRetroalimentacion.TabIndex = 100;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(-49, -36);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(182, 25);
            this.label30.TabIndex = 99;
            this.label30.Text = "Codigo de mesa: ";
            // 
            // tbComenarioRetro
            // 
            this.tbComenarioRetro.Location = new System.Drawing.Point(50, 314);
            this.tbComenarioRetro.Name = "tbComenarioRetro";
            this.tbComenarioRetro.Size = new System.Drawing.Size(388, 30);
            this.tbComenarioRetro.TabIndex = 116;
            // 
            // FormRetroAlimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1129, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox15);
            this.Name = "FormRetroAlimentacion";
            this.Text = "FormRetroAlimentacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button btnRegistrarRetroalimentacion;
        private System.Windows.Forms.ComboBox cbTipoComentario;
        private System.Windows.Forms.ComboBox cbCalificacion;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbMesaRetroalimentacion;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.ComboBox cbIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComenarioRetro;
    }
}

namespace Presentacion
{
    partial class FormReporte
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFecha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbEstadoPedidoEntregado = new System.Windows.Forms.ComboBox();
            this.btBuscarEstado = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dgPedido = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTipoC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscarTipoC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPuntuacion = new System.Windows.Forms.ComboBox();
            this.btBuscarPuntuacion = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgRetro = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRetro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 654);
            this.tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1217, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.cbFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarFecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(472, 235);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de Pedido";
            // 
            // cbFecha
            // 
            this.cbFecha.FormattingEnabled = true;
            this.cbFecha.Location = new System.Drawing.Point(221, 58);
            this.cbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(160, 33);
            this.cbFecha.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "Fecha de pedido:";
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.Firebrick;
            this.btnBuscarFecha.FlatAppearance.BorderSize = 0;
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarFecha.Location = new System.Drawing.Point(80, 118);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(304, 65);
            this.btnBuscarFecha.TabIndex = 92;
            this.btnBuscarFecha.Text = "Buscar por fecha de pedido";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Ivory;
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.cbEstadoPedidoEntregado);
            this.groupBox10.Controls.Add(this.btBuscarEstado);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(36, 266);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(472, 334);
            this.groupBox10.TabIndex = 93;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Estado de preparación";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(75, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 25);
            this.label19.TabIndex = 91;
            this.label19.Text = "Estado Pedido:";
            // 
            // cbEstadoPedidoEntregado
            // 
            this.cbEstadoPedidoEntregado.FormattingEnabled = true;
            this.cbEstadoPedidoEntregado.Items.AddRange(new object[] {
            "En preparacion",
            "Preparado",
            "Entregado"});
            this.cbEstadoPedidoEntregado.Location = new System.Drawing.Point(258, 102);
            this.cbEstadoPedidoEntregado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoPedidoEntregado.Name = "cbEstadoPedidoEntregado";
            this.cbEstadoPedidoEntregado.Size = new System.Drawing.Size(121, 33);
            this.cbEstadoPedidoEntregado.TabIndex = 90;
            // 
            // btBuscarEstado
            // 
            this.btBuscarEstado.BackColor = System.Drawing.Color.Firebrick;
            this.btBuscarEstado.FlatAppearance.BorderSize = 0;
            this.btBuscarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscarEstado.Location = new System.Drawing.Point(77, 165);
            this.btBuscarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscarEstado.Name = "btBuscarEstado";
            this.btBuscarEstado.Size = new System.Drawing.Size(304, 65);
            this.btBuscarEstado.TabIndex = 87;
            this.btBuscarEstado.Text = "Buscar por estado de pedido";
            this.btBuscarEstado.UseVisualStyleBackColor = false;
            this.btBuscarEstado.Click += new System.EventHandler(this.btBuscarEstado_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Ivory;
            this.groupBox11.Controls.Add(this.dgPedido);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(520, 25);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(660, 575);
            this.groupBox11.TabIndex = 92;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Pedidos Activos";
            // 
            // dgPedido
            // 
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Location = new System.Drawing.Point(20, 38);
            this.dgPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.RowHeadersWidth = 51;
            this.dgPedido.Size = new System.Drawing.Size(619, 518);
            this.dgPedido.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1217, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte Retroalimentacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Ivory;
            this.groupBox2.Controls.Add(this.cbTipoC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btBuscarTipoC);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(472, 235);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Comentario";
            // 
            // cbTipoC
            // 
            this.cbTipoC.FormattingEnabled = true;
            this.cbTipoC.Items.AddRange(new object[] {
            "Por la comida",
            "Por el ambiente",
            "Por el servicio"});
            this.cbTipoC.Location = new System.Drawing.Point(221, 58);
            this.cbTipoC.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoC.Name = "cbTipoC";
            this.cbTipoC.Size = new System.Drawing.Size(160, 33);
            this.cbTipoC.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 94;
            this.label2.Text = "Tipo Comentario:";
            // 
            // btBuscarTipoC
            // 
            this.btBuscarTipoC.BackColor = System.Drawing.Color.Firebrick;
            this.btBuscarTipoC.FlatAppearance.BorderSize = 0;
            this.btBuscarTipoC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscarTipoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarTipoC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscarTipoC.Location = new System.Drawing.Point(80, 118);
            this.btBuscarTipoC.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscarTipoC.Name = "btBuscarTipoC";
            this.btBuscarTipoC.Size = new System.Drawing.Size(304, 65);
            this.btBuscarTipoC.TabIndex = 92;
            this.btBuscarTipoC.Text = "Buscar por tipo de comentario";
            this.btBuscarTipoC.UseVisualStyleBackColor = false;
            this.btBuscarTipoC.Click += new System.EventHandler(this.btBuscarTipoC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Ivory;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbPuntuacion);
            this.groupBox3.Controls.Add(this.btBuscarPuntuacion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 266);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(472, 334);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Por Puntuacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Puntuacion";
            // 
            // cbPuntuacion
            // 
            this.cbPuntuacion.FormattingEnabled = true;
            this.cbPuntuacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPuntuacion.Location = new System.Drawing.Point(204, 65);
            this.cbPuntuacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPuntuacion.Name = "cbPuntuacion";
            this.cbPuntuacion.Size = new System.Drawing.Size(121, 33);
            this.cbPuntuacion.TabIndex = 90;
            // 
            // btBuscarPuntuacion
            // 
            this.btBuscarPuntuacion.BackColor = System.Drawing.Color.Firebrick;
            this.btBuscarPuntuacion.FlatAppearance.BorderSize = 0;
            this.btBuscarPuntuacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscarPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarPuntuacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuscarPuntuacion.Location = new System.Drawing.Point(64, 127);
            this.btBuscarPuntuacion.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscarPuntuacion.Name = "btBuscarPuntuacion";
            this.btBuscarPuntuacion.Size = new System.Drawing.Size(304, 65);
            this.btBuscarPuntuacion.TabIndex = 87;
            this.btBuscarPuntuacion.Text = "Buscar por estado de pedido";
            this.btBuscarPuntuacion.UseVisualStyleBackColor = false;
            this.btBuscarPuntuacion.Click += new System.EventHandler(this.btBuscarPuntuacion_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Ivory;
            this.groupBox4.Controls.Add(this.dgRetro);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(520, 25);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(660, 575);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedidos Activos";
            // 
            // dgRetro
            // 
            this.dgRetro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRetro.Location = new System.Drawing.Point(20, 38);
            this.dgRetro.Margin = new System.Windows.Forms.Padding(4);
            this.dgRetro.Name = "dgRetro";
            this.dgRetro.RowHeadersWidth = 51;
            this.dgRetro.Size = new System.Drawing.Size(619, 518);
            this.dgRetro.TabIndex = 0;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1249, 678);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReporte";
            this.Text = "Reporte";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRetro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbEstadoPedidoEntregado;
        private System.Windows.Forms.Button btBuscarEstado;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView dgPedido;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTipoC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarTipoC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPuntuacion;
        private System.Windows.Forms.Button btBuscarPuntuacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgRetro;
    }
}
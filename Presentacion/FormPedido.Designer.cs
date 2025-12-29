
namespace Presentacion
{
    partial class FormPedido
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalirPedido = new System.Windows.Forms.Button();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.cbDniCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dgDetallePedido = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEliminiarDP = new System.Windows.Forms.Button();
            this.btModificarDP = new System.Windows.Forms.Button();
            this.btSalirDP = new System.Windows.Forms.Button();
            this.btRegistrarDP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.cbDpedido = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPlato = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tbCapacidadClientes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbEstadoMesa = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btCambiarEstado = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dgMesaxPedido = new System.Windows.Forms.DataGridView();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btRegistrarGestionMesa = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cbMesaP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPedidoM = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMesaxPedido)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 663);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dgPedidos);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1248, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Pantalla de visualización de pedidos";
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(468, 92);
            this.dgPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.RowHeadersWidth = 51;
            this.dgPedidos.Size = new System.Drawing.Size(708, 486);
            this.dgPedidos.TabIndex = 91;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Ivory;
            this.groupBox5.Controls.Add(this.btnAgregarPlato);
            this.groupBox5.Controls.Add(this.btnEliminarPedido);
            this.groupBox5.Controls.Add(this.btnModificar);
            this.groupBox5.Controls.Add(this.btnSalirPedido);
            this.groupBox5.Controls.Add(this.btnRegistrarPedido);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 315);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(417, 263);
            this.groupBox5.TabIndex = 90;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Funciones";
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.BackColor = System.Drawing.Color.Firebrick;
            this.btnAgregarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPlato.Location = new System.Drawing.Point(35, 44);
            this.btnAgregarPlato.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(359, 36);
            this.btnAgregarPlato.TabIndex = 5;
            this.btnAgregarPlato.Text = "Agregar Plato al pedido";
            this.btnAgregarPlato.UseVisualStyleBackColor = false;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarPedido.Location = new System.Drawing.Point(35, 172);
            this.btnEliminarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(359, 38);
            this.btnEliminarPedido.TabIndex = 4;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = false;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Firebrick;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(35, 130);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(359, 36);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalirPedido
            // 
            this.btnSalirPedido.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalirPedido.Location = new System.Drawing.Point(35, 219);
            this.btnSalirPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirPedido.Name = "btnSalirPedido";
            this.btnSalirPedido.Size = new System.Drawing.Size(359, 38);
            this.btnSalirPedido.TabIndex = 2;
            this.btnSalirPedido.Text = "Salir";
            this.btnSalirPedido.UseVisualStyleBackColor = false;
            this.btnSalirPedido.Click += new System.EventHandler(this.btnSalirPedido_Click);
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarPedido.Location = new System.Drawing.Point(35, 87);
            this.btnRegistrarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(359, 36);
            this.btnRegistrarPedido.TabIndex = 0;
            this.btnRegistrarPedido.Text = "Registrar";
            this.btnRegistrarPedido.UseVisualStyleBackColor = false;
            this.btnRegistrarPedido.Click += new System.EventHandler(this.btnRegistrarPedido_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Ivory;
            this.groupBox4.Controls.Add(this.dtFechaPedido);
            this.groupBox4.Controls.Add(this.cbEstadoPedido);
            this.groupBox4.Controls.Add(this.cbDniCliente);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbMesa);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 75);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(407, 233);
            this.groupBox4.TabIndex = 89;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de pedido";
            // 
            // dtFechaPedido
            // 
            this.dtFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaPedido.Location = new System.Drawing.Point(221, 41);
            this.dtFechaPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaPedido.Name = "dtFechaPedido";
            this.dtFechaPedido.Size = new System.Drawing.Size(161, 30);
            this.dtFechaPedido.TabIndex = 97;
            // 
            // cbEstadoPedido
            // 
            this.cbEstadoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoPedido.FormattingEnabled = true;
            this.cbEstadoPedido.Items.AddRange(new object[] {
            "En preparacion",
            "Preparado",
            "Entregado"});
            this.cbEstadoPedido.Location = new System.Drawing.Point(221, 90);
            this.cbEstadoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoPedido.Name = "cbEstadoPedido";
            this.cbEstadoPedido.Size = new System.Drawing.Size(160, 33);
            this.cbEstadoPedido.TabIndex = 77;
            // 
            // cbDniCliente
            // 
            this.cbDniCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDniCliente.FormattingEnabled = true;
            this.cbDniCliente.Location = new System.Drawing.Point(221, 180);
            this.cbDniCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbDniCliente.Name = "cbDniCliente";
            this.cbDniCliente.Size = new System.Drawing.Size(160, 33);
            this.cbDniCliente.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 25);
            this.label7.TabIndex = 76;
            this.label7.Text = "Estado de pedido: ";
            // 
            // cbMesa
            // 
            this.cbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(221, 132);
            this.cbMesa.Margin = new System.Windows.Forms.Padding(4);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(160, 33);
            this.cbMesa.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Fecha de pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "Dni Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Nª Mesa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(291, 40);
            this.label14.TabIndex = 87;
            this.label14.Text = "Registrar Pedido";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.dgDetallePedido);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1248, 634);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Detalle del Pedido";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 25);
            this.label5.TabIndex = 97;
            this.label5.Text = "Pantalla de visualización de pedidos";
            // 
            // dgDetallePedido
            // 
            this.dgDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallePedido.Location = new System.Drawing.Point(477, 89);
            this.dgDetallePedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetallePedido.Name = "dgDetallePedido";
            this.dgDetallePedido.RowHeadersWidth = 51;
            this.dgDetallePedido.Size = new System.Drawing.Size(708, 486);
            this.dgDetallePedido.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.btEliminiarDP);
            this.groupBox1.Controls.Add(this.btModificarDP);
            this.groupBox1.Controls.Add(this.btSalirDP);
            this.groupBox1.Controls.Add(this.btRegistrarDP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(417, 263);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btEliminiarDP
            // 
            this.btEliminiarDP.BackColor = System.Drawing.Color.Firebrick;
            this.btEliminiarDP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEliminiarDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminiarDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEliminiarDP.Location = new System.Drawing.Point(35, 145);
            this.btEliminiarDP.Margin = new System.Windows.Forms.Padding(4);
            this.btEliminiarDP.Name = "btEliminiarDP";
            this.btEliminiarDP.Size = new System.Drawing.Size(359, 38);
            this.btEliminiarDP.TabIndex = 4;
            this.btEliminiarDP.Text = "Eliminar";
            this.btEliminiarDP.UseVisualStyleBackColor = false;
            this.btEliminiarDP.Click += new System.EventHandler(this.btEliminiarDP_Click);
            // 
            // btModificarDP
            // 
            this.btModificarDP.BackColor = System.Drawing.Color.Firebrick;
            this.btModificarDP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModificarDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btModificarDP.Location = new System.Drawing.Point(35, 103);
            this.btModificarDP.Margin = new System.Windows.Forms.Padding(4);
            this.btModificarDP.Name = "btModificarDP";
            this.btModificarDP.Size = new System.Drawing.Size(359, 36);
            this.btModificarDP.TabIndex = 3;
            this.btModificarDP.Text = "Modificar";
            this.btModificarDP.UseVisualStyleBackColor = false;
            this.btModificarDP.Click += new System.EventHandler(this.btModificarDP_Click);
            // 
            // btSalirDP
            // 
            this.btSalirDP.BackColor = System.Drawing.Color.Firebrick;
            this.btSalirDP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalirDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalirDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSalirDP.Location = new System.Drawing.Point(35, 192);
            this.btSalirDP.Margin = new System.Windows.Forms.Padding(4);
            this.btSalirDP.Name = "btSalirDP";
            this.btSalirDP.Size = new System.Drawing.Size(359, 38);
            this.btSalirDP.TabIndex = 2;
            this.btSalirDP.Text = "Salir";
            this.btSalirDP.UseVisualStyleBackColor = false;
            this.btSalirDP.Click += new System.EventHandler(this.btSalirDP_Click);
            // 
            // btRegistrarDP
            // 
            this.btRegistrarDP.BackColor = System.Drawing.Color.Firebrick;
            this.btRegistrarDP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegistrarDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRegistrarDP.Location = new System.Drawing.Point(35, 60);
            this.btRegistrarDP.Margin = new System.Windows.Forms.Padding(4);
            this.btRegistrarDP.Name = "btRegistrarDP";
            this.btRegistrarDP.Size = new System.Drawing.Size(359, 36);
            this.btRegistrarDP.TabIndex = 0;
            this.btRegistrarDP.Text = "Registrar";
            this.btRegistrarDP.UseVisualStyleBackColor = false;
            this.btRegistrarDP.Click += new System.EventHandler(this.btRegistrarDP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Ivory;
            this.groupBox2.Controls.Add(this.tbObservaciones);
            this.groupBox2.Controls.Add(this.cbDpedido);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbPlato);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(407, 233);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de pedido";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(212, 140);
            this.tbObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(160, 30);
            this.tbObservaciones.TabIndex = 97;
            // 
            // cbDpedido
            // 
            this.cbDpedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDpedido.FormattingEnabled = true;
            this.cbDpedido.Location = new System.Drawing.Point(212, 59);
            this.cbDpedido.Margin = new System.Windows.Forms.Padding(4);
            this.cbDpedido.Name = "cbDpedido";
            this.cbDpedido.Size = new System.Drawing.Size(160, 33);
            this.cbDpedido.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 76;
            this.label8.Text = "Observaciones:";
            // 
            // cbPlato
            // 
            this.cbPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlato.FormattingEnabled = true;
            this.cbPlato.Location = new System.Drawing.Point(212, 100);
            this.cbPlato.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlato.Name = "cbPlato";
            this.cbPlato.Size = new System.Drawing.Size(160, 33);
            this.cbPlato.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 94;
            this.label10.Text = "Numero del pedido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 25);
            this.label11.TabIndex = 93;
            this.label11.Text = "Nombre del Plato:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(442, 40);
            this.label12.TabIndex = 93;
            this.label12.Text = "Observaciones del Pedido";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1248, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion de mesas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 736);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(944, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Indicacion del sistema: El mesero cambia el estado a \"Entregado\" una vez que se h" +
    "ayan realizado los pedidos, es decir cuando el estado sea \"Listo\"";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Ivory;
            this.groupBox10.Controls.Add(this.tbCapacidadClientes);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.cbEstadoMesa);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.btCambiarEstado);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(765, 239);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(425, 375);
            this.groupBox10.TabIndex = 88;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Estado de mesa";
            // 
            // tbCapacidadClientes
            // 
            this.tbCapacidadClientes.Location = new System.Drawing.Point(244, 152);
            this.tbCapacidadClientes.Name = "tbCapacidadClientes";
            this.tbCapacidadClientes.Size = new System.Drawing.Size(137, 30);
            this.tbCapacidadClientes.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 25);
            this.label13.TabIndex = 93;
            this.label13.Text = "Estado Mesa:";
            // 
            // cbEstadoMesa
            // 
            this.cbEstadoMesa.FormattingEnabled = true;
            this.cbEstadoMesa.Items.AddRange(new object[] {
            "Libre",
            "Ocupado"});
            this.cbEstadoMesa.Location = new System.Drawing.Point(240, 107);
            this.cbEstadoMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoMesa.Name = "cbEstadoMesa";
            this.cbEstadoMesa.Size = new System.Drawing.Size(141, 33);
            this.cbEstadoMesa.TabIndex = 92;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 155);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(211, 25);
            this.label19.TabIndex = 91;
            this.label19.Text = "Capacidad de clientes:";
            // 
            // btCambiarEstado
            // 
            this.btCambiarEstado.BackColor = System.Drawing.Color.Firebrick;
            this.btCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCambiarEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCambiarEstado.Location = new System.Drawing.Point(57, 213);
            this.btCambiarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btCambiarEstado.Name = "btCambiarEstado";
            this.btCambiarEstado.Size = new System.Drawing.Size(304, 65);
            this.btCambiarEstado.TabIndex = 87;
            this.btCambiarEstado.Text = "Cambiar estado";
            this.btCambiarEstado.UseVisualStyleBackColor = false;
            this.btCambiarEstado.Click += new System.EventHandler(this.btCambiarEstado_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Ivory;
            this.groupBox11.Controls.Add(this.dgMesaxPedido);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(48, 202);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(663, 428);
            this.groupBox11.TabIndex = 87;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Pedidos Activos";
            // 
            // dgMesaxPedido
            // 
            this.dgMesaxPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMesaxPedido.Location = new System.Drawing.Point(37, 65);
            this.dgMesaxPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgMesaxPedido.Name = "dgMesaxPedido";
            this.dgMesaxPedido.RowHeadersWidth = 51;
            this.dgMesaxPedido.Size = new System.Drawing.Size(569, 345);
            this.dgMesaxPedido.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Ivory;
            this.groupBox12.Controls.Add(this.btRegistrarGestionMesa);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(765, 75);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(425, 130);
            this.groupBox12.TabIndex = 86;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Funciones";
            // 
            // btRegistrarGestionMesa
            // 
            this.btRegistrarGestionMesa.BackColor = System.Drawing.Color.Firebrick;
            this.btRegistrarGestionMesa.FlatAppearance.BorderSize = 0;
            this.btRegistrarGestionMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegistrarGestionMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarGestionMesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRegistrarGestionMesa.Location = new System.Drawing.Point(128, 34);
            this.btRegistrarGestionMesa.Margin = new System.Windows.Forms.Padding(4);
            this.btRegistrarGestionMesa.Name = "btRegistrarGestionMesa";
            this.btRegistrarGestionMesa.Size = new System.Drawing.Size(216, 64);
            this.btRegistrarGestionMesa.TabIndex = 76;
            this.btRegistrarGestionMesa.Text = "Registrar mesa por Pedido";
            this.btRegistrarGestionMesa.UseVisualStyleBackColor = false;
            this.btRegistrarGestionMesa.Click += new System.EventHandler(this.btRegistrarGestionMesa_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Ivory;
            this.groupBox13.Controls.Add(this.cbMesaP);
            this.groupBox13.Controls.Add(this.label9);
            this.groupBox13.Controls.Add(this.cbPedidoM);
            this.groupBox13.Controls.Add(this.label17);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(48, 75);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(663, 119);
            this.groupBox13.TabIndex = 85;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Filtro de búsqueda";
            // 
            // cbMesaP
            // 
            this.cbMesaP.FormattingEnabled = true;
            this.cbMesaP.Location = new System.Drawing.Point(201, 70);
            this.cbMesaP.Margin = new System.Windows.Forms.Padding(4);
            this.cbMesaP.Name = "cbMesaP";
            this.cbMesaP.Size = new System.Drawing.Size(160, 33);
            this.cbMesaP.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "N° Mesa:";
            // 
            // cbPedidoM
            // 
            this.cbPedidoM.FormattingEnabled = true;
            this.cbPedidoM.Location = new System.Drawing.Point(201, 31);
            this.cbPedidoM.Margin = new System.Windows.Forms.Padding(4);
            this.cbPedidoM.Name = "cbPedidoM";
            this.cbPedidoM.Size = new System.Drawing.Size(160, 33);
            this.cbPedidoM.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(50, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 25);
            this.label17.TabIndex = 78;
            this.label17.Text = "ID Pedido:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(419, 17);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(415, 44);
            this.label23.TabIndex = 84;
            this.label23.Text = "Preparación de Mesas";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1320, 722);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPedido";
            this.Text = "Registro de los pedidos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallePedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMesaxPedido)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalirPedido;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbEstadoPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btCambiarEstado;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView dgMesaxPedido;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btRegistrarGestionMesa;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cbPedidoM;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDniCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.DateTimePicker dtFechaPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgDetallePedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btEliminiarDP;
        private System.Windows.Forms.Button btModificarDP;
        private System.Windows.Forms.Button btSalirDP;
        private System.Windows.Forms.Button btRegistrarDP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.ComboBox cbDpedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPlato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMesaP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCapacidadClientes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbEstadoMesa;
    }
}
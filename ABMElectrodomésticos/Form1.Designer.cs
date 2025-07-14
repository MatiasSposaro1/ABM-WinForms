namespace ABMElectrodomésticos
{
    partial class FrmElectrodomesticos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigoProducto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_eliminar = new System.Windows.Forms.RadioButton();
            this.rb_modificar = new System.Windows.Forms.RadioButton();
            this.rb_agregar = new System.Windows.Forms.RadioButton();
            this.dgv_grilla = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_caracteristicas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btn_eliminar2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_idOculto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(330, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Electrodomésticos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_idOculto);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_precio, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_stock, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_caracteristicas, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_modelo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_marca, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_tipo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_codigoProducto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_fechaIngreso, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Características";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_modelo.Location = new System.Drawing.Point(209, 146);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.ShortcutsEnabled = false;
            this.txt_modelo.Size = new System.Drawing.Size(166, 30);
            this.txt_modelo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modelo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_marca
            // 
            this.txt_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_marca.Location = new System.Drawing.Point(209, 100);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ShortcutsEnabled = false;
            this.txt_marca.Size = new System.Drawing.Size(166, 30);
            this.txt_marca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tipo.Location = new System.Drawing.Point(209, 54);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ShortcutsEnabled = false;
            this.txt_tipo.Size = new System.Drawing.Size(166, 30);
            this.txt_tipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo de Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_codigoProducto
            // 
            this.txt_codigoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigoProducto.Location = new System.Drawing.Point(209, 8);
            this.txt_codigoProducto.Name = "txt_codigoProducto";
            this.txt_codigoProducto.ShortcutsEnabled = false;
            this.txt_codigoProducto.Size = new System.Drawing.Size(166, 30);
            this.txt_codigoProducto.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_eliminar);
            this.groupBox2.Controls.Add(this.rb_modificar);
            this.groupBox2.Controls.Add(this.rb_agregar);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acción";
            // 
            // rb_eliminar
            // 
            this.rb_eliminar.AutoSize = true;
            this.rb_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rb_eliminar.Location = new System.Drawing.Point(270, 40);
            this.rb_eliminar.Name = "rb_eliminar";
            this.rb_eliminar.Size = new System.Drawing.Size(65, 27);
            this.rb_eliminar.TabIndex = 2;
            this.rb_eliminar.TabStop = true;
            this.rb_eliminar.Text = "Baja";
            this.rb_eliminar.UseVisualStyleBackColor = true;
            this.rb_eliminar.CheckedChanged += new System.EventHandler(this.rb_eliminar_CheckedChanged);
            // 
            // rb_modificar
            // 
            this.rb_modificar.AutoSize = true;
            this.rb_modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rb_modificar.Location = new System.Drawing.Point(140, 40);
            this.rb_modificar.Name = "rb_modificar";
            this.rb_modificar.Size = new System.Drawing.Size(109, 27);
            this.rb_modificar.TabIndex = 1;
            this.rb_modificar.TabStop = true;
            this.rb_modificar.Text = "Modificar";
            this.rb_modificar.UseVisualStyleBackColor = true;
            this.rb_modificar.CheckedChanged += new System.EventHandler(this.rb_modificar_CheckedChanged);
            // 
            // rb_agregar
            // 
            this.rb_agregar.AutoSize = true;
            this.rb_agregar.ForeColor = System.Drawing.Color.Lime;
            this.rb_agregar.Location = new System.Drawing.Point(15, 40);
            this.rb_agregar.Name = "rb_agregar";
            this.rb_agregar.Size = new System.Drawing.Size(97, 27);
            this.rb_agregar.TabIndex = 0;
            this.rb_agregar.TabStop = true;
            this.rb_agregar.Text = "Agregar";
            this.rb_agregar.UseVisualStyleBackColor = true;
            this.rb_agregar.CheckedChanged += new System.EventHandler(this.rb_agregar_CheckedChanged);
            // 
            // dgv_grilla
            // 
            this.dgv_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_grilla.BackgroundColor = System.Drawing.Color.White;
            this.dgv_grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grilla.EnableHeadersVisualStyles = false;
            this.dgv_grilla.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_grilla.Location = new System.Drawing.Point(420, 105);
            this.dgv_grilla.Name = "dgv_grilla";
            this.dgv_grilla.ReadOnly = true;
            this.dgv_grilla.RowHeadersVisible = false;
            this.dgv_grilla.RowHeadersWidth = 51;
            this.dgv_grilla.RowTemplate.Height = 24;
            this.dgv_grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_grilla.Size = new System.Drawing.Size(660, 530);
            this.dgv_grilla.TabIndex = 3;
            this.dgv_grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_grilla_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel2.Controls.Add(this.btn_eliminar2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_eliminar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_modificar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_agregar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 645);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(385, 45);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(195, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 35);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Baja";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(99, 3);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(90, 35);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Lime;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(3, 3);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(90, 35);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(975, 665);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 40);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_caracteristicas
            // 
            this.txt_caracteristicas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_caracteristicas.Location = new System.Drawing.Point(209, 192);
            this.txt_caracteristicas.Name = "txt_caracteristicas";
            this.txt_caracteristicas.ShortcutsEnabled = false;
            this.txt_caracteristicas.Size = new System.Drawing.Size(166, 30);
            this.txt_caracteristicas.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_stock
            // 
            this.txt_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_stock.Location = new System.Drawing.Point(209, 238);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ShortcutsEnabled = false;
            this.txt_stock.Size = new System.Drawing.Size(166, 30);
            this.txt_stock.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_precio.Location = new System.Drawing.Point(209, 284);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.ShortcutsEnabled = false;
            this.txt_precio.Size = new System.Drawing.Size(166, 30);
            this.txt_precio.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha de ingreso";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_fechaIngreso
            // 
            this.dtp_fechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_fechaIngreso.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaIngreso.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaIngreso.Location = new System.Drawing.Point(204, 336);
            this.dtp_fechaIngreso.Name = "dtp_fechaIngreso";
            this.dtp_fechaIngreso.Size = new System.Drawing.Size(177, 25);
            this.dtp_fechaIngreso.TabIndex = 15;
            // 
            // btn_eliminar2
            // 
            this.btn_eliminar2.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar2.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar2.Location = new System.Drawing.Point(291, 3);
            this.btn_eliminar2.Name = "btn_eliminar2";
            this.btn_eliminar2.Size = new System.Drawing.Size(90, 35);
            this.btn_eliminar2.TabIndex = 3;
            this.btn_eliminar2.Text = "Eliminar";
            this.btn_eliminar2.UseVisualStyleBackColor = false;
            this.btn_eliminar2.Click += new System.EventHandler(this.btn_eliminar2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(980, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ver Todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_idOculto
            // 
            this.txt_idOculto.Location = new System.Drawing.Point(265, 25);
            this.txt_idOculto.Name = "txt_idOculto";
            this.txt_idOculto.Size = new System.Drawing.Size(80, 30);
            this.txt_idOculto.TabIndex = 1;
            this.txt_idOculto.Visible = false;
            // 
            // FrmElectrodomesticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1088, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgv_grilla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FrmElectrodomesticos";
            this.Text = "ABM-Electrodomesticos";
            this.Load += new System.EventHandler(this.FrmElectrodomesticos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigoProducto;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_eliminar;
        private System.Windows.Forms.RadioButton rb_modificar;
        private System.Windows.Forms.RadioButton rb_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_grilla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_caracteristicas;
        private System.Windows.Forms.DateTimePicker dtp_fechaIngreso;
        private System.Windows.Forms.Button btn_eliminar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_idOculto;
    }
}


namespace pryDisenoLavadero
{
    partial class frmLavados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLavados));
            grbLavados = new GroupBox();
            btnBuscar = new Button();
            lstLavados = new ListBox();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            grbDatos = new GroupBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblRecargo = new Label();
            chkCliente = new CheckBox();
            cboCantidad = new ComboBox();
            btnLimpiar = new Button();
            lblNombre = new Label();
            btnRegistrar = new Button();
            txtNombre = new TextBox();
            btnCalcular = new Button();
            lblPatente = new Label();
            txtPatente = new TextBox();
            lblServicio = new Label();
            cboServicio = new ComboBox();
            lblCantidad = new Label();
            rdbExpress = new RadioButton();
            lblEntrega = new Label();
            rdbNormal = new RadioButton();
            lblSubtotal = new Label();
            grbLavados.SuspendLayout();
            grbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grbLavados
            // 
            grbLavados.Controls.Add(btnBuscar);
            grbLavados.Controls.Add(lstLavados);
            grbLavados.Controls.Add(txtBuscar);
            grbLavados.Controls.Add(lblBuscar);
            grbLavados.Location = new Point(360, 25);
            grbLavados.Name = "grbLavados";
            grbLavados.Size = new Size(347, 444);
            grbLavados.TabIndex = 22;
            grbLavados.TabStop = false;
            grbLavados.Text = "Lavados del dia";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(251, 391);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lstLavados
            // 
            lstLavados.FormattingEnabled = true;
            lstLavados.Location = new Point(27, 73);
            lstLavados.Name = "lstLavados";
            lstLavados.Size = new Size(299, 259);
            lstLavados.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(87, 35);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(27, 38);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(lblTotal);
            grbDatos.Controls.Add(lblDescuento);
            grbDatos.Controls.Add(lblRecargo);
            grbDatos.Controls.Add(chkCliente);
            grbDatos.Controls.Add(cboCantidad);
            grbDatos.Controls.Add(btnLimpiar);
            grbDatos.Controls.Add(lblNombre);
            grbDatos.Controls.Add(btnRegistrar);
            grbDatos.Controls.Add(txtNombre);
            grbDatos.Controls.Add(btnCalcular);
            grbDatos.Controls.Add(lblPatente);
            grbDatos.Controls.Add(txtPatente);
            grbDatos.Controls.Add(lblServicio);
            grbDatos.Controls.Add(cboServicio);
            grbDatos.Controls.Add(lblCantidad);
            grbDatos.Controls.Add(rdbExpress);
            grbDatos.Controls.Add(lblEntrega);
            grbDatos.Controls.Add(rdbNormal);
            grbDatos.Location = new Point(12, 25);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(312, 444);
            grbDatos.TabIndex = 21;
            grbDatos.TabStop = false;
            grbDatos.Text = "Datos";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(27, 346);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 21;
            lblTotal.Text = "Total";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(27, 317);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 20;
            lblDescuento.Text = "Descuento";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Location = new Point(27, 288);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(50, 15);
            lblRecargo.TabIndex = 19;
            lblRecargo.Text = "Recargo";
            // 
            // chkCliente
            // 
            chkCliente.AutoSize = true;
            chkCliente.Location = new Point(19, 246);
            chkCliente.Name = "chkCliente";
            chkCliente.Size = new Size(179, 19);
            chkCliente.TabIndex = 18;
            chkCliente.Text = "Cliente Frecuente ( 5% extra) ";
            chkCliente.UseVisualStyleBackColor = true;
            // 
            // cboCantidad
            // 
            cboCantidad.FormattingEnabled = true;
            cboCantidad.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboCantidad.Location = new Point(86, 175);
            cboCantidad.Name = "cboCantidad";
            cboCantidad.Size = new Size(121, 23);
            cboCantidad.TabIndex = 7;
            cboCantidad.KeyPress += cboServicio_KeyPress;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(52, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(133, 391);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(214, 391);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(19, 73);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 2;
            lblPatente.Text = "Patente";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(86, 70);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 3;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(18, 129);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(48, 15);
            lblServicio.TabIndex = 4;
            lblServicio.Text = "Servicio";
            // 
            // cboServicio
            // 
            cboServicio.FormattingEnabled = true;
            cboServicio.Items.AddRange(new object[] { "Lavado exterior ($ 8.000)", "Lavado completo ($ 14.000 )", "Lavado con encerado ($ 20.000)" });
            cboServicio.Location = new Point(86, 126);
            cboServicio.Name = "cboServicio";
            cboServicio.Size = new Size(121, 23);
            cboServicio.TabIndex = 5;
            cboServicio.KeyPress += cboServicio_KeyPress;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(19, 178);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // rdbExpress
            // 
            rdbExpress.AutoSize = true;
            rdbExpress.Location = new Point(166, 221);
            rdbExpress.Name = "rdbExpress";
            rdbExpress.Size = new Size(63, 19);
            rdbExpress.TabIndex = 10;
            rdbExpress.TabStop = true;
            rdbExpress.Text = "Express";
            rdbExpress.UseVisualStyleBackColor = true;
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Location = new Point(19, 223);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(47, 15);
            lblEntrega.TabIndex = 8;
            lblEntrega.Text = "Entrega";
            // 
            // rdbNormal
            // 
            rdbNormal.AutoSize = true;
            rdbNormal.Location = new Point(86, 221);
            rdbNormal.Name = "rdbNormal";
            rdbNormal.Size = new Size(65, 19);
            rdbNormal.TabIndex = 9;
            rdbNormal.TabStop = true;
            rdbNormal.Text = "Normal";
            rdbNormal.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(474, 315);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 15);
            lblSubtotal.TabIndex = 20;
            // 
            // frmLavados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 481);
            Controls.Add(grbLavados);
            Controls.Add(grbDatos);
            Controls.Add(lblSubtotal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmLavados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavadero los andes";
            Load += frmLavados_Load;
            grbLavados.ResumeLayout(false);
            grbLavados.PerformLayout();
            grbDatos.ResumeLayout(false);
            grbDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbLavados;
        private Button btnBuscar;
        private ListBox lstLavados;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private GroupBox grbDatos;
        private ComboBox cboCantidad;
        private Button btnLimpiar;
        private Label lblNombre;
        private Button btnRegistrar;
        private TextBox txtNombre;
        private Button btnCalcular;
        private Label lblPatente;
        private TextBox txtPatente;
        private Label lblServicio;
        private ComboBox cboServicio;
        private Label lblCantidad;
        private RadioButton rdbExpress;
        private Label lblEntrega;
        private RadioButton rdbNormal;
        private Label lblSubtotal;
        private CheckBox chkCliente;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblRecargo;
    }
}
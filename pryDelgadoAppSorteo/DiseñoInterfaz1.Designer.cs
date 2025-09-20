namespace pryDelgadoAppSorteo
{
    partial class DiseñoInterfaz1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdIngresar = new Button();
            lblNombre = new Label();
            lblFecha = new Label();
            lblParticipantes = new Label();
            txtNombre = new TextBox();
            lstFecha = new DateTimePicker();
            lblTitulo = new Label();
            mtbParticipantes = new MaskedTextBox();
            cmdCancelar = new Button();
            lstbResultados = new ListBox();
            SuspendLayout();
            // 
            // cmdIngresar
            // 
            cmdIngresar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdIngresar.Location = new Point(39, 267);
            cmdIngresar.Margin = new Padding(3, 4, 3, 4);
            cmdIngresar.Name = "cmdIngresar";
            cmdIngresar.Size = new Size(143, 42);
            cmdIngresar.TabIndex = 0;
            cmdIngresar.Text = "Ingresar";
            cmdIngresar.UseVisualStyleBackColor = true;
            cmdIngresar.Click += cmdIngresar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(39, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(178, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del sorteo";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(39, 141);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(155, 28);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha del sorteo";
            // 
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParticipantes.Location = new Point(39, 191);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(236, 28);
            lblParticipantes.TabIndex = 3;
            lblParticipantes.Text = "Cantidad de participantes";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(234, 96);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(334, 32);
            txtNombre.TabIndex = 4;
            // 
            // lstFecha
            // 
            lstFecha.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstFecha.Location = new Point(234, 137);
            lstFecha.Margin = new Padding(3, 4, 3, 4);
            lstFecha.Name = "lstFecha";
            lstFecha.Size = new Size(334, 32);
            lstFecha.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(39, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(167, 28);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Ingrese el sorteo";
            // 
            // mtbParticipantes
            // 
            mtbParticipantes.Location = new Point(294, 191);
            mtbParticipantes.Mask = "99999";
            mtbParticipantes.Name = "mtbParticipantes";
            mtbParticipantes.Size = new Size(274, 27);
            mtbParticipantes.TabIndex = 9;
            mtbParticipantes.ValidatingType = typeof(int);
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(234, 267);
            cmdCancelar.Margin = new Padding(3, 4, 3, 4);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(143, 42);
            cmdCancelar.TabIndex = 10;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lstbResultados
            // 
            lstbResultados.FormattingEnabled = true;
            lstbResultados.Location = new Point(39, 361);
            lstbResultados.Name = "lstbResultados";
            lstbResultados.Size = new Size(511, 124);
            lstbResultados.TabIndex = 12;
            // 
            // DiseñoInterfaz1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 505);
            Controls.Add(lstbResultados);
            Controls.Add(cmdCancelar);
            Controls.Add(mtbParticipantes);
            Controls.Add(lblTitulo);
            Controls.Add(lstFecha);
            Controls.Add(txtNombre);
            Controls.Add(lblParticipantes);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(cmdIngresar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DiseñoInterfaz1";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdIngresar;
        private Label lblNombre;
        private Label lblFecha;
        private Label lblParticipantes;
        private TextBox txtNombre;
        private DateTimePicker lstFecha;
        private Label lblTitulo;
        private MaskedTextBox mtbParticipantes;
        private Button cmdCancelar;
        private ListBox lstbResultados;
    }
}

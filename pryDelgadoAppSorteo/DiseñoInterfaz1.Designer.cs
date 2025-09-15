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
            txtParticipantes = new TextBox();
            lstFecha = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmdIngresar
            // 
            cmdIngresar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdIngresar.Location = new Point(39, 263);
            cmdIngresar.Margin = new Padding(3, 4, 3, 4);
            cmdIngresar.Name = "cmdIngresar";
            cmdIngresar.Size = new Size(143, 42);
            cmdIngresar.TabIndex = 0;
            cmdIngresar.Text = "Ingresar";
            cmdIngresar.UseVisualStyleBackColor = true;
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
            //lblFecha.Click += lblFecha_Click;
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
            //txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtParticipantes
            // 
            txtParticipantes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParticipantes.Location = new Point(311, 187);
            txtParticipantes.Margin = new Padding(3, 4, 3, 4);
            txtParticipantes.Name = "txtParticipantes";
            txtParticipantes.Size = new Size(257, 32);
            txtParticipantes.TabIndex = 5;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 8;
            label1.Text = "Ingrese el sorteo";
            // 
            // DiseñoInterfaz1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 347);
            Controls.Add(label1);
            Controls.Add(lstFecha);
            Controls.Add(txtParticipantes);
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
        private TextBox txtParticipantes;
        private DateTimePicker lstFecha;
        private Label label1;
    }
}

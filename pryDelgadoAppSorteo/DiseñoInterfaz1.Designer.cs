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
            SuspendLayout();
            // 
            // cmdIngresar
            // 
            cmdIngresar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdIngresar.Location = new Point(34, 228);
            cmdIngresar.Name = "cmdIngresar";
            cmdIngresar.Size = new Size(105, 37);
            cmdIngresar.TabIndex = 0;
            cmdIngresar.Text = "Ingresar";
            cmdIngresar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(34, 62);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(170, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del sorteo";
            lblNombre.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(34, 106);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(150, 25);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha del sorteo";
            // 
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParticipantes.Location = new Point(34, 161);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(228, 25);
            lblParticipantes.TabIndex = 3;
            lblParticipantes.Text = "Cantidad de participantes";
            lblParticipantes.Click += lblParticipantes_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(219, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(271, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtParticipantes
            // 
            txtParticipantes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParticipantes.Location = new Point(283, 162);
            txtParticipantes.Name = "txtParticipantes";
            txtParticipantes.Size = new Size(207, 27);
            txtParticipantes.TabIndex = 5;
            txtParticipantes.TextChanged += textBox2_TextChanged;
            // 
            // lstFecha
            // 
            lstFecha.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstFecha.Location = new Point(219, 108);
            lstFecha.Name = "lstFecha";
            lstFecha.Size = new Size(271, 27);
            lstFecha.TabIndex = 7;
            // 
            // DiseñoInterfaz1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 313);
            Controls.Add(lstFecha);
            Controls.Add(txtParticipantes);
            Controls.Add(txtNombre);
            Controls.Add(lblParticipantes);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(cmdIngresar);
            Name = "DiseñoInterfaz1";
            Text = "frmPrincipal";
            Load += DiseñoInterfaz1_Load;
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
    }
}

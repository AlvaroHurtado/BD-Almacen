namespace ConexionAlmacen
{
    partial class CFrmConteosFisicos
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
            label2 = new Label();
            label1 = new Label();
            nmrEmpleado = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrEmpleado).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 94);
            label2.Name = "label2";
            label2.Size = new Size(195, 24);
            label2.TabIndex = 4;
            label2.Text = "Fecha de Creación:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 44);
            label1.Name = "label1";
            label1.Size = new Size(236, 24);
            label1.TabIndex = 3;
            label1.Text = "Empleado Responsable:";
            label1.Click += label1_Click;
            // 
            // nmrEmpleado
            // 
            nmrEmpleado.Location = new Point(352, 45);
            nmrEmpleado.Name = "nmrEmpleado";
            nmrEmpleado.Size = new Size(275, 23);
            nmrEmpleado.TabIndex = 10;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(352, 94);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(275, 23);
            dtpFecha.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(580, 364);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(700, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CFrmConteosFisicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(nmrEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CFrmConteosFisicos";
            Text = "CFrmConteosFisicos";
            Load += CFrmConteosFisicos_Load;
            ((System.ComponentModel.ISupportInitialize)nmrEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private NumericUpDown nmrEmpleado;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
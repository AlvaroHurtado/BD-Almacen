namespace ConexionAlmacen
{
    partial class CFrmEmpleados
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombres = new TextBox();
            txtApellidoP = new TextBox();
            txtApellidoM = new TextBox();
            nmrEdad = new NumericUpDown();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrEdad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 50);
            label1.Name = "label1";
            label1.Size = new Size(99, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(168, 24);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(171, 24);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 200);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 3;
            label4.Text = "Edad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 250);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 4;
            label5.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 300);
            label6.Name = "label6";
            label6.Size = new Size(192, 24);
            label6.TabIndex = 5;
            label6.Text = "Correo Electrónico:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(300, 50);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(275, 23);
            txtNombres.TabIndex = 6;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(300, 100);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(274, 23);
            txtApellidoP.TabIndex = 7;
            // 
            // txtApellidoM
            // 
            txtApellidoM.Location = new Point(300, 150);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(274, 23);
            txtApellidoM.TabIndex = 8;
            // 
            // nmrEdad
            // 
            nmrEdad.Location = new Point(300, 200);
            nmrEdad.Name = "nmrEdad";
            nmrEdad.Size = new Size(275, 23);
            nmrEdad.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(300, 250);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(274, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(300, 300);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(274, 23);
            txtCorreo.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(580, 364);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(700, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CFrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(nmrEdad);
            Controls.Add(txtApellidoM);
            Controls.Add(txtApellidoP);
            Controls.Add(txtNombres);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CFrmEmpleados";
            Text = "CFrmEmpleados";
            Load += CFrmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)nmrEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombres;
        private TextBox txtApellidoP;
        private TextBox txtApellidoM;
        private NumericUpDown nmrEdad;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
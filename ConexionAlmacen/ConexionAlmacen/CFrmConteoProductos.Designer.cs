namespace ConexionAlmacen
{
    partial class CFrmConteoProductos
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            nmrProducto = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            nmrCantidad = new NumericUpDown();
            label3 = new Label();
            nmrConteo = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrConteo).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(686, 374);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(566, 374);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nmrProducto
            // 
            nmrProducto.Location = new Point(238, 98);
            nmrProducto.Name = "nmrProducto";
            nmrProducto.Size = new Size(275, 23);
            nmrProducto.TabIndex = 17;
            nmrProducto.ValueChanged += nmrEmpleado_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 143);
            label2.Name = "label2";
            label2.Size = new Size(192, 24);
            label2.TabIndex = 16;
            label2.Text = "Cantidad Existente:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 93);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 15;
            label1.Text = "Producto:";
            label1.Click += label1_Click;
            // 
            // nmrCantidad
            // 
            nmrCantidad.Location = new Point(238, 148);
            nmrCantidad.Name = "nmrCantidad";
            nmrCantidad.Size = new Size(275, 23);
            nmrCantidad.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 48);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 22;
            label3.Text = "Conteo:";
            // 
            // nmrConteo
            // 
            nmrConteo.Location = new Point(238, 53);
            nmrConteo.Name = "nmrConteo";
            nmrConteo.Size = new Size(275, 23);
            nmrConteo.TabIndex = 23;
            nmrConteo.ValueChanged += nmrConteo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(519, 56);
            label4.Name = "label4";
            label4.Size = new Size(273, 16);
            label4.TabIndex = 24;
            label4.Text = "*solo aplica para los productos agregados";
            label4.Click += label4_Click;
            // 
            // CFrmConteoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(nmrConteo);
            Controls.Add(label3);
            Controls.Add(nmrCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nmrProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CFrmConteoProductos";
            Text = "CFrmConteoProductos";
            Load += CFrmConteoProductos_Load;
            ((System.ComponentModel.ISupportInitialize)nmrProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrConteo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private DateTimePicker dtpFecha;
        private NumericUpDown nmrProducto;
        private Label label2;
        private Label label1;
        private NumericUpDown nmrCantidad;
        private Label label3;
        private NumericUpDown nmrConteo;
        private Label label4;
    }
}
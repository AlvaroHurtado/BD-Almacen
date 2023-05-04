namespace ConexionAlmacen
{
    partial class CFrmProductos
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
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtProducto = new TextBox();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            nmrCosto = new NumericUpDown();
            nmrPrecio = new NumericUpDown();
            nmrStock = new NumericUpDown();
            nmrDepartamento = new NumericUpDown();
            nmrProveedor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmrCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrDepartamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrProveedor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 100);
            label7.Name = "label7";
            label7.Size = new Size(127, 24);
            label7.TabIndex = 1;
            label7.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 150);
            label2.Name = "label2";
            label2.Size = new Size(148, 24);
            label2.TabIndex = 2;
            label2.Text = "Departamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 200);
            label3.Name = "label3";
            label3.Size = new Size(114, 24);
            label3.TabIndex = 3;
            label3.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 250);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 4;
            label4.Text = "Costo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 300);
            label5.Name = "label5";
            label5.Size = new Size(77, 24);
            label5.TabIndex = 5;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 350);
            label6.Name = "label6";
            label6.Size = new Size(69, 24);
            label6.TabIndex = 6;
            label6.Text = "Stock:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(300, 50);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(275, 23);
            txtProducto.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(300, 100);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(275, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(580, 364);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(700, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nmrCosto
            // 
            nmrCosto.Location = new Point(300, 250);
            nmrCosto.Name = "nmrCosto";
            nmrCosto.Size = new Size(275, 23);
            nmrCosto.TabIndex = 16;
            // 
            // nmrPrecio
            // 
            nmrPrecio.Location = new Point(300, 300);
            nmrPrecio.Name = "nmrPrecio";
            nmrPrecio.Size = new Size(275, 23);
            nmrPrecio.TabIndex = 17;
            // 
            // nmrStock
            // 
            nmrStock.Location = new Point(300, 350);
            nmrStock.Name = "nmrStock";
            nmrStock.Size = new Size(275, 23);
            nmrStock.TabIndex = 18;
            // 
            // nmrDepartamento
            // 
            nmrDepartamento.Location = new Point(300, 150);
            nmrDepartamento.Name = "nmrDepartamento";
            nmrDepartamento.Size = new Size(275, 23);
            nmrDepartamento.TabIndex = 19;
            // 
            // nmrProveedor
            // 
            nmrProveedor.Location = new Point(300, 200);
            nmrProveedor.Name = "nmrProveedor";
            nmrProveedor.Size = new Size(275, 23);
            nmrProveedor.TabIndex = 20;
            // 
            // CFrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nmrProveedor);
            Controls.Add(nmrDepartamento);
            Controls.Add(nmrStock);
            Controls.Add(nmrPrecio);
            Controls.Add(nmrCosto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "CFrmProductos";
            Text = "CFrmProductos";
            Load += CFrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)nmrCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrDepartamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtProducto;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnCancelar;
        private NumericUpDown nmrCosto;
        private NumericUpDown nmrPrecio;
        private NumericUpDown nmrStock;
        private NumericUpDown nmrDepartamento;
        private NumericUpDown nmrProveedor;
    }
}
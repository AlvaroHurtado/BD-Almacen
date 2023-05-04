namespace ConexionAlmacen
{
    partial class CMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMenu));
            btnEmpleados = new Button();
            btnProductos = new Button();
            label1 = new Label();
            label2 = new Label();
            btnProveedores = new Button();
            label3 = new Label();
            btnConteo = new Button();
            label4 = new Label();
            btnCompras = new Button();
            label5 = new Label();
            btnDepartamentos = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.Location = new Point(12, 12);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(120, 120);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnProductos
            // 
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.Location = new Point(12, 180);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(120, 120);
            btnProductos.TabIndex = 1;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(39, 135);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Empleados";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Location = new Point(39, 310);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Productos";
            // 
            // btnProveedores
            // 
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.Location = new Point(232, 180);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(120, 120);
            btnProveedores.TabIndex = 4;
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Location = new Point(259, 310);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Proveedores";
            // 
            // btnConteo
            // 
            btnConteo.Image = (Image)resources.GetObject("btnConteo.Image");
            btnConteo.Location = new Point(452, 180);
            btnConteo.Name = "btnConteo";
            btnConteo.Size = new Size(120, 120);
            btnConteo.TabIndex = 6;
            btnConteo.UseVisualStyleBackColor = true;
            btnConteo.Click += btnConteo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Location = new Point(476, 310);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Conteo Físico";
            // 
            // btnCompras
            // 
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.Location = new Point(452, 12);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(120, 120);
            btnCompras.TabIndex = 8;
            btnCompras.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Location = new Point(494, 135);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Ventas";
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.Image = (Image)resources.GetObject("btnDepartamentos.Image");
            btnDepartamentos.Location = new Point(232, 12);
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.Size = new Size(120, 120);
            btnDepartamentos.TabIndex = 10;
            btnDepartamentos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Location = new Point(250, 135);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 11;
            label6.Text = "Departamentos";
            // 
            // CMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnDepartamentos);
            Controls.Add(label5);
            Controls.Add(btnCompras);
            Controls.Add(label4);
            Controls.Add(btnConteo);
            Controls.Add(label3);
            Controls.Add(btnProveedores);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProductos);
            Controls.Add(btnEmpleados);
            Name = "CMenu";
            Text = "CMenu";
            Load += CMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpleados;
        private Button btnProductos;
        private Label label1;
        private Label label2;
        private Button btnProveedores;
        private Label label3;
        private Button btnConteo;
        private Label label4;
        private Button btnCompras;
        private Label label5;
        private Button btnDepartamentos;
        private Label label6;
    }
}
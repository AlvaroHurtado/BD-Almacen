namespace ConexionAlmacen
{
    partial class CConteoFisico
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
            btnRegresar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            BtnRefresh = new Button();
            dgvConteo = new DataGridView();
            dgvProductos = new DataGridView();
            btnDetalles = new Button();
            btnAgregarProducto = new Button();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            btnRefrescarProductos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConteo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(713, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 11;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(252, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(132, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(593, 12);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.RightToLeft = RightToLeft.Yes;
            BtnRefresh.Size = new Size(75, 23);
            BtnRefresh.TabIndex = 7;
            BtnRefresh.Text = "Refrescar";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // dgvConteo
            // 
            dgvConteo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConteo.Location = new Point(12, 40);
            dgvConteo.MultiSelect = false;
            dgvConteo.Name = "dgvConteo";
            dgvConteo.ReadOnly = true;
            dgvConteo.RowTemplate.Height = 25;
            dgvConteo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConteo.Size = new Size(775, 180);
            dgvConteo.TabIndex = 6;
            dgvConteo.CellContentClick += dgvConteo_CellContentClick;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 260);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(775, 180);
            dgvProductos.TabIndex = 12;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(713, 230);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(75, 23);
            btnDetalles.TabIndex = 13;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(12, 230);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(114, 23);
            btnAgregarProducto.TabIndex = 14;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(192, 230);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(114, 23);
            btnEditarProducto.TabIndex = 15;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(372, 230);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(114, 23);
            btnEliminarProducto.TabIndex = 16;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnRefrescarProductos
            // 
            btnRefrescarProductos.Location = new Point(593, 231);
            btnRefrescarProductos.Name = "btnRefrescarProductos";
            btnRefrescarProductos.RightToLeft = RightToLeft.Yes;
            btnRefrescarProductos.Size = new Size(75, 23);
            btnRefrescarProductos.TabIndex = 17;
            btnRefrescarProductos.Text = "Refrescar";
            btnRefrescarProductos.UseVisualStyleBackColor = true;
            btnRefrescarProductos.Click += btnRefrescarProductos_Click;
            // 
            // CConteoFisico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefrescarProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnDetalles);
            Controls.Add(dgvProductos);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(BtnRefresh);
            Controls.Add(dgvConteo);
            Name = "CConteoFisico";
            Text = "CConteoFisico";
            Load += CConteoFisico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConteo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button BtnRefresh;
        private DataGridView dgvConteo;
        private DataGridView dgvProductos;
        private Button btnDetalles;
        private Button btnAgregarProducto;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
        private Button btnRefrescarProductos;
    }
}
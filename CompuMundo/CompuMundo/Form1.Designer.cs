namespace CompuMundo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cliente = new C1.Win.C1Input.C1Button();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.Producto = new C1.Win.C1Input.C1Button();
            this.categoria = new C1.Win.C1Input.C1Button();
            this.pedido = new C1.Win.C1Input.C1Button();
            this.nuevo = new C1.Win.C1Input.C1Button();
            this.buscar = new C1.Win.C1Input.C1Button();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.cerrar = new C1.Win.C1Input.C1Button();
            this.eliminar = new C1.Win.C1Input.C1Button();
            this.editar = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).BeginInit();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.Chartreuse;
            this.Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Cliente.Image")));
            this.Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cliente.Location = new System.Drawing.Point(33, 89);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(117, 39);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            this.Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cliente.UseVisualStyleBackColor = false;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.Location = new System.Drawing.Point(203, 110);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(444, 18);
            this.c1TextBox1.TabIndex = 5;
            this.c1TextBox1.Tag = null;
            // 
            // Producto
            // 
            this.Producto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.Color.Chartreuse;
            this.Producto.Image = ((System.Drawing.Image)(resources.GetObject("Producto.Image")));
            this.Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Producto.Location = new System.Drawing.Point(33, 155);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(117, 39);
            this.Producto.TabIndex = 6;
            this.Producto.Text = "Producto";
            this.Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Producto.UseVisualStyleBackColor = false;
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.Chartreuse;
            this.categoria.Image = ((System.Drawing.Image)(resources.GetObject("categoria.Image")));
            this.categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoria.Location = new System.Drawing.Point(33, 218);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(117, 39);
            this.categoria.TabIndex = 7;
            this.categoria.Text = "Categoria";
            this.categoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoria.UseVisualStyleBackColor = false;
            // 
            // pedido
            // 
            this.pedido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedido.ForeColor = System.Drawing.Color.Chartreuse;
            this.pedido.Image = ((System.Drawing.Image)(resources.GetObject("pedido.Image")));
            this.pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pedido.Location = new System.Drawing.Point(33, 283);
            this.pedido.Name = "pedido";
            this.pedido.Size = new System.Drawing.Size(117, 39);
            this.pedido.TabIndex = 8;
            this.pedido.Text = "Pedido";
            this.pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pedido.UseVisualStyleBackColor = false;
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo.ForeColor = System.Drawing.Color.Chartreuse;
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo.Location = new System.Drawing.Point(203, 218);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(109, 59);
            this.nuevo.TabIndex = 9;
            this.nuevo.Text = "Nuevo";
            this.nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo.UseVisualStyleBackColor = false;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.Chartreuse;
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar.Location = new System.Drawing.Point(667, 100);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(111, 38);
            this.buscar.TabIndex = 10;
            this.buscar.Text = "Buscar";
            this.buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar.UseVisualStyleBackColor = false;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.c1Label1.Location = new System.Drawing.Point(212, 18);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(366, 63);
            this.c1Label1.TabIndex = 11;
            this.c1Label1.Tag = null;
            this.c1Label1.Click += new System.EventHandler(this.c1Label1_Click_1);
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.c1Label2.Location = new System.Drawing.Point(203, 140);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(51, 13);
            this.c1Label2.TabIndex = 12;
            this.c1Label2.Tag = null;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.Location = new System.Drawing.Point(203, 194);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Size = new System.Drawing.Size(444, 18);
            this.c1TextBox2.TabIndex = 13;
            this.c1TextBox2.Tag = null;
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.c1Label3.Location = new System.Drawing.Point(203, 168);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(51, 13);
            this.c1Label3.TabIndex = 14;
            this.c1Label3.Tag = null;
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.Color.Chartreuse;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrar.Location = new System.Drawing.Point(548, 218);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(109, 59);
            this.cerrar.TabIndex = 15;
            this.cerrar.Text = "Cerrar";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrar.UseVisualStyleBackColor = false;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.Color.Chartreuse;
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminar.Location = new System.Drawing.Point(433, 218);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(109, 59);
            this.eliminar.TabIndex = 16;
            this.eliminar.Text = "Eliminar";
            this.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar.UseVisualStyleBackColor = false;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.Chartreuse;
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editar.Location = new System.Drawing.Point(318, 218);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(109, 59);
            this.editar.TabIndex = 17;
            this.editar.Text = "Editar";
            this.editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1TextBox2);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.pedido);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.c1TextBox1);
            this.Controls.Add(this.Cliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1Button Cliente;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1Button Producto;
        private C1.Win.C1Input.C1Button categoria;
        private C1.Win.C1Input.C1Button pedido;
        private C1.Win.C1Input.C1Button nuevo;
        private C1.Win.C1Input.C1Button buscar;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private C1.Win.C1Input.C1Label c1Label3;
        private C1.Win.C1Input.C1Button cerrar;
        private C1.Win.C1Input.C1Button eliminar;
        private C1.Win.C1Input.C1Button editar;
    }
}


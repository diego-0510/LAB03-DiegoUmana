
namespace LABOR_3
{
    partial class frmPrincipal
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCantidadActual = new System.Windows.Forms.TextBox();
            this.lblCantidadActual = new System.Windows.Forms.Label();
            this.txtCantidadMin = new System.Windows.Forms.TextBox();
            this.lblCantidadMin = new System.Windows.Forms.Label();
            this.txtCantidadMax = new System.Windows.Forms.TextBox();
            this.lblCantidadMax = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(202, 402);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 29;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(171, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 18);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Ingresar Cliente";
            // 
            // txtCantidadActual
            // 
            this.txtCantidadActual.Location = new System.Drawing.Point(246, 344);
            this.txtCantidadActual.Name = "txtCantidadActual";
            this.txtCantidadActual.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadActual.TabIndex = 27;
            // 
            // lblCantidadActual
            // 
            this.lblCantidadActual.AutoSize = true;
            this.lblCantidadActual.Location = new System.Drawing.Point(141, 351);
            this.lblCantidadActual.Name = "lblCantidadActual";
            this.lblCantidadActual.Size = new System.Drawing.Size(93, 13);
            this.lblCantidadActual.TabIndex = 26;
            this.lblCantidadActual.Text = "Fecha Nacimiento";
            // 
            // txtCantidadMin
            // 
            this.txtCantidadMin.Location = new System.Drawing.Point(246, 299);
            this.txtCantidadMin.Name = "txtCantidadMin";
            this.txtCantidadMin.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadMin.TabIndex = 25;
            // 
            // lblCantidadMin
            // 
            this.lblCantidadMin.AutoSize = true;
            this.lblCantidadMin.Location = new System.Drawing.Point(141, 306);
            this.lblCantidadMin.Name = "lblCantidadMin";
            this.lblCantidadMin.Size = new System.Drawing.Size(31, 13);
            this.lblCantidadMin.TabIndex = 24;
            this.lblCantidadMin.Text = "Sexo";
            // 
            // txtCantidadMax
            // 
            this.txtCantidadMax.Location = new System.Drawing.Point(246, 253);
            this.txtCantidadMax.Name = "txtCantidadMax";
            this.txtCantidadMax.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadMax.TabIndex = 23;
            // 
            // lblCantidadMax
            // 
            this.lblCantidadMax.AutoSize = true;
            this.lblCantidadMax.Location = new System.Drawing.Point(141, 260);
            this.lblCantidadMax.Name = "lblCantidadMax";
            this.lblCantidadMax.Size = new System.Drawing.Size(44, 13);
            this.lblCantidadMax.TabIndex = 22;
            this.lblCantidadMax.Text = "Apellido";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(246, 206);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(141, 213);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(44, 13);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(246, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(141, 164);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(40, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Cedula";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(246, 116);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 17;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(141, 123);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "ID Cliente";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 503);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCantidadActual);
            this.Controls.Add(this.lblCantidadActual);
            this.Controls.Add(this.txtCantidadMin);
            this.Controls.Add(this.lblCantidadMin);
            this.Controls.Add(this.txtCantidadMax);
            this.Controls.Add(this.lblCantidadMax);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmPrincipal";
            this.Text = "CODEXA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCantidadActual;
        private System.Windows.Forms.Label lblCantidadActual;
        private System.Windows.Forms.TextBox txtCantidadMin;
        private System.Windows.Forms.Label lblCantidadMin;
        private System.Windows.Forms.TextBox txtCantidadMax;
        private System.Windows.Forms.Label lblCantidadMax;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}



namespace ATM
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnDesposito = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(154, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Propietario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(364, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(25, 147);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(127, 17);
            this.lblCuenta.TabIndex = 2;
            this.lblCuenta.Text = "Numero de Cuenta";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(28, 188);
            this.txtNumCuenta.MaxLength = 10;
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(364, 22);
            this.txtNumCuenta.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(25, 262);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(118, 17);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo Disponible ";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(28, 323);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(364, 22);
            this.txtSaldo.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(31, 429);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(151, 17);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad de operacion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(28, 482);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(364, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // btnDesposito
            // 
            this.btnDesposito.Location = new System.Drawing.Point(51, 558);
            this.btnDesposito.Name = "btnDesposito";
            this.btnDesposito.Size = new System.Drawing.Size(100, 43);
            this.btnDesposito.TabIndex = 8;
            this.btnDesposito.Text = "Deposito";
            this.btnDesposito.UseVisualStyleBackColor = true;
            this.btnDesposito.Click += new System.EventHandler(this.btnDesposito_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(171, 558);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(93, 43);
            this.btnRetiro.TabIndex = 9;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(287, 562);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(91, 39);
            this.btnEstado.TabIndex = 10;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 792);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnDesposito);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Cajeto ATM 5A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnDesposito;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnEstado;
    }
}


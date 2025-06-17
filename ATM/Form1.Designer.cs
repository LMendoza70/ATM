
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
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtSaldoG = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbTosino = new System.Windows.Forms.CheckBox();
            this.chbPina = new System.Windows.Forms.CheckBox();
            this.chbChamp = new System.Windows.Forms.CheckBox();
            this.chbPep = new System.Windows.Forms.CheckBox();
            this.btnIngre = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbGrande = new System.Windows.Forms.RadioButton();
            this.rdbMediano = new System.Windows.Forms.RadioButton();
            this.rdbIndividual = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbItaliana = new System.Windows.Forms.RadioButton();
            this.rdbQueso = new System.Windows.Forms.RadioButton();
            this.rdbSarten = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(364, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "hola";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(25, 146);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(127, 17);
            this.lblCuenta.TabIndex = 2;
            this.lblCuenta.Text = "Numero de Cuenta";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(28, 188);
            this.txtNumCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtSaldo.Location = new System.Drawing.Point(28, 322);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(364, 22);
            this.txtSaldo.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(31, 430);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(151, 17);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad de operacion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(28, 482);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(364, 22);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Tag = "";
            this.txtCantidad.Text = "Solo numeros";
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // btnDesposito
            // 
            this.btnDesposito.Location = new System.Drawing.Point(51, 558);
            this.btnDesposito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnRetiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(93, 43);
            this.btnRetiro.TabIndex = 9;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(287, 562);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(91, 39);
            this.btnEstado.TabIndex = 10;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(555, 79);
            this.cmbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorias.TabIndex = 11;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(555, 145);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(555, 219);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 22);
            this.txtCategoria.TabIndex = 15;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(555, 527);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(937, 283);
            this.dgvCategorias.TabIndex = 16;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            this.dgvCategorias.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Saldo";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(563, 327);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(368, 22);
            this.txtCliente.TabIndex = 20;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(563, 399);
            this.txtCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(368, 22);
            this.txtCuenta.TabIndex = 21;
            // 
            // txtSaldoG
            // 
            this.txtSaldoG.Location = new System.Drawing.Point(563, 465);
            this.txtSaldoG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaldoG.Name = "txtSaldoG";
            this.txtSaldoG.Size = new System.Drawing.Size(368, 22);
            this.txtSaldoG.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbTosino);
            this.groupBox1.Controls.Add(this.chbPina);
            this.groupBox1.Controls.Add(this.chbChamp);
            this.groupBox1.Controls.Add(this.chbPep);
            this.groupBox1.Location = new System.Drawing.Point(875, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(159, 158);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes";
            // 
            // chbTosino
            // 
            this.chbTosino.AutoSize = true;
            this.chbTosino.Location = new System.Drawing.Point(8, 116);
            this.chbTosino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbTosino.Name = "chbTosino";
            this.chbTosino.Size = new System.Drawing.Size(73, 21);
            this.chbTosino.TabIndex = 3;
            this.chbTosino.Text = "Tocino";
            this.chbTosino.UseVisualStyleBackColor = true;
            // 
            // chbPina
            // 
            this.chbPina.AutoSize = true;
            this.chbPina.Location = new System.Drawing.Point(8, 85);
            this.chbPina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbPina.Name = "chbPina";
            this.chbPina.Size = new System.Drawing.Size(58, 21);
            this.chbPina.TabIndex = 2;
            this.chbPina.Text = "Piña";
            this.chbPina.UseVisualStyleBackColor = true;
            // 
            // chbChamp
            // 
            this.chbChamp.AutoSize = true;
            this.chbChamp.Location = new System.Drawing.Point(8, 54);
            this.chbChamp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbChamp.Name = "chbChamp";
            this.chbChamp.Size = new System.Drawing.Size(116, 21);
            this.chbChamp.TabIndex = 1;
            this.chbChamp.Text = "Champiñones";
            this.chbChamp.UseVisualStyleBackColor = true;
            // 
            // chbPep
            // 
            this.chbPep.AutoSize = true;
            this.chbPep.Location = new System.Drawing.Point(8, 23);
            this.chbPep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbPep.Name = "chbPep";
            this.chbPep.Size = new System.Drawing.Size(87, 21);
            this.chbPep.TabIndex = 0;
            this.chbPep.Text = "Peperoni";
            this.chbPep.UseVisualStyleBackColor = true;
            // 
            // btnIngre
            // 
            this.btnIngre.Location = new System.Drawing.Point(1003, 479);
            this.btnIngre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngre.Name = "btnIngre";
            this.btnIngre.Size = new System.Drawing.Size(180, 28);
            this.btnIngre.TabIndex = 24;
            this.btnIngre.Text = "Ingredientes";
            this.btnIngre.UseVisualStyleBackColor = true;
            this.btnIngre.Click += new System.EventHandler(this.btnIngre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbGrande);
            this.groupBox2.Controls.Add(this.rdbMediano);
            this.groupBox2.Controls.Add(this.rdbIndividual);
            this.groupBox2.Location = new System.Drawing.Point(1085, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(135, 158);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaños";
            // 
            // rdbGrande
            // 
            this.rdbGrande.AutoSize = true;
            this.rdbGrande.Location = new System.Drawing.Point(0, 84);
            this.rdbGrande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbGrande.Name = "rdbGrande";
            this.rdbGrande.Size = new System.Drawing.Size(77, 21);
            this.rdbGrande.TabIndex = 2;
            this.rdbGrande.TabStop = true;
            this.rdbGrande.Text = "Grande";
            this.rdbGrande.UseVisualStyleBackColor = true;
            // 
            // rdbMediano
            // 
            this.rdbMediano.AutoSize = true;
            this.rdbMediano.Location = new System.Drawing.Point(0, 54);
            this.rdbMediano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMediano.Name = "rdbMediano";
            this.rdbMediano.Size = new System.Drawing.Size(83, 21);
            this.rdbMediano.TabIndex = 1;
            this.rdbMediano.TabStop = true;
            this.rdbMediano.Text = "Mediana";
            this.rdbMediano.UseVisualStyleBackColor = true;
            // 
            // rdbIndividual
            // 
            this.rdbIndividual.AutoSize = true;
            this.rdbIndividual.Location = new System.Drawing.Point(8, 23);
            this.rdbIndividual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbIndividual.Name = "rdbIndividual";
            this.rdbIndividual.Size = new System.Drawing.Size(88, 21);
            this.rdbIndividual.TabIndex = 0;
            this.rdbIndividual.TabStop = true;
            this.rdbIndividual.Text = "Individual";
            this.rdbIndividual.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbItaliana);
            this.groupBox3.Controls.Add(this.rdbQueso);
            this.groupBox3.Controls.Add(this.rdbSarten);
            this.groupBox3.Location = new System.Drawing.Point(1257, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(161, 151);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Especialidad";
            // 
            // rdbItaliana
            // 
            this.rdbItaliana.AutoSize = true;
            this.rdbItaliana.Location = new System.Drawing.Point(8, 85);
            this.rdbItaliana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbItaliana.Name = "rdbItaliana";
            this.rdbItaliana.Size = new System.Drawing.Size(74, 21);
            this.rdbItaliana.TabIndex = 2;
            this.rdbItaliana.TabStop = true;
            this.rdbItaliana.Text = "Italiana";
            this.rdbItaliana.UseVisualStyleBackColor = true;
            // 
            // rdbQueso
            // 
            this.rdbQueso.AutoSize = true;
            this.rdbQueso.Location = new System.Drawing.Point(8, 54);
            this.rdbQueso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbQueso.Name = "rdbQueso";
            this.rdbQueso.Size = new System.Drawing.Size(125, 21);
            this.rdbQueso.TabIndex = 1;
            this.rdbQueso.TabStop = true;
            this.rdbQueso.Text = "Orilla de queso";
            this.rdbQueso.UseVisualStyleBackColor = true;
            // 
            // rdbSarten
            // 
            this.rdbSarten.AutoSize = true;
            this.rdbSarten.Location = new System.Drawing.Point(8, 23);
            this.rdbSarten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSarten.Name = "rdbSarten";
            this.rdbSarten.Size = new System.Drawing.Size(71, 21);
            this.rdbSarten.TabIndex = 0;
            this.rdbSarten.TabStop = true;
            this.rdbSarten.Text = "Sarten";
            this.rdbSarten.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 835);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIngre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSaldoG);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategorias);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Cajeto ATM 5A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtSaldoG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbTosino;
        private System.Windows.Forms.CheckBox chbPina;
        private System.Windows.Forms.CheckBox chbChamp;
        private System.Windows.Forms.CheckBox chbPep;
        private System.Windows.Forms.Button btnIngre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbMediano;
        private System.Windows.Forms.RadioButton rdbIndividual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbItaliana;
        private System.Windows.Forms.RadioButton rdbQueso;
        private System.Windows.Forms.RadioButton rdbSarten;
    }
}


namespace Proyecto_p04
{
    partial class frmAerolina
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
            this.dgvAerolinea = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentidicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaisOrigen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAvion1 = new System.Windows.Forms.DataGridView();
            this.dgvAvion2 = new System.Windows.Forms.DataGridView();
            this.dgvAvion3 = new System.Windows.Forms.DataGridView();
            this.txtAvion1 = new System.Windows.Forms.TextBox();
            this.txtAvion3 = new System.Windows.Forms.TextBox();
            this.txtAvion2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvion3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAerolinea
            // 
            this.dgvAerolinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAerolinea.Location = new System.Drawing.Point(29, 270);
            this.dgvAerolinea.Name = "dgvAerolinea";
            this.dgvAerolinea.Size = new System.Drawing.Size(675, 339);
            this.dgvAerolinea.TabIndex = 0;
            this.dgvAerolinea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAerolinea_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(29, 186);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mantenimineto Aerolineas";
            // 
            // txtIdentidicacion
            // 
            this.txtIdentidicacion.Location = new System.Drawing.Point(154, 186);
            this.txtIdentidicacion.Multiline = true;
            this.txtIdentidicacion.Name = "txtIdentidicacion";
            this.txtIdentidicacion.Size = new System.Drawing.Size(167, 26);
            this.txtIdentidicacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(347, 186);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Location = new System.Drawing.Point(537, 186);
            this.txtPaisOrigen.Multiline = true;
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(167, 26);
            this.txtPaisOrigen.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pais de Origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(986, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aviones Registrados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1024, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad (1-3)";
            // 
            // dgvAvion1
            // 
            this.dgvAvion1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvion1.Location = new System.Drawing.Point(790, 307);
            this.dgvAvion1.Name = "dgvAvion1";
            this.dgvAvion1.Size = new System.Drawing.Size(567, 68);
            this.dgvAvion1.TabIndex = 13;
            this.dgvAvion1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvion1_CellClick);
            // 
            // dgvAvion2
            // 
            this.dgvAvion2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvion2.Location = new System.Drawing.Point(790, 416);
            this.dgvAvion2.Name = "dgvAvion2";
            this.dgvAvion2.Size = new System.Drawing.Size(567, 72);
            this.dgvAvion2.TabIndex = 14;
            this.dgvAvion2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvion2_CellClick);
            // 
            // dgvAvion3
            // 
            this.dgvAvion3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvion3.Location = new System.Drawing.Point(790, 536);
            this.dgvAvion3.Name = "dgvAvion3";
            this.dgvAvion3.Size = new System.Drawing.Size(567, 73);
            this.dgvAvion3.TabIndex = 15;
            this.dgvAvion3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvion3_CellClick);
            // 
            // txtAvion1
            // 
            this.txtAvion1.Location = new System.Drawing.Point(811, 270);
            this.txtAvion1.Multiline = true;
            this.txtAvion1.Name = "txtAvion1";
            this.txtAvion1.Size = new System.Drawing.Size(171, 26);
            this.txtAvion1.TabIndex = 16;
            // 
            // txtAvion3
            // 
            this.txtAvion3.Location = new System.Drawing.Point(811, 504);
            this.txtAvion3.Multiline = true;
            this.txtAvion3.Name = "txtAvion3";
            this.txtAvion3.Size = new System.Drawing.Size(171, 26);
            this.txtAvion3.TabIndex = 17;
            // 
            // txtAvion2
            // 
            this.txtAvion2.Location = new System.Drawing.Point(811, 384);
            this.txtAvion2.Multiline = true;
            this.txtAvion2.Name = "txtAvion2";
            this.txtAvion2.Size = new System.Drawing.Size(171, 26);
            this.txtAvion2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(786, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "1.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(786, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "2.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(786, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "3.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(1048, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1166, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 93);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Comentario (borrar despues): Se tiene que hacer que segun la cantidad que selecio" +
    "nes en el comboBox (1-3), se aviliten los compas para selecionar los aviones reg" +
    "istrados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1256, 629);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 43);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAerolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1393, 684);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAvion2);
            this.Controls.Add(this.txtAvion3);
            this.Controls.Add(this.txtAvion1);
            this.Controls.Add(this.dgvAvion3);
            this.Controls.Add(this.dgvAvion2);
            this.Controls.Add(this.dgvAvion1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPaisOrigen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdentidicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAerolinea);
            this.Name = "frmAerolina";
            this.Text = "frmAerolina";
            this.Load += new System.EventHandler(this.frmAerolina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvion3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAerolinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentidicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaisOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAvion1;
        private System.Windows.Forms.DataGridView dgvAvion2;
        private System.Windows.Forms.DataGridView dgvAvion3;
        private System.Windows.Forms.TextBox txtAvion1;
        private System.Windows.Forms.TextBox txtAvion3;
        private System.Windows.Forms.TextBox txtAvion2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuardar;
    }
}
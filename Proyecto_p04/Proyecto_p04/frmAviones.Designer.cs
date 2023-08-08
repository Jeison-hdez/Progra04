namespace Proyecto_p04
{
    partial class frmAviones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviones));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lstVuelo = new System.Windows.Forms.ListBox();
            this.lstMarca = new System.Windows.Forms.ListBox();
            this.lstModelo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVueloSeleccionado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 388);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 35);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnVerVuelos_Click_1);
            // 
            // lstVuelo
            // 
            this.lstVuelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstVuelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lstVuelo.FormattingEnabled = true;
            this.lstVuelo.ItemHeight = 16;
            this.lstVuelo.Location = new System.Drawing.Point(12, 58);
            this.lstVuelo.Name = "lstVuelo";
            this.lstVuelo.Size = new System.Drawing.Size(176, 324);
            this.lstVuelo.TabIndex = 1;
            // 
            // lstMarca
            // 
            this.lstMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstMarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lstMarca.FormattingEnabled = true;
            this.lstMarca.ItemHeight = 16;
            this.lstMarca.Location = new System.Drawing.Point(194, 58);
            this.lstMarca.Name = "lstMarca";
            this.lstMarca.Size = new System.Drawing.Size(166, 324);
            this.lstMarca.TabIndex = 2;
            this.lstMarca.SelectedIndexChanged += new System.EventHandler(this.lstMarca_SelectedIndexChanged);
            // 
            // lstModelo
            // 
            this.lstModelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstModelo.FormattingEnabled = true;
            this.lstModelo.ItemHeight = 16;
            this.lstModelo.Location = new System.Drawing.Point(366, 58);
            this.lstModelo.Name = "lstModelo";
            this.lstModelo.Size = new System.Drawing.Size(168, 324);
            this.lstModelo.TabIndex = 3;
            this.lstModelo.SelectedIndexChanged += new System.EventHandler(this.lstModelo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 380;
            this.label1.Text = "Vuelos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 381;
            this.pictureBox1.TabStop = false;
            // 
            // txtVueloSeleccionado
            // 
            this.txtVueloSeleccionado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtVueloSeleccionado.Location = new System.Drawing.Point(147, 388);
            this.txtVueloSeleccionado.Multiline = true;
            this.txtVueloSeleccionado.Name = "txtVueloSeleccionado";
            this.txtVueloSeleccionado.Size = new System.Drawing.Size(387, 35);
            this.txtVueloSeleccionado.TabIndex = 382;
            // 
            // frmAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 435);
            this.Controls.Add(this.txtVueloSeleccionado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstModelo);
            this.Controls.Add(this.lstMarca);
            this.Controls.Add(this.lstVuelo);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "frmAviones";
            this.Text = "frmAviones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ListBox lstVuelo;
        private System.Windows.Forms.ListBox lstMarca;
        private System.Windows.Forms.ListBox lstModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVueloSeleccionado;
    }
}
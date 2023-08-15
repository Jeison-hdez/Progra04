
namespace Proyecto_p04
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbVuelosNombres = new System.Windows.Forms.ComboBox();
            this.cbVentanilla = new System.Windows.Forms.ComboBox();
            this.cbMonetario = new System.Windows.Forms.ComboBox();
            this.cbPasajeros = new System.Windows.Forms.ComboBox();
            this.rbPasajeros = new System.Windows.Forms.RadioButton();
            this.rbCortes = new System.Windows.Forms.RadioButton();
            this.rbMoneda = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dtpFechaF = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbVuelos = new System.Windows.Forms.RadioButton();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaI.Location = new System.Drawing.Point(41, 19);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Al:";
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatos.Controls.Add(this.cbVuelosNombres);
            this.gbDatos.Controls.Add(this.cbVentanilla);
            this.gbDatos.Controls.Add(this.cbMonetario);
            this.gbDatos.Controls.Add(this.cbPasajeros);
            this.gbDatos.Controls.Add(this.rbPasajeros);
            this.gbDatos.Controls.Add(this.rbCortes);
            this.gbDatos.Controls.Add(this.rbMoneda);
            this.gbDatos.Controls.Add(this.rbVuelos);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.btnExcel);
            this.gbDatos.Controls.Add(this.btnReporte);
            this.gbDatos.Controls.Add(this.dtpFechaF);
            this.gbDatos.Controls.Add(this.dtpFechaI);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(854, 106);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos:";
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // cbVuelosNombres
            // 
            this.cbVuelosNombres.FormattingEnabled = true;
            this.cbVuelosNombres.Location = new System.Drawing.Point(624, 60);
            this.cbVuelosNombres.Name = "cbVuelosNombres";
            this.cbVuelosNombres.Size = new System.Drawing.Size(206, 21);
            this.cbVuelosNombres.TabIndex = 16;
            this.cbVuelosNombres.Visible = false;
            // 
            // cbVentanilla
            // 
            this.cbVentanilla.FormattingEnabled = true;
            this.cbVentanilla.Items.AddRange(new object[] {
            "Ventanilla 01",
            "Ventanilla 02",
            "Ventanilla 03",
            "Ventanilla 04"});
            this.cbVentanilla.Location = new System.Drawing.Point(346, 60);
            this.cbVentanilla.Name = "cbVentanilla";
            this.cbVentanilla.Size = new System.Drawing.Size(136, 21);
            this.cbVentanilla.TabIndex = 13;
            this.cbVentanilla.Visible = false;
            // 
            // cbMonetario
            // 
            this.cbMonetario.FormattingEnabled = true;
            this.cbMonetario.Items.AddRange(new object[] {
            "Vuelo",
            "Ventanilla"});
            this.cbMonetario.Location = new System.Drawing.Point(205, 60);
            this.cbMonetario.Name = "cbMonetario";
            this.cbMonetario.Size = new System.Drawing.Size(135, 21);
            this.cbMonetario.TabIndex = 12;
            this.cbMonetario.Visible = false;
            this.cbMonetario.SelectedIndexChanged += new System.EventHandler(this.cbMonetario_SelectedIndexChanged);
            // 
            // cbPasajeros
            // 
            this.cbPasajeros.FormattingEnabled = true;
            this.cbPasajeros.Items.AddRange(new object[] {
            "Avión",
            "Escala",
            "Destino"});
            this.cbPasajeros.Location = new System.Drawing.Point(488, 60);
            this.cbPasajeros.Name = "cbPasajeros";
            this.cbPasajeros.Size = new System.Drawing.Size(130, 21);
            this.cbPasajeros.TabIndex = 11;
            this.cbPasajeros.Visible = false;
            // 
            // rbPasajeros
            // 
            this.rbPasajeros.AutoSize = true;
            this.rbPasajeros.Location = new System.Drawing.Point(131, 64);
            this.rbPasajeros.Name = "rbPasajeros";
            this.rbPasajeros.Size = new System.Drawing.Size(71, 17);
            this.rbPasajeros.TabIndex = 10;
            this.rbPasajeros.Text = "Pasajeros";
            this.rbPasajeros.UseVisualStyleBackColor = true;
            this.rbPasajeros.CheckedChanged += new System.EventHandler(this.rbPasajeros_CheckedChanged);
            // 
            // rbCortes
            // 
            this.rbCortes.AutoSize = true;
            this.rbCortes.Location = new System.Drawing.Point(672, 21);
            this.rbCortes.Name = "rbCortes";
            this.rbCortes.Size = new System.Drawing.Size(55, 17);
            this.rbCortes.TabIndex = 9;
            this.rbCortes.Text = "Cortes";
            this.rbCortes.UseVisualStyleBackColor = true;
            this.rbCortes.Visible = false;
            this.rbCortes.CheckedChanged += new System.EventHandler(this.rbCortes_CheckedChanged);
            // 
            // rbMoneda
            // 
            this.rbMoneda.AutoSize = true;
            this.rbMoneda.Location = new System.Drawing.Point(53, 62);
            this.rbMoneda.Name = "rbMoneda";
            this.rbMoneda.Size = new System.Drawing.Size(72, 17);
            this.rbMoneda.TabIndex = 8;
            this.rbMoneda.Text = "Monetario";
            this.rbMoneda.UseVisualStyleBackColor = true;
            this.rbMoneda.CheckedChanged += new System.EventHandler(this.rbMoneda_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // btnExcel
            // 
            this.btnExcel.Enabled = false;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(581, 17);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(500, 17);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Ok";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dtpFechaF
            // 
            this.dtpFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaF.Location = new System.Drawing.Point(283, 19);
            this.dtpFechaF.Name = "dtpFechaF";
            this.dtpFechaF.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaF.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(854, 314);
            this.dataGridView1.TabIndex = 4;
            // 
            // rbVuelos
            // 
            this.rbVuelos.AutoSize = true;
            this.rbVuelos.Checked = true;
            this.rbVuelos.Location = new System.Drawing.Point(733, 19);
            this.rbVuelos.Name = "rbVuelos";
            this.rbVuelos.Size = new System.Drawing.Size(57, 17);
            this.rbVuelos.TabIndex = 7;
            this.rbVuelos.TabStop = true;
            this.rbVuelos.Text = "Vuelos";
            this.rbVuelos.UseVisualStyleBackColor = true;
            this.rbVuelos.Visible = false;
            this.rbVuelos.CheckedChanged += new System.EventHandler(this.rbVuelos_CheckedChanged);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMoneda;
        private System.Windows.Forms.RadioButton rbPasajeros;
        private System.Windows.Forms.RadioButton rbCortes;
        private System.Windows.Forms.ComboBox cbPasajeros;
        private System.Windows.Forms.ComboBox cbMonetario;
        private System.Windows.Forms.ComboBox cbVentanilla;
        private System.Windows.Forms.ComboBox cbVuelosNombres;
        private System.Windows.Forms.RadioButton rbVuelos;
    }
}
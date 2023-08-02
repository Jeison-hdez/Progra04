
namespace Proyecto_p04
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVentanilla4 = new System.Windows.Forms.Button();
            this.btnVentanilla3 = new System.Windows.Forms.Button();
            this.btnVentanilla2 = new System.Windows.Forms.Button();
            this.btnVentanilla1 = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnVentanilla4);
            this.panel1.Controls.Add(this.btnVentanilla3);
            this.panel1.Controls.Add(this.btnVentanilla2);
            this.panel1.Controls.Add(this.btnVentanilla1);
            this.panel1.Controls.Add(this.btnRegistrarUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnVentanilla4
            // 
            this.btnVentanilla4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla4.Location = new System.Drawing.Point(300, 9);
            this.btnVentanilla4.Name = "btnVentanilla4";
            this.btnVentanilla4.Size = new System.Drawing.Size(90, 46);
            this.btnVentanilla4.TabIndex = 4;
            this.btnVentanilla4.Text = "Ventanilla 4";
            this.btnVentanilla4.UseVisualStyleBackColor = true;
            this.btnVentanilla4.Click += new System.EventHandler(this.btnVentanilla4_Click);
            // 
            // btnVentanilla3
            // 
            this.btnVentanilla3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla3.Location = new System.Drawing.Point(204, 9);
            this.btnVentanilla3.Name = "btnVentanilla3";
            this.btnVentanilla3.Size = new System.Drawing.Size(90, 46);
            this.btnVentanilla3.TabIndex = 3;
            this.btnVentanilla3.Text = "Ventanilla 3";
            this.btnVentanilla3.UseVisualStyleBackColor = true;
            this.btnVentanilla3.Click += new System.EventHandler(this.btnVentanilla3_Click);
            // 
            // btnVentanilla2
            // 
            this.btnVentanilla2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla2.Location = new System.Drawing.Point(108, 9);
            this.btnVentanilla2.Name = "btnVentanilla2";
            this.btnVentanilla2.Size = new System.Drawing.Size(90, 46);
            this.btnVentanilla2.TabIndex = 2;
            this.btnVentanilla2.Text = "Ventanilla 2";
            this.btnVentanilla2.UseVisualStyleBackColor = true;
            this.btnVentanilla2.Click += new System.EventHandler(this.btnVentanilla2_Click);
            // 
            // btnVentanilla1
            // 
            this.btnVentanilla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla1.Location = new System.Drawing.Point(12, 9);
            this.btnVentanilla1.Name = "btnVentanilla1";
            this.btnVentanilla1.Size = new System.Drawing.Size(90, 46);
            this.btnVentanilla1.TabIndex = 1;
            this.btnVentanilla1.Text = "Ventanilla 1";
            this.btnVentanilla1.UseVisualStyleBackColor = true;
            this.btnVentanilla1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(698, 9);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(90, 46);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registro Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 386);
            this.panel2.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnVentanilla4;
        private System.Windows.Forms.Button btnVentanilla3;
        private System.Windows.Forms.Button btnVentanilla2;
        private System.Windows.Forms.Button btnVentanilla1;
    }
}
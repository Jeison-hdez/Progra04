
namespace Proyecto_p04
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
            this.Gerente = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gerente
            // 
            this.Gerente.Location = new System.Drawing.Point(457, 130);
            this.Gerente.Name = "Gerente";
            this.Gerente.Size = new System.Drawing.Size(93, 32);
            this.Gerente.TabIndex = 15;
            this.Gerente.Text = "button3";
            this.Gerente.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(261, 130);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(93, 32);
            this.Usuario.TabIndex = 14;
            this.Usuario.Text = "button2";
            this.Usuario.UseVisualStyleBackColor = true;
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // Cliente
            // 
            this.Cliente.Location = new System.Drawing.Point(60, 130);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(93, 32);
            this.Cliente.TabIndex = 13;
            this.Cliente.Text = "button1";
            this.Cliente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gerente (Datos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Abrir Caja (Usuario)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registrar cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione una opcion de su preferencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nota Para antes de ejecutarla: Debe registrar un usuario primero, para tener una " +
    "caja abierta ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 243);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gerente);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gerente;
        private System.Windows.Forms.Button Usuario;
        private System.Windows.Forms.Button Cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}


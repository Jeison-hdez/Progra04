
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlTitutlo = new System.Windows.Forms.Panel();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnSesion = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnManPiloto = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnManAvion = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnManAerolineas = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnManUsuarios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVentanilla4 = new System.Windows.Forms.Button();
            this.btnVentanilla3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVentanilla2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVentanilla1 = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultaVuelo = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pnlTitutlo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitutlo
            // 
            this.pnlTitutlo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.pnlTitutlo.Controls.Add(this.pbRestaurar);
            this.pnlTitutlo.Controls.Add(this.pbMinimizar);
            this.pnlTitutlo.Controls.Add(this.pbMaximizar);
            this.pnlTitutlo.Controls.Add(this.pbCerrar);
            this.pnlTitutlo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitutlo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitutlo.Name = "pnlTitutlo";
            this.pnlTitutlo.Size = new System.Drawing.Size(1300, 31);
            this.pnlTitutlo.TabIndex = 0;
            this.pnlTitutlo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitutlo_MouseDown);
            this.pnlTitutlo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitutlo_MouseMove);
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurar.Image")));
            this.pbRestaurar.Location = new System.Drawing.Point(1246, 6);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(18, 19);
            this.pbRestaurar.TabIndex = 3;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1222, 6);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(18, 19);
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(1246, 6);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(18, 19);
            this.pbMaximizar.TabIndex = 1;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Visible = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1270, 6);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(18, 19);
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(165)))));
            this.pnlMenu.Controls.Add(this.panel14);
            this.pnlMenu.Controls.Add(this.btnConsultaVuelo);
            this.pnlMenu.Controls.Add(this.panel13);
            this.pnlMenu.Controls.Add(this.btnSesion);
            this.pnlMenu.Controls.Add(this.panel12);
            this.pnlMenu.Controls.Add(this.panel11);
            this.pnlMenu.Controls.Add(this.btnManPiloto);
            this.pnlMenu.Controls.Add(this.panel10);
            this.pnlMenu.Controls.Add(this.panel9);
            this.pnlMenu.Controls.Add(this.btnManAvion);
            this.pnlMenu.Controls.Add(this.panel8);
            this.pnlMenu.Controls.Add(this.btnManAerolineas);
            this.pnlMenu.Controls.Add(this.panel7);
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.btnPermisos);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.btnManUsuarios);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.btnVentanilla4);
            this.pnlMenu.Controls.Add(this.btnVentanilla3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.btnVentanilla2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnVentanilla1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 31);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(164, 619);
            this.pnlMenu.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel13.Location = new System.Drawing.Point(0, 587);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(8, 32);
            this.panel13.TabIndex = 12;
            // 
            // btnSesion
            // 
            this.btnSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSesion.FlatAppearance.BorderSize = 0;
            this.btnSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesion.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnSesion.Image")));
            this.btnSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSesion.Location = new System.Drawing.Point(10, 587);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(155, 32);
            this.btnSesion.TabIndex = 19;
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel12.Location = new System.Drawing.Point(0, 283);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(183, 5);
            this.panel12.TabIndex = 15;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel11.Location = new System.Drawing.Point(-11, 161);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(183, 5);
            this.panel11.TabIndex = 14;
            // 
            // btnManPiloto
            // 
            this.btnManPiloto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManPiloto.FlatAppearance.BorderSize = 0;
            this.btnManPiloto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnManPiloto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManPiloto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManPiloto.Location = new System.Drawing.Point(10, 247);
            this.btnManPiloto.Name = "btnManPiloto";
            this.btnManPiloto.Size = new System.Drawing.Size(226, 32);
            this.btnManPiloto.TabIndex = 18;
            this.btnManPiloto.Text = "     Gestión Piloto";
            this.btnManPiloto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManPiloto.UseVisualStyleBackColor = true;
            this.btnManPiloto.Click += new System.EventHandler(this.btnManPiloto_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel10.Location = new System.Drawing.Point(0, 247);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(8, 32);
            this.panel10.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel9.Location = new System.Drawing.Point(0, 209);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(8, 32);
            this.panel9.TabIndex = 15;
            // 
            // btnManAvion
            // 
            this.btnManAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManAvion.FlatAppearance.BorderSize = 0;
            this.btnManAvion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnManAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManAvion.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManAvion.Location = new System.Drawing.Point(10, 209);
            this.btnManAvion.Name = "btnManAvion";
            this.btnManAvion.Size = new System.Drawing.Size(226, 32);
            this.btnManAvion.TabIndex = 16;
            this.btnManAvion.Text = "    Gestión Vuelos";
            this.btnManAvion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManAvion.UseVisualStyleBackColor = true;
            this.btnManAvion.Click += new System.EventHandler(this.btnManAvion_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel8.Location = new System.Drawing.Point(0, 171);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 32);
            this.panel8.TabIndex = 13;
            // 
            // btnManAerolineas
            // 
            this.btnManAerolineas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManAerolineas.FlatAppearance.BorderSize = 0;
            this.btnManAerolineas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnManAerolineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManAerolineas.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManAerolineas.Location = new System.Drawing.Point(10, 171);
            this.btnManAerolineas.Name = "btnManAerolineas";
            this.btnManAerolineas.Size = new System.Drawing.Size(226, 32);
            this.btnManAerolineas.TabIndex = 14;
            this.btnManAerolineas.Text = "Gestión Aerolineas";
            this.btnManAerolineas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManAerolineas.UseVisualStyleBackColor = true;
            this.btnManAerolineas.Click += new System.EventHandler(this.btnManAerolineas_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel7.Location = new System.Drawing.Point(0, 365);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 32);
            this.panel7.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel6.Location = new System.Drawing.Point(0, 329);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 32);
            this.panel6.TabIndex = 9;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(10, 365);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(226, 32);
            this.btnReportes.TabIndex = 12;
            this.btnReportes.Text = "       Reportería";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel5.Location = new System.Drawing.Point(0, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 32);
            this.panel5.TabIndex = 7;
            // 
            // btnPermisos
            // 
            this.btnPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisos.Location = new System.Drawing.Point(10, 329);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(226, 32);
            this.btnPermisos.TabIndex = 10;
            this.btnPermisos.Text = "Permisos Usuarios";
            this.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisos.UseVisualStyleBackColor = true;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel4.Location = new System.Drawing.Point(0, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 32);
            this.panel4.TabIndex = 5;
            // 
            // btnManUsuarios
            // 
            this.btnManUsuarios.FlatAppearance.BorderSize = 0;
            this.btnManUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnManUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManUsuarios.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManUsuarios.Location = new System.Drawing.Point(10, 293);
            this.btnManUsuarios.Name = "btnManUsuarios";
            this.btnManUsuarios.Size = new System.Drawing.Size(226, 32);
            this.btnManUsuarios.TabIndex = 8;
            this.btnManUsuarios.Text = "  Gestión Usuarios";
            this.btnManUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManUsuarios.UseVisualStyleBackColor = true;
            this.btnManUsuarios.Click += new System.EventHandler(this.btnManUsuarios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 32);
            this.panel3.TabIndex = 3;
            // 
            // btnVentanilla4
            // 
            this.btnVentanilla4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentanilla4.FlatAppearance.BorderSize = 0;
            this.btnVentanilla4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnVentanilla4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentanilla4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla4.Location = new System.Drawing.Point(10, 124);
            this.btnVentanilla4.Name = "btnVentanilla4";
            this.btnVentanilla4.Size = new System.Drawing.Size(226, 32);
            this.btnVentanilla4.TabIndex = 6;
            this.btnVentanilla4.Text = "     Ventanilla 04";
            this.btnVentanilla4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentanilla4.UseVisualStyleBackColor = true;
            this.btnVentanilla4.Click += new System.EventHandler(this.btnVentanilla4_Click);
            // 
            // btnVentanilla3
            // 
            this.btnVentanilla3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentanilla3.FlatAppearance.BorderSize = 0;
            this.btnVentanilla3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnVentanilla3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentanilla3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla3.Location = new System.Drawing.Point(10, 88);
            this.btnVentanilla3.Name = "btnVentanilla3";
            this.btnVentanilla3.Size = new System.Drawing.Size(226, 32);
            this.btnVentanilla3.TabIndex = 4;
            this.btnVentanilla3.Text = "     Ventanilla 03";
            this.btnVentanilla3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentanilla3.UseVisualStyleBackColor = true;
            this.btnVentanilla3.Click += new System.EventHandler(this.btnVentanilla3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 32);
            this.panel2.TabIndex = 2;
            // 
            // btnVentanilla2
            // 
            this.btnVentanilla2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentanilla2.FlatAppearance.BorderSize = 0;
            this.btnVentanilla2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnVentanilla2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentanilla2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla2.Location = new System.Drawing.Point(10, 54);
            this.btnVentanilla2.Name = "btnVentanilla2";
            this.btnVentanilla2.Size = new System.Drawing.Size(226, 32);
            this.btnVentanilla2.TabIndex = 2;
            this.btnVentanilla2.Text = "     Ventanilla 02";
            this.btnVentanilla2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentanilla2.UseVisualStyleBackColor = true;
            this.btnVentanilla2.Click += new System.EventHandler(this.btnVentanilla2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 32);
            this.panel1.TabIndex = 1;
            // 
            // btnVentanilla1
            // 
            this.btnVentanilla1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentanilla1.FlatAppearance.BorderSize = 0;
            this.btnVentanilla1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnVentanilla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentanilla1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentanilla1.Location = new System.Drawing.Point(10, 20);
            this.btnVentanilla1.Name = "btnVentanilla1";
            this.btnVentanilla1.Size = new System.Drawing.Size(226, 32);
            this.btnVentanilla1.TabIndex = 0;
            this.btnVentanilla1.Text = "     Ventanilla 01";
            this.btnVentanilla1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentanilla1.UseVisualStyleBackColor = true;
            this.btnVentanilla1.Click += new System.EventHandler(this.btnVentanilla1_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.pictureBox1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(164, 31);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1136, 619);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultaVuelo
            // 
            this.btnConsultaVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaVuelo.FlatAppearance.BorderSize = 0;
            this.btnConsultaVuelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnConsultaVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaVuelo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaVuelo.Location = new System.Drawing.Point(9, 403);
            this.btnConsultaVuelo.Name = "btnConsultaVuelo";
            this.btnConsultaVuelo.Size = new System.Drawing.Size(226, 32);
            this.btnConsultaVuelo.TabIndex = 20;
            this.btnConsultaVuelo.Text = "   Consultar Vuelo";
            this.btnConsultaVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaVuelo.UseVisualStyleBackColor = true;
            this.btnConsultaVuelo.Click += new System.EventHandler(this.btnConsultaVuelo_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.panel14.Location = new System.Drawing.Point(0, 403);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(8, 32);
            this.panel14.TabIndex = 12;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitutlo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlTitutlo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitutlo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.Button btnVentanilla1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVentanilla2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVentanilla3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVentanilla4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnManUsuarios;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnManAerolineas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnManAvion;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnManPiloto;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnConsultaVuelo;
    }
}
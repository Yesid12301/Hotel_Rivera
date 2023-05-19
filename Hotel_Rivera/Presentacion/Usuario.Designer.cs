namespace Hotel_Rivera.Presentacion
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblVacios = new System.Windows.Forms.Label();
            this.ptbMostrar = new System.Windows.Forms.PictureBox();
            this.ptbOcultar = new System.Windows.Forms.PictureBox();
            this.ptbMostrar1 = new System.Windows.Forms.PictureBox();
            this.ptbOcultar1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOcultar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContraseñaActual.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaActual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContraseñaActual.Location = new System.Drawing.Point(82, 90);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(174, 24);
            this.txtContraseñaActual.TabIndex = 0;
            this.txtContraseñaActual.UseSystemPasswordChar = true;
            this.txtContraseñaActual.Click += new System.EventHandler(this.txtContraseñaActual_Click);
            // 
            // txtNueva
            // 
            this.txtNueva.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNueva.Location = new System.Drawing.Point(82, 156);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(174, 24);
            this.txtNueva.TabIndex = 1;
            this.txtNueva.UseSystemPasswordChar = true;
            this.txtNueva.Click += new System.EventHandler(this.txtNueva_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConfirmar.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConfirmar.Location = new System.Drawing.Point(82, 223);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(174, 24);
            this.txtConfirmar.TabIndex = 2;
            this.txtConfirmar.UseSystemPasswordChar = true;
            this.txtConfirmar.Click += new System.EventHandler(this.txtConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña Actual :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña Nueva :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar Contraseña :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(117, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(271, -2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 34);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 49);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Orange;
            this.lblerror.Location = new System.Drawing.Point(52, 257);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(204, 17);
            this.lblerror.TabIndex = 9;
            this.lblerror.Text = "¡La contraseña actual es incorrecta!";
            this.lblerror.Visible = false;
            // 
            // lblVacios
            // 
            this.lblVacios.AutoSize = true;
            this.lblVacios.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacios.ForeColor = System.Drawing.Color.Orange;
            this.lblVacios.Location = new System.Drawing.Point(27, 257);
            this.lblVacios.Name = "lblVacios";
            this.lblVacios.Size = new System.Drawing.Size(274, 17);
            this.lblVacios.TabIndex = 10;
            this.lblVacios.Text = "¡ Las contraseñas no coinciden o campos vacios !";
            this.lblVacios.Visible = false;
            // 
            // ptbMostrar
            // 
            this.ptbMostrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMostrar.Image")));
            this.ptbMostrar.Location = new System.Drawing.Point(262, 223);
            this.ptbMostrar.Name = "ptbMostrar";
            this.ptbMostrar.Size = new System.Drawing.Size(39, 24);
            this.ptbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMostrar.TabIndex = 11;
            this.ptbMostrar.TabStop = false;
            this.ptbMostrar.Click += new System.EventHandler(this.ptbMostrar_Click);
            // 
            // ptbOcultar
            // 
            this.ptbOcultar.Image = ((System.Drawing.Image)(resources.GetObject("ptbOcultar.Image")));
            this.ptbOcultar.Location = new System.Drawing.Point(260, 223);
            this.ptbOcultar.Name = "ptbOcultar";
            this.ptbOcultar.Size = new System.Drawing.Size(41, 24);
            this.ptbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbOcultar.TabIndex = 12;
            this.ptbOcultar.TabStop = false;
            this.ptbOcultar.Visible = false;
            this.ptbOcultar.Click += new System.EventHandler(this.ptbOcultar_Click);
            // 
            // ptbMostrar1
            // 
            this.ptbMostrar1.Image = ((System.Drawing.Image)(resources.GetObject("ptbMostrar1.Image")));
            this.ptbMostrar1.Location = new System.Drawing.Point(262, 90);
            this.ptbMostrar1.Name = "ptbMostrar1";
            this.ptbMostrar1.Size = new System.Drawing.Size(39, 24);
            this.ptbMostrar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMostrar1.TabIndex = 13;
            this.ptbMostrar1.TabStop = false;
            this.ptbMostrar1.Click += new System.EventHandler(this.ptbMostrar1_Click);
            // 
            // ptbOcultar1
            // 
            this.ptbOcultar1.Image = ((System.Drawing.Image)(resources.GetObject("ptbOcultar1.Image")));
            this.ptbOcultar1.Location = new System.Drawing.Point(262, 90);
            this.ptbOcultar1.Name = "ptbOcultar1";
            this.ptbOcultar1.Size = new System.Drawing.Size(38, 24);
            this.ptbOcultar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbOcultar1.TabIndex = 14;
            this.ptbOcultar1.TabStop = false;
            this.ptbOcultar1.Visible = false;
            this.ptbOcultar1.Click += new System.EventHandler(this.ptbOcultar1_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(313, 328);
            this.Controls.Add(this.ptbOcultar1);
            this.Controls.Add(this.ptbMostrar1);
            this.Controls.Add(this.ptbOcultar);
            this.Controls.Add(this.ptbMostrar);
            this.Controls.Add(this.lblVacios);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.txtContraseñaActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMostrar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOcultar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblVacios;
        private System.Windows.Forms.PictureBox ptbMostrar;
        private System.Windows.Forms.PictureBox ptbOcultar;
        private System.Windows.Forms.PictureBox ptbMostrar1;
        private System.Windows.Forms.PictureBox ptbOcultar1;
    }
}
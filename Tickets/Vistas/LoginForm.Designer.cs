namespace Vistas
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.VisualizarContraseñaButton = new System.Windows.Forms.Button();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(13, 81);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(227, 22);
            this.UsuarioTextBox.TabIndex = 2;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTextBox.Location = new System.Drawing.Point(13, 135);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.PasswordChar = '*';
            this.ContraseñaTextBox.Size = new System.Drawing.Size(227, 22);
            this.ContraseñaTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(141, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bienvenido";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(139, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soporte Tecnico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(128, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Empresa Tecnology";
            // 
            // AceptarButton
            // 
            this.AceptarButton.BackColor = System.Drawing.Color.Navy;
            this.AceptarButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.ForeColor = System.Drawing.Color.White;
            this.AceptarButton.Image = global::Vistas.Properties.Resources.aceptar;
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.Location = new System.Drawing.Point(93, 178);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(101, 36);
            this.AceptarButton.TabIndex = 4;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButton.UseVisualStyleBackColor = false;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.Navy;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ForeColor = System.Drawing.Color.White;
            this.CancelarButton.Image = global::Vistas.Properties.Resources.cancelar;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(208, 178);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(102, 36);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // VisualizarContraseñaButton
            // 
            this.VisualizarContraseñaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(223)))));
            this.VisualizarContraseñaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisualizarContraseñaButton.Image = global::Vistas.Properties.Resources.ojo;
            this.VisualizarContraseñaButton.Location = new System.Drawing.Point(242, 131);
            this.VisualizarContraseñaButton.Name = "VisualizarContraseñaButton";
            this.VisualizarContraseñaButton.Size = new System.Drawing.Size(33, 28);
            this.VisualizarContraseñaButton.TabIndex = 8;
            this.VisualizarContraseñaButton.UseVisualStyleBackColor = false;
            this.VisualizarContraseñaButton.Click += new System.EventHandler(this.VisualizarContraseñaButton_Click);
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(223)))));
            this.LoginPictureBox.Image = global::Vistas.Properties.Resources.usuario;
            this.LoginPictureBox.Location = new System.Drawing.Point(285, 61);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(97, 96);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPictureBox.TabIndex = 6;
            this.LoginPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(223)))));
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(397, 223);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VisualizarContraseñaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VisualizarContraseñaButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


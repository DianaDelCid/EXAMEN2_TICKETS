namespace Vistas
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionRespuestaTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionSolicitudTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TipoSoporteComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.CrearTicketButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalAPagarTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.IconoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TICKETS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(817, 19);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(170, 26);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(79, 18);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(245, 26);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.groupBox2.Controls.Add(this.BuscarClienteButton);
            this.groupBox2.Controls.Add(this.NombreClienteTextBox);
            this.groupBox2.Controls.Add(this.IdentidadTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Cliente";
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.BuscarClienteButton.Image = global::Vistas.Properties.Resources.buscar;
            this.BuscarClienteButton.Location = new System.Drawing.Point(259, 49);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(38, 34);
            this.BuscarClienteButton.TabIndex = 3;
            this.BuscarClienteButton.UseVisualStyleBackColor = false;
            this.BuscarClienteButton.Click += new System.EventHandler(this.BuscarClienteButton_Click);
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteTextBox.Location = new System.Drawing.Point(10, 91);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(287, 26);
            this.NombreClienteTextBox.TabIndex = 2;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentidadTextBox.Location = new System.Drawing.Point(10, 53);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(245, 26);
            this.IdentidadTextBox.TabIndex = 1;
            this.IdentidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identidad";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.groupBox3.Controls.Add(this.AgregarButton);
            this.groupBox3.Controls.Add(this.PrecioTextBox);
            this.groupBox3.Controls.Add(this.DescripcionRespuestaTextBox);
            this.groupBox3.Controls.Add(this.DescripcionSolicitudTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TipoSoporteComboBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(338, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 131);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Ticket";
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.AgregarButton.Image = global::Vistas.Properties.Resources.aceptar;
            this.AgregarButton.Location = new System.Drawing.Point(624, 17);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(35, 32);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.UseVisualStyleBackColor = false;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.Location = new System.Drawing.Point(404, 20);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(218, 26);
            this.PrecioTextBox.TabIndex = 7;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // DescripcionRespuestaTextBox
            // 
            this.DescripcionRespuestaTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionRespuestaTextBox.Location = new System.Drawing.Point(180, 89);
            this.DescripcionRespuestaTextBox.Name = "DescripcionRespuestaTextBox";
            this.DescripcionRespuestaTextBox.Size = new System.Drawing.Size(479, 26);
            this.DescripcionRespuestaTextBox.TabIndex = 6;
            // 
            // DescripcionSolicitudTextBox
            // 
            this.DescripcionSolicitudTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionSolicitudTextBox.Location = new System.Drawing.Point(180, 57);
            this.DescripcionSolicitudTextBox.Name = "DescripcionSolicitudTextBox";
            this.DescripcionSolicitudTextBox.Size = new System.Drawing.Size(479, 26);
            this.DescripcionSolicitudTextBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Descripción Respuesta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Descripción Solicitud:";
            // 
            // TipoSoporteComboBox
            // 
            this.TipoSoporteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoSoporteComboBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSoporteComboBox.FormattingEnabled = true;
            this.TipoSoporteComboBox.Items.AddRange(new object[] {
            "Equipo de Cómputo",
            "Celulares"});
            this.TipoSoporteComboBox.Location = new System.Drawing.Point(128, 18);
            this.TipoSoporteComboBox.Name = "TipoSoporteComboBox";
            this.TipoSoporteComboBox.Size = new System.Drawing.Size(170, 26);
            this.TipoSoporteComboBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de Soporte:";
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalleDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(-1, 247);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(1020, 150);
            this.DetalleDataGridView.TabIndex = 4;
            // 
            // CrearTicketButton
            // 
            this.CrearTicketButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CrearTicketButton.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearTicketButton.ForeColor = System.Drawing.Color.White;
            this.CrearTicketButton.Location = new System.Drawing.Point(17, 483);
            this.CrearTicketButton.Name = "CrearTicketButton";
            this.CrearTicketButton.Size = new System.Drawing.Size(111, 36);
            this.CrearTicketButton.TabIndex = 5;
            this.CrearTicketButton.Text = "Crear Tickect";
            this.CrearTicketButton.UseVisualStyleBackColor = false;
            this.CrearTicketButton.Click += new System.EventHandler(this.CrearTicketButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.CancelarButton.ForeColor = System.Drawing.Color.White;
            this.CancelarButton.Location = new System.Drawing.Point(134, 483);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(108, 36);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sub Total:";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTextBox.Location = new System.Drawing.Point(902, 404);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(117, 26);
            this.SubtotalTextBox.TabIndex = 8;
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISVTextBox.Location = new System.Drawing.Point(902, 436);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(117, 26);
            this.ISVTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(801, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "ISV:";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTextBox.Location = new System.Drawing.Point(902, 468);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(117, 26);
            this.DescuentoTextBox.TabIndex = 12;
            this.DescuentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(801, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descuento:";
            // 
            // TotalAPagarTextBox
            // 
            this.TotalAPagarTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAPagarTextBox.Location = new System.Drawing.Point(902, 500);
            this.TotalAPagarTextBox.Name = "TotalAPagarTextBox";
            this.TotalAPagarTextBox.ReadOnly = true;
            this.TotalAPagarTextBox.Size = new System.Drawing.Size(117, 26);
            this.TotalAPagarTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(801, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total a Pagar:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // IconoPictureBox
            // 
            this.IconoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(223)))));
            this.IconoPictureBox.Image = global::Vistas.Properties.Resources.icono;
            this.IconoPictureBox.Location = new System.Drawing.Point(1067, 40);
            this.IconoPictureBox.Name = "IconoPictureBox";
            this.IconoPictureBox.Size = new System.Drawing.Size(192, 192);
            this.IconoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconoPictureBox.TabIndex = 31;
            this.IconoPictureBox.TabStop = false;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1303, 529);
            this.Controls.Add(this.IconoPictureBox);
            this.Controls.Add(this.TotalAPagarTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.CrearTicketButton);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketForm";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button CrearTicketButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalAPagarTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TipoSoporteComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox DescripcionRespuestaTextBox;
        private System.Windows.Forms.TextBox DescripcionSolicitudTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.PictureBox IconoPictureBox;
    }
}
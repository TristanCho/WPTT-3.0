
namespace capapresentacion
{
    partial class FrmDetalleProyecto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleProyecto));
            this.lbl_idproyecto = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloProyecto = new System.Windows.Forms.Label();
            this.txtObservacionesProyecto = new System.Windows.Forms.RichTextBox();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.txtTituloProyecto = new System.Windows.Forms.TextBox();
            this.mensajetool = new System.Windows.Forms.ToolTip(this.components);
            this.iconoerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtFechaProyecto = new System.Windows.Forms.DateTimePicker();
            this.lEdicion = new System.Windows.Forms.Label();
            this.txtcodigoProyecto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idproyecto
            // 
            this.lbl_idproyecto.AutoSize = true;
            this.lbl_idproyecto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idproyecto.Location = new System.Drawing.Point(18, 37);
            this.lbl_idproyecto.Name = "lbl_idproyecto";
            this.lbl_idproyecto.Size = new System.Drawing.Size(85, 18);
            this.lbl_idproyecto.TabIndex = 1;
            this.lbl_idproyecto.Text = "Proyecto:";
            this.lbl_idproyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(12, 140);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 18);
            this.lblObservaciones.TabIndex = 11;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha:";
            // 
            // lblTituloProyecto
            // 
            this.lblTituloProyecto.AutoSize = true;
            this.lblTituloProyecto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProyecto.Location = new System.Drawing.Point(300, 38);
            this.lblTituloProyecto.Name = "lblTituloProyecto";
            this.lblTituloProyecto.Size = new System.Drawing.Size(62, 18);
            this.lblTituloProyecto.TabIndex = 8;
            this.lblTituloProyecto.Text = "Título:";
            this.lblTituloProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObservacionesProyecto
            // 
            this.txtObservacionesProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacionesProyecto.Enabled = false;
            this.txtObservacionesProyecto.Location = new System.Drawing.Point(15, 172);
            this.txtObservacionesProyecto.Name = "txtObservacionesProyecto";
            this.txtObservacionesProyecto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservacionesProyecto.Size = new System.Drawing.Size(725, 310);
            this.txtObservacionesProyecto.TabIndex = 14;
            this.txtObservacionesProyecto.Text = "";
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProyecto.Location = new System.Drawing.Point(109, 37);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(162, 21);
            this.txtIdProyecto.TabIndex = 15;
            // 
            // txtTituloProyecto
            // 
            this.txtTituloProyecto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloProyecto.Location = new System.Drawing.Point(368, 38);
            this.txtTituloProyecto.Name = "txtTituloProyecto";
            this.txtTituloProyecto.Size = new System.Drawing.Size(223, 21);
            this.txtTituloProyecto.TabIndex = 16;
            // 
            // iconoerror
            // 
            this.iconoerror.ContainerControl = this;
            // 
            // dtFechaProyecto
            // 
            this.dtFechaProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaProyecto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaProyecto.Location = new System.Drawing.Point(368, 79);
            this.dtFechaProyecto.Name = "dtFechaProyecto";
            this.dtFechaProyecto.Size = new System.Drawing.Size(223, 20);
            this.dtFechaProyecto.TabIndex = 18;
            // 
            // lEdicion
            // 
            this.lEdicion.AutoSize = true;
            this.lEdicion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEdicion.Location = new System.Drawing.Point(27, 11);
            this.lEdicion.Name = "lEdicion";
            this.lEdicion.Size = new System.Drawing.Size(101, 14);
            this.lEdicion.TabIndex = 25;
            this.lEdicion.Text = "[MODO LECTURA]";
            // 
            // txtcodigoProyecto
            // 
            this.txtcodigoProyecto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoProyecto.Location = new System.Drawing.Point(109, 78);
            this.txtcodigoProyecto.Name = "txtcodigoProyecto";
            this.txtcodigoProyecto.Size = new System.Drawing.Size(162, 21);
            this.txtcodigoProyecto.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "C Proyecto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmDetalleProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(749, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodigoProyecto);
            this.Controls.Add(this.lEdicion);
            this.Controls.Add(this.dtFechaProyecto);
            this.Controls.Add(this.txtTituloProyecto);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.txtObservacionesProyecto);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloProyecto);
            this.Controls.Add(this.lbl_idproyecto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetalleProyecto";
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.FrmDetalleProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idproyecto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloProyecto;
        private System.Windows.Forms.RichTextBox txtObservacionesProyecto;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.TextBox txtTituloProyecto;
        private System.Windows.Forms.ToolTip mensajetool;
        private System.Windows.Forms.ErrorProvider iconoerror;
        private System.Windows.Forms.DateTimePicker dtFechaProyecto;
        private System.Windows.Forms.Label lEdicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigoProyecto;
    }
}
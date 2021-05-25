
namespace capapresentacion
{
    partial class FrmDetalleAplicacion
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
            this.lEdicion = new System.Windows.Forms.Label();
            this.txtTituloAplicacion = new System.Windows.Forms.TextBox();
            this.txtIdAplicacion = new System.Windows.Forms.TextBox();
            this.panelDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTituloAplicacion = new System.Windows.Forms.Label();
            this.lbl_IdAplicacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lEdicion
            // 
            this.lEdicion.AutoSize = true;
            this.lEdicion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEdicion.Location = new System.Drawing.Point(27, 11);
            this.lEdicion.Name = "lEdicion";
            this.lEdicion.Size = new System.Drawing.Size(101, 14);
            this.lEdicion.TabIndex = 39;
            this.lEdicion.Text = "[MODO LECTURA]";
            // 
            // txtTituloAplicacion
            // 
            this.txtTituloAplicacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloAplicacion.Location = new System.Drawing.Point(368, 38);
            this.txtTituloAplicacion.Name = "txtTituloAplicacion";
            this.txtTituloAplicacion.ReadOnly = true;
            this.txtTituloAplicacion.Size = new System.Drawing.Size(223, 21);
            this.txtTituloAplicacion.TabIndex = 37;
            // 
            // txtIdAplicacion
            // 
            this.txtIdAplicacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAplicacion.Location = new System.Drawing.Point(67, 39);
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.ReadOnly = true;
            this.txtIdAplicacion.Size = new System.Drawing.Size(162, 21);
            this.txtIdAplicacion.TabIndex = 36;
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDescripcion.Location = new System.Drawing.Point(15, 132);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.ReadOnly = true;
            this.panelDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.panelDescripcion.Size = new System.Drawing.Size(725, 328);
            this.panelDescripcion.TabIndex = 35;
            this.panelDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 18);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblTituloAplicacion
            // 
            this.lblTituloAplicacion.AutoSize = true;
            this.lblTituloAplicacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAplicacion.Location = new System.Drawing.Point(300, 38);
            this.lblTituloAplicacion.Name = "lblTituloAplicacion";
            this.lblTituloAplicacion.Size = new System.Drawing.Size(62, 18);
            this.lblTituloAplicacion.TabIndex = 32;
            this.lblTituloAplicacion.Text = "Título:";
            this.lblTituloAplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_IdAplicacion
            // 
            this.lbl_IdAplicacion.AutoSize = true;
            this.lbl_IdAplicacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdAplicacion.Location = new System.Drawing.Point(27, 41);
            this.lbl_IdAplicacion.Name = "lbl_IdAplicacion";
            this.lbl_IdAplicacion.Size = new System.Drawing.Size(34, 18);
            this.lbl_IdAplicacion.TabIndex = 31;
            this.lbl_IdAplicacion.Text = "ID:";
            this.lbl_IdAplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmDetalleAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(749, 494);
            this.Controls.Add(this.lEdicion);
            this.Controls.Add(this.txtTituloAplicacion);
            this.Controls.Add(this.txtIdAplicacion);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTituloAplicacion);
            this.Controls.Add(this.lbl_IdAplicacion);
            this.Name = "FrmDetalleAplicacion";
            this.Text = "FrmDetalleAplicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lEdicion;
        private System.Windows.Forms.TextBox txtTituloAplicacion;
        private System.Windows.Forms.TextBox txtIdAplicacion;
        private System.Windows.Forms.RichTextBox panelDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTituloAplicacion;
        private System.Windows.Forms.Label lbl_IdAplicacion;
    }
}
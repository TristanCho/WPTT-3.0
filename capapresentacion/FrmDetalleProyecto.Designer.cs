﻿
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mensajetool = new System.Windows.Forms.ToolTip(this.components);
            this.iconoerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtFechaProyecto = new System.Windows.Forms.DateTimePicker();
            this.lEdicion = new System.Windows.Forms.Label();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.txtcodigoProyecto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.lblPaginas = new System.Windows.Forms.Label();
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
            this.txtObservacionesProyecto.Size = new System.Drawing.Size(725, 235);
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
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(12, 459);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(581, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(93, 459);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(662, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.dtFechaProyecto.Size = new System.Drawing.Size(101, 20);
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
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProyecto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(705, 69);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarProyecto.TabIndex = 28;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
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
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Location = new System.Drawing.Point(386, 459);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(45, 23);
            this.btnSiguiente.TabIndex = 31;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.Location = new System.Drawing.Point(303, 459);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(40, 23);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinal.Location = new System.Drawing.Point(437, 459);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(45, 23);
            this.btnFinal.TabIndex = 33;
            this.btnFinal.Text = ">>";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrimero.Location = new System.Drawing.Point(249, 459);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(40, 23);
            this.btnPrimero.TabIndex = 34;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(686, 12);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(35, 13);
            this.lblPaginas.TabIndex = 36;
            this.lblPaginas.Text = "label2";
            // 
            // FrmDetalleProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(749, 494);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodigoProyecto);
            this.Controls.Add(this.lEdicion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtFechaProyecto);
            this.Controls.Add(this.txtTituloProyecto);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.txtObservacionesProyecto);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloProyecto);
            this.Controls.Add(this.lbl_idproyecto);
            this.Controls.Add(this.btnEliminarProyecto);
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip mensajetool;
        private System.Windows.Forms.ErrorProvider iconoerror;
        private System.Windows.Forms.DateTimePicker dtFechaProyecto;
        private System.Windows.Forms.Label lEdicion;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigoProyecto;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblPaginas;
    }
}
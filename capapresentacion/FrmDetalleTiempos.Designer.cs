
namespace capapresentacion
{
    partial class FrmDetalleTiempos
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
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.lblDescripciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconoerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.mensajetool = new System.Windows.Forms.ToolTip(this.components);
            this.comboboxTarea = new System.Windows.Forms.ComboBox();
            this.lEdicion = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodTarea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkImputable = new System.Windows.Forms.CheckBox();
            this.checkImputado = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboboxAccion = new System.Windows.Forms.ComboBox();
            this.comboboxTareaPersonal = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaInicio.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaInicio.Location = new System.Drawing.Point(346, 83);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(146, 20);
            this.dtFechaInicio.TabIndex = 38;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(9, 236);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(760, 182);
            this.txtObservaciones.TabIndex = 34;
            this.txtObservaciones.Text = "";
            // 
            // lblDescripciones
            // 
            this.lblDescripciones.AutoSize = true;
            this.lblDescripciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripciones.Location = new System.Drawing.Point(9, 204);
            this.lblDescripciones.Name = "lblDescripciones";
            this.lblDescripciones.Size = new System.Drawing.Size(134, 18);
            this.lblDescripciones.TabIndex = 32;
            this.lblDescripciones.Text = "Observaciones:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaFin.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaFin.Location = new System.Drawing.Point(346, 123);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(146, 20);
            this.dtFechaFin.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha Fin:";
            // 
            // txtIdTiempo
            // 
            this.txtIdTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdTiempo.Location = new System.Drawing.Point(623, 118);
            this.txtIdTiempo.Name = "txtIdTiempo";
            this.txtIdTiempo.Size = new System.Drawing.Size(146, 20);
            this.txtIdTiempo.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tiempo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconoerror
            // 
            this.iconoerror.ContainerControl = this;
            // 
            // comboboxTarea
            // 
            this.comboboxTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTarea.Enabled = false;
            this.comboboxTarea.FormattingEnabled = true;
            this.comboboxTarea.Items.AddRange(new object[] {
            ""});
            this.comboboxTarea.Location = new System.Drawing.Point(103, 84);
            this.comboboxTarea.Name = "comboboxTarea";
            this.comboboxTarea.Size = new System.Drawing.Size(117, 21);
            this.comboboxTarea.TabIndex = 55;
            this.comboboxTarea.SelectedIndexChanged += new System.EventHandler(this.comboboxTarea_SelectedIndexChanged);
            // 
            // lEdicion
            // 
            this.lEdicion.AutoSize = true;
            this.lEdicion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEdicion.Location = new System.Drawing.Point(24, 9);
            this.lEdicion.Name = "lEdicion";
            this.lEdicion.Size = new System.Drawing.Size(101, 14);
            this.lEdicion.TabIndex = 57;
            this.lEdicion.Text = "[MODO LECTURA]";
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(346, 39);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(146, 20);
            this.dtFecha.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Id Tarea:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodTarea
            // 
            this.txtCodTarea.Location = new System.Drawing.Point(103, 125);
            this.txtCodTarea.Name = "txtCodTarea";
            this.txtCodTarea.Size = new System.Drawing.Size(117, 20);
            this.txtCodTarea.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Cod Tarea:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkImputable
            // 
            this.checkImputable.AutoSize = true;
            this.checkImputable.Location = new System.Drawing.Point(355, 167);
            this.checkImputable.Name = "checkImputable";
            this.checkImputable.Size = new System.Drawing.Size(72, 17);
            this.checkImputable.TabIndex = 67;
            this.checkImputable.Text = "Imputable";
            this.checkImputable.UseVisualStyleBackColor = true;
            // 
            // checkImputado
            // 
            this.checkImputado.AutoSize = true;
            this.checkImputado.Location = new System.Drawing.Point(431, 167);
            this.checkImputado.Name = "checkImputado";
            this.checkImputado.Size = new System.Drawing.Size(70, 17);
            this.checkImputado.TabIndex = 68;
            this.checkImputado.Text = "Imputado";
            this.checkImputado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 69;
            this.label9.Text = "Accion:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 71;
            this.label8.Text = "Tarea personal:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboboxAccion
            // 
            this.comboboxAccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxAccion.FormattingEnabled = true;
            this.comboboxAccion.Location = new System.Drawing.Point(623, 77);
            this.comboboxAccion.Name = "comboboxAccion";
            this.comboboxAccion.Size = new System.Drawing.Size(146, 21);
            this.comboboxAccion.TabIndex = 74;
            // 
            // comboboxTareaPersonal
            // 
            this.comboboxTareaPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxTareaPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTareaPersonal.Enabled = false;
            this.comboboxTareaPersonal.FormattingEnabled = true;
            this.comboboxTareaPersonal.Location = new System.Drawing.Point(623, 42);
            this.comboboxTareaPersonal.Name = "comboboxTareaPersonal";
            this.comboboxTareaPersonal.Size = new System.Drawing.Size(146, 21);
            this.comboboxTareaPersonal.TabIndex = 75;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(117, 20);
            this.txtId.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "Id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmDetalleTiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(781, 494);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxTareaPersonal);
            this.Controls.Add(this.comboboxAccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkImputado);
            this.Controls.Add(this.checkImputable);
            this.Controls.Add(this.txtCodTarea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lEdicion);
            this.Controls.Add(this.comboboxTarea);
            this.Controls.Add(this.txtIdTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblDescripciones);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleTiempos";
            this.Text = "FrmDetalleTiempos";
            this.Load += new System.EventHandler(this.FrmDetalleTiempos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.iconoerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Label lblDescripciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider iconoerror;
        private System.Windows.Forms.ToolTip mensajetool;
        private System.Windows.Forms.ComboBox comboboxTarea;
        private System.Windows.Forms.Label lEdicion;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkImputado;
        private System.Windows.Forms.CheckBox checkImputable;
        private System.Windows.Forms.TextBox txtCodTarea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboboxAccion;
        private System.Windows.Forms.ComboBox comboboxTareaPersonal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}
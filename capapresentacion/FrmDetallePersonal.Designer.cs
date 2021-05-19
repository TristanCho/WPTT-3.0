
namespace capapresentacion
{
    partial class FrmDetallePersonal
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
            this.label3 = new System.Windows.Forms.Label();
            this.lEdicion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtcreacion = new System.Windows.Forms.DateTimePicker();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_idPersonal = new System.Windows.Forms.Label();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.cbProyecto = new System.Windows.Forms.ComboBox();
            this.cbTareaProyecto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacionesTiempos = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTareaDestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtCierre = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTareaOrigen = new System.Windows.Forms.TextBox();
            this.txtTareaGrupo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEmpleadoAsign = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEmpleadoReAsign = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.lblEstadoTituloTarea = new System.Windows.Forms.Label();
            this.btnIrGrupo = new FontAwesome.Sharp.IconButton();
            this.btnIrDestino = new FontAwesome.Sharp.IconButton();
            this.btnIrOrigen = new FontAwesome.Sharp.IconButton();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Proyecto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lEdicion
            // 
            this.lEdicion.AutoSize = true;
            this.lEdicion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEdicion.Location = new System.Drawing.Point(29, 9);
            this.lEdicion.Name = "lEdicion";
            this.lEdicion.Size = new System.Drawing.Size(101, 14);
            this.lEdicion.TabIndex = 43;
            this.lEdicion.Text = "[MODO LECTURA]";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(848, 572);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 26);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(113, 572);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 26);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(648, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 26);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(32, 460);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 26);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dtcreacion
            // 
            this.dtcreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtcreacion.Location = new System.Drawing.Point(92, 137);
            this.dtcreacion.Name = "dtcreacion";
            this.dtcreacion.Size = new System.Drawing.Size(98, 20);
            this.dtcreacion.TabIndex = 38;
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersonal.Location = new System.Drawing.Point(36, 35);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(49, 21);
            this.txtIdPersonal.TabIndex = 36;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 228);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(726, 103);
            this.txtDescripcion.TabIndex = 35;
            this.txtDescripcion.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(9, 207);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(108, 18);
            this.lblObservaciones.TabIndex = 34;
            this.lblObservaciones.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Creación:";
            // 
            // lbl_idPersonal
            // 
            this.lbl_idPersonal.AutoSize = true;
            this.lbl_idPersonal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idPersonal.Location = new System.Drawing.Point(9, 38);
            this.lbl_idPersonal.Name = "lbl_idPersonal";
            this.lbl_idPersonal.Size = new System.Drawing.Size(32, 18);
            this.lbl_idPersonal.TabIndex = 31;
            this.lbl_idPersonal.Text = "Id:";
            this.lbl_idPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnEliminarProyecto.Location = new System.Drawing.Point(-222, 207);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(32, 26);
            this.btnEliminarProyecto.TabIndex = 44;
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // cbProyecto
            // 
            this.cbProyecto.FormattingEnabled = true;
            this.cbProyecto.Location = new System.Drawing.Point(369, 35);
            this.cbProyecto.Name = "cbProyecto";
            this.cbProyecto.Size = new System.Drawing.Size(121, 21);
            this.cbProyecto.TabIndex = 47;
            // 
            // cbTareaProyecto
            // 
            this.cbTareaProyecto.FormattingEnabled = true;
            this.cbTareaProyecto.Location = new System.Drawing.Point(107, 170);
            this.cbTareaProyecto.Name = "cbTareaProyecto";
            this.cbTareaProyecto.Size = new System.Drawing.Size(121, 21);
            this.cbTareaProyecto.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tarea/Proy:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObservacionesTiempos
            // 
            this.txtObservacionesTiempos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacionesTiempos.Enabled = false;
            this.txtObservacionesTiempos.Location = new System.Drawing.Point(12, 364);
            this.txtObservacionesTiempos.Name = "txtObservacionesTiempos";
            this.txtObservacionesTiempos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtObservacionesTiempos.Size = new System.Drawing.Size(726, 77);
            this.txtObservacionesTiempos.TabIndex = 51;
            this.txtObservacionesTiempos.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Observaciones Tiempos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tarea Grp:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tarea Org:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTareaDestino
            // 
            this.txtTareaDestino.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTareaDestino.Location = new System.Drawing.Point(508, 67);
            this.txtTareaDestino.Name = "txtTareaDestino";
            this.txtTareaDestino.Size = new System.Drawing.Size(57, 21);
            this.txtTareaDestino.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tarea Dest:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtCierre
            // 
            this.dtCierre.CustomFormat = "";
            this.dtCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCierre.Location = new System.Drawing.Point(263, 136);
            this.dtCierre.Name = "dtCierre";
            this.dtCierre.Size = new System.Drawing.Size(98, 20);
            this.dtCierre.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "Cierre:";
            // 
            // txtTareaOrigen
            // 
            this.txtTareaOrigen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTareaOrigen.Location = new System.Drawing.Point(294, 66);
            this.txtTareaOrigen.Name = "txtTareaOrigen";
            this.txtTareaOrigen.Size = new System.Drawing.Size(57, 21);
            this.txtTareaOrigen.TabIndex = 60;
            // 
            // txtTareaGrupo
            // 
            this.txtTareaGrupo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTareaGrupo.Location = new System.Drawing.Point(103, 66);
            this.txtTareaGrupo.Name = "txtTareaGrupo";
            this.txtTareaGrupo.Size = new System.Drawing.Size(57, 21);
            this.txtTareaGrupo.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 62;
            this.label9.Text = "Prioridad:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEmpleadoAsign
            // 
            this.cbEmpleadoAsign.FormattingEnabled = true;
            this.cbEmpleadoAsign.Location = new System.Drawing.Point(112, 98);
            this.cbEmpleadoAsign.Name = "cbEmpleadoAsign";
            this.cbEmpleadoAsign.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleadoAsign.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 64;
            this.label10.Text = "Emp.Asign:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(565, 98);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(499, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 66;
            this.label11.Text = "Estado:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEmpleadoReAsign
            // 
            this.cbEmpleadoReAsign.FormattingEnabled = true;
            this.cbEmpleadoReAsign.Location = new System.Drawing.Point(369, 98);
            this.cbEmpleadoReAsign.Name = "cbEmpleadoReAsign";
            this.cbEmpleadoReAsign.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleadoReAsign.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 18);
            this.label12.TabIndex = 68;
            this.label12.Text = "Emp.Reasign:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacion.Location = new System.Drawing.Point(496, 37);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(90, 18);
            this.lblAplicacion.TabIndex = 70;
            this.lblAplicacion.Text = "Aplicación";
            this.lblAplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEstadoTituloTarea
            // 
            this.lblEstadoTituloTarea.AutoSize = true;
            this.lblEstadoTituloTarea.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTituloTarea.Location = new System.Drawing.Point(234, 173);
            this.lblEstadoTituloTarea.Name = "lblEstadoTituloTarea";
            this.lblEstadoTituloTarea.Size = new System.Drawing.Size(136, 18);
            this.lblEstadoTituloTarea.TabIndex = 71;
            this.lblEstadoTituloTarea.Text = "Estado + Titulo";
            this.lblEstadoTituloTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIrGrupo
            // 
            this.btnIrGrupo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrGrupo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIrGrupo.IconColor = System.Drawing.Color.Black;
            this.btnIrGrupo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIrGrupo.Location = new System.Drawing.Point(166, 65);
            this.btnIrGrupo.Name = "btnIrGrupo";
            this.btnIrGrupo.Size = new System.Drawing.Size(29, 29);
            this.btnIrGrupo.TabIndex = 73;
            this.btnIrGrupo.Text = "ir";
            this.btnIrGrupo.UseVisualStyleBackColor = true;
            // 
            // btnIrDestino
            // 
            this.btnIrDestino.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrDestino.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIrDestino.IconColor = System.Drawing.Color.Black;
            this.btnIrDestino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIrDestino.Location = new System.Drawing.Point(571, 65);
            this.btnIrDestino.Name = "btnIrDestino";
            this.btnIrDestino.Size = new System.Drawing.Size(29, 29);
            this.btnIrDestino.TabIndex = 74;
            this.btnIrDestino.Text = "ir";
            this.btnIrDestino.UseVisualStyleBackColor = true;
            // 
            // btnIrOrigen
            // 
            this.btnIrOrigen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrOrigen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIrOrigen.IconColor = System.Drawing.Color.Black;
            this.btnIrOrigen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIrOrigen.Location = new System.Drawing.Point(357, 64);
            this.btnIrOrigen.Name = "btnIrOrigen";
            this.btnIrOrigen.Size = new System.Drawing.Size(29, 29);
            this.btnIrOrigen.TabIndex = 75;
            this.btnIrOrigen.Text = "ir";
            this.btnIrOrigen.UseVisualStyleBackColor = true;
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.FormattingEnabled = true;
            this.cbPrioridad.Location = new System.Drawing.Point(196, 34);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(77, 21);
            this.cbPrioridad.TabIndex = 76;
            // 
            // FrmDetallePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 498);
            this.Controls.Add(this.cbPrioridad);
            this.Controls.Add(this.btnIrOrigen);
            this.Controls.Add(this.btnIrDestino);
            this.Controls.Add(this.btnIrGrupo);
            this.Controls.Add(this.lblEstadoTituloTarea);
            this.Controls.Add(this.lblAplicacion);
            this.Controls.Add(this.cbEmpleadoReAsign);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbEmpleadoAsign);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTareaGrupo);
            this.Controls.Add(this.txtTareaOrigen);
            this.Controls.Add(this.dtCierre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTareaDestino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObservacionesTiempos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTareaProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lEdicion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtcreacion);
            this.Controls.Add(this.txtIdPersonal);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_idPersonal);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Name = "FrmDetallePersonal";
            this.Text = "FrmDetallePersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lEdicion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtcreacion;
        private System.Windows.Forms.TextBox txtIdPersonal;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_idPersonal;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.ComboBox cbProyecto;
        private System.Windows.Forms.ComboBox cbTareaProyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtObservacionesTiempos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTareaDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtCierre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTareaOrigen;
        private System.Windows.Forms.TextBox txtTareaGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEmpleadoAsign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbEmpleadoReAsign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.Label lblEstadoTituloTarea;
        private FontAwesome.Sharp.IconButton btnIrGrupo;
        private FontAwesome.Sharp.IconButton btnIrDestino;
        private FontAwesome.Sharp.IconButton btnIrOrigen;
        private System.Windows.Forms.ComboBox cbPrioridad;
    }
}
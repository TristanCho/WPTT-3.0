﻿
namespace capapresentacion
{
    partial class FrmPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.label_añadir = new System.Windows.Forms.Label();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListTareas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscarTarea = new System.Windows.Forms.TextBox();
            this.cboBuscarTareas = new System.Windows.Forms.ComboBox();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(641, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(124, 13);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Número de TPersonales:";
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.White;
            this.btnEliminarTarea.BackgroundImage = global::capapresentacion.Properties.Resources.DeleteButton;
            this.btnEliminarTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarTarea.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarTarea.FlatAppearance.BorderSize = 0;
            this.btnEliminarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarea.Location = new System.Drawing.Point(77, 35);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(32, 28);
            this.btnEliminarTarea.TabIndex = 31;
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(12, 43);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 30;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // label_añadir
            // 
            this.label_añadir.AutoSize = true;
            this.label_añadir.Location = new System.Drawing.Point(123, 43);
            this.label_añadir.Name = "label_añadir";
            this.label_añadir.Size = new System.Drawing.Size(37, 13);
            this.label_añadir.TabIndex = 29;
            this.label_añadir.Text = "Añadir";
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListTareas);
            this.panelRecuadro.Location = new System.Drawing.Point(12, 66);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(776, 200);
            this.panelRecuadro.TabIndex = 28;
            // 
            // dataListTareas
            // 
            this.dataListTareas.AllowUserToAddRows = false;
            this.dataListTareas.AllowUserToDeleteRows = false;
            this.dataListTareas.AllowUserToOrderColumns = true;
            this.dataListTareas.AllowUserToResizeRows = false;
            this.dataListTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListTareas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataListTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListTareas.ColumnHeadersHeight = 34;
            this.dataListTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListTareas.EnableHeadersVisualStyles = false;
            this.dataListTareas.GridColor = System.Drawing.Color.DimGray;
            this.dataListTareas.Location = new System.Drawing.Point(0, 0);
            this.dataListTareas.Name = "dataListTareas";
            this.dataListTareas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataListTareas.RowHeadersVisible = false;
            this.dataListTareas.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataListTareas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataListTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListTareas.Size = new System.Drawing.Size(776, 200);
            this.dataListTareas.TabIndex = 4;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 2;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::capapresentacion.Properties.Resources.addNew;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(163, 35);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(26, 28);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTarea
            // 
            this.txtBuscarTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarTarea.Location = new System.Drawing.Point(213, 13);
            this.txtBuscarTarea.Name = "txtBuscarTarea";
            this.txtBuscarTarea.Size = new System.Drawing.Size(575, 20);
            this.txtBuscarTarea.TabIndex = 26;
            // 
            // cboBuscarTareas
            // 
            this.cboBuscarTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarTareas.FormattingEnabled = true;
            this.cboBuscarTareas.Items.AddRange(new object[] {
            "Tarea",
            "Descripción",
            "Aplicación",
            "Proyecto",
            "Prioridad",
            "Estados"});
            this.cboBuscarTareas.Location = new System.Drawing.Point(12, 12);
            this.cboBuscarTareas.Name = "cboBuscarTareas";
            this.cboBuscarTareas.Size = new System.Drawing.Size(195, 21);
            this.cboBuscarTareas.TabIndex = 25;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.label_añadir);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscarTarea);
            this.Controls.Add(this.cboBuscarTareas);
            this.Name = "Personal";
            this.Text = "Personal";
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Label label_añadir;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListTareas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscarTarea;
        private System.Windows.Forms.ComboBox cboBuscarTareas;
    }
}
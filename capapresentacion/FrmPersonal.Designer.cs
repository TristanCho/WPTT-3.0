
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.label_añadir = new System.Windows.Forms.Label();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListPersonal = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscarPersonal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataPersonalTiempos = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListPersonal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonalTiempos)).BeginInit();
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
            this.panelRecuadro.Controls.Add(this.dataListPersonal);
            this.panelRecuadro.Location = new System.Drawing.Point(12, 66);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(776, 200);
            this.panelRecuadro.TabIndex = 28;
            // 
            // dataListPersonal
            // 
            this.dataListPersonal.AllowUserToAddRows = false;
            this.dataListPersonal.AllowUserToDeleteRows = false;
            this.dataListPersonal.AllowUserToOrderColumns = true;
            this.dataListPersonal.AllowUserToResizeRows = false;
            this.dataListPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListPersonal.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataListPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataListPersonal.ColumnHeadersHeight = 34;
            this.dataListPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListPersonal.EnableHeadersVisualStyles = false;
            this.dataListPersonal.GridColor = System.Drawing.Color.DimGray;
            this.dataListPersonal.Location = new System.Drawing.Point(0, 0);
            this.dataListPersonal.Name = "dataListPersonal";
            this.dataListPersonal.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataListPersonal.RowHeadersVisible = false;
            this.dataListPersonal.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataListPersonal.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataListPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListPersonal.Size = new System.Drawing.Size(776, 200);
            this.dataListPersonal.TabIndex = 4;
            this.dataListPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListPersonales_CellContentClick);
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
            // txtBuscarPersonal
            // 
            this.txtBuscarPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPersonal.Location = new System.Drawing.Point(12, 13);
            this.txtBuscarPersonal.Name = "txtBuscarPersonal";
            this.txtBuscarPersonal.Size = new System.Drawing.Size(776, 20);
            this.txtBuscarPersonal.TabIndex = 26;
            this.txtBuscarPersonal.TextChanged += new System.EventHandler(this.txtBuscarPersonal_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.dataPersonalTiempos);
            this.panel1.Location = new System.Drawing.Point(13, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 166);
            this.panel1.TabIndex = 33;
            // 
            // dataPersonalTiempos
            // 
            this.dataPersonalTiempos.AllowUserToAddRows = false;
            this.dataPersonalTiempos.AllowUserToDeleteRows = false;
            this.dataPersonalTiempos.AllowUserToOrderColumns = true;
            this.dataPersonalTiempos.AllowUserToResizeRows = false;
            this.dataPersonalTiempos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPersonalTiempos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataPersonalTiempos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPersonalTiempos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataPersonalTiempos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPersonalTiempos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataPersonalTiempos.ColumnHeadersHeight = 34;
            this.dataPersonalTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPersonalTiempos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataPersonalTiempos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPersonalTiempos.EnableHeadersVisualStyles = false;
            this.dataPersonalTiempos.GridColor = System.Drawing.Color.DimGray;
            this.dataPersonalTiempos.Location = new System.Drawing.Point(0, 0);
            this.dataPersonalTiempos.Name = "dataPersonalTiempos";
            this.dataPersonalTiempos.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPersonalTiempos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataPersonalTiempos.RowHeadersVisible = false;
            this.dataPersonalTiempos.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataPersonalTiempos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataPersonalTiempos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPersonalTiempos.Size = new System.Drawing.Size(775, 166);
            this.dataPersonalTiempos.TabIndex = 5;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 2;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.label_añadir);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscarPersonal);
            this.Name = "FrmPersonal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListPersonal)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonalTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Label label_añadir;
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListPersonal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscarPersonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataPersonalTiempos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
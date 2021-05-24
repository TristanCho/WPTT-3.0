
namespace capapresentacion
{
    partial class FrmTiempos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListTiempos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarTiempo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListTiempos);
            this.panelRecuadro.Location = new System.Drawing.Point(12, 65);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(772, 440);
            this.panelRecuadro.TabIndex = 26;
            // 
            // dataListTiempos
            // 
            this.dataListTiempos.AllowUserToAddRows = false;
            this.dataListTiempos.AllowUserToDeleteRows = false;
            this.dataListTiempos.AllowUserToOrderColumns = true;
            this.dataListTiempos.AllowUserToResizeRows = false;
            this.dataListTiempos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListTiempos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataListTiempos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListTiempos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListTiempos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListTiempos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListTiempos.ColumnHeadersHeight = 34;
            this.dataListTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListTiempos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListTiempos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListTiempos.EnableHeadersVisualStyles = false;
            this.dataListTiempos.GridColor = System.Drawing.Color.DimGray;
            this.dataListTiempos.Location = new System.Drawing.Point(0, 0);
            this.dataListTiempos.Name = "dataListTiempos";
            this.dataListTiempos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListTiempos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListTiempos.RowHeadersVisible = false;
            this.dataListTiempos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataListTiempos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataListTiempos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListTiempos.Size = new System.Drawing.Size(772, 440);
            this.dataListTiempos.TabIndex = 4;
            this.dataListTiempos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListTiempos_CellContentClick);
            this.dataListTiempos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListTiempos_CellDoubleClick);
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
            // txtBuscarTiempo
            // 
            this.txtBuscarTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarTiempo.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarTiempo.Name = "txtBuscarTiempo";
            this.txtBuscarTiempo.Size = new System.Drawing.Size(772, 20);
            this.txtBuscarTiempo.TabIndex = 57;
            this.txtBuscarTiempo.TextChanged += new System.EventHandler(this.txtBuscarTiempo_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(641, 43);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 13);
            this.lblTotal.TabIndex = 58;
            this.lblTotal.Text = "Número de registros:";
            // 
            // FrmTiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(796, 517);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscarTiempo);
            this.Controls.Add(this.panelRecuadro);
            this.Name = "FrmTiempos";
            this.Text = "FrmTiempos";
            this.Load += new System.EventHandler(this.FrmTiempos_Load);
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListTiempos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox txtBuscarTiempo;
        private System.Windows.Forms.Label lblTotal;
    }
}

namespace capapresentacion
{
    partial class FrmAplicaciones
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
            this.panelRecuadro = new System.Windows.Forms.Panel();
            this.dataListAplicaciones = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscarProyecto = new System.Windows.Forms.TextBox();
            this.panelRecuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListAplicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRecuadro
            // 
            this.panelRecuadro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecuadro.BackColor = System.Drawing.Color.Gold;
            this.panelRecuadro.Controls.Add(this.dataListAplicaciones);
            this.panelRecuadro.Location = new System.Drawing.Point(12, 65);
            this.panelRecuadro.Name = "panelRecuadro";
            this.panelRecuadro.Size = new System.Drawing.Size(775, 411);
            this.panelRecuadro.TabIndex = 23;
            // 
            // dataListAplicaciones
            // 
            this.dataListAplicaciones.AllowUserToAddRows = false;
            this.dataListAplicaciones.AllowUserToDeleteRows = false;
            this.dataListAplicaciones.AllowUserToOrderColumns = true;
            this.dataListAplicaciones.AllowUserToResizeRows = false;
            this.dataListAplicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListAplicaciones.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataListAplicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListAplicaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataListAplicaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListAplicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListAplicaciones.ColumnHeadersHeight = 34;
            this.dataListAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListAplicaciones.EnableHeadersVisualStyles = false;
            this.dataListAplicaciones.GridColor = System.Drawing.Color.DimGray;
            this.dataListAplicaciones.Location = new System.Drawing.Point(0, 0);
            this.dataListAplicaciones.Name = "dataListAplicaciones";
            this.dataListAplicaciones.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListAplicaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataListAplicaciones.RowHeadersVisible = false;
            this.dataListAplicaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataListAplicaciones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataListAplicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListAplicaciones.Size = new System.Drawing.Size(775, 411);
            this.dataListAplicaciones.TabIndex = 4;
            this.dataListAplicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListAplicaciones_CellContentClick);
            this.dataListAplicaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListAplicaciones_CellDoubleClick);
            this.dataListAplicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListAplicaciones_CellDoubleClick_1);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(641, 43);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 13);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Número de Aplicaciones:";
            // 
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProyecto.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(775, 20);
            this.txtBuscarProyecto.TabIndex = 21;
            // 
            // FrmAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(799, 488);
            this.Controls.Add(this.panelRecuadro);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscarProyecto);
            this.Name = "FrmAplicaciones";
            this.Text = "FrmAplicaciones";
            this.panelRecuadro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListAplicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRecuadro;
        private System.Windows.Forms.DataGridView dataListAplicaciones;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscarProyecto;
    }
}
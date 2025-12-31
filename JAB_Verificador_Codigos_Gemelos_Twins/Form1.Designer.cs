namespace JAB_Verificador_Codigos_Gemelos_Twins
{
    partial class frmGemelosPorFecha
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCodbars = new System.Windows.Forms.DataGridView();
            this.btnGetList = new System.Windows.Forms.Button();
            this.btnFindRepeated = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodbars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCodbars
            // 
            this.dgvCodbars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodbars.Location = new System.Drawing.Point(12, 12);
            this.dgvCodbars.Name = "dgvCodbars";
            this.dgvCodbars.Size = new System.Drawing.Size(1097, 365);
            this.dgvCodbars.TabIndex = 0;
            this.dgvCodbars.DataSourceChanged += new System.EventHandler(this.dgvCodbars_DataSourceChanged);
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(361, 384);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(133, 32);
            this.btnGetList.TabIndex = 1;
            this.btnGetList.Text = "Obtener Codigos";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // btnFindRepeated
            // 
            this.btnFindRepeated.Location = new System.Drawing.Point(500, 384);
            this.btnFindRepeated.Name = "btnFindRepeated";
            this.btnFindRepeated.Size = new System.Drawing.Size(133, 32);
            this.btnFindRepeated.TabIndex = 2;
            this.btnFindRepeated.Text = "Buscar Duplicados";
            this.btnFindRepeated.UseVisualStyleBackColor = true;
            this.btnFindRepeated.Click += new System.EventHandler(this.btnFindRepeated_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(53, 384);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 388);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // frmGemelosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 427);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnFindRepeated);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.dgvCodbars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGemelosPorFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Gemelos por Fecha";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodbars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCodbars;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.Button btnFindRepeated;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}


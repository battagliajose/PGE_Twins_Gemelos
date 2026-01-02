namespace JAB_Verificador_Codigos_Gemelos_Twins
{
    partial class frmGemelosPorLista
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
            this.btnGetSand = new System.Windows.Forms.Button();
            this.txtGetSand = new System.Windows.Forms.TextBox();
            this.btnCargarTXT = new System.Windows.Forms.Button();
            this.dgvCodbars = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodbars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetSand
            // 
            this.btnGetSand.Location = new System.Drawing.Point(249, 406);
            this.btnGetSand.Name = "btnGetSand";
            this.btnGetSand.Size = new System.Drawing.Size(96, 32);
            this.btnGetSand.TabIndex = 8;
            this.btnGetSand.Text = "Buscar Codigo";
            this.btnGetSand.UseVisualStyleBackColor = true;
            this.btnGetSand.Click += new System.EventHandler(this.btnGetSand_Click);
            // 
            // txtGetSand
            // 
            this.txtGetSand.Location = new System.Drawing.Point(86, 413);
            this.txtGetSand.Name = "txtGetSand";
            this.txtGetSand.Size = new System.Drawing.Size(157, 20);
            this.txtGetSand.TabIndex = 7;
            // 
            // btnCargarTXT
            // 
            this.btnCargarTXT.Location = new System.Drawing.Point(524, 406);
            this.btnCargarTXT.Name = "btnCargarTXT";
            this.btnCargarTXT.Size = new System.Drawing.Size(116, 32);
            this.btnCargarTXT.TabIndex = 9;
            this.btnCargarTXT.Text = "Cargar TXT";
            this.btnCargarTXT.UseVisualStyleBackColor = true;
            this.btnCargarTXT.Click += new System.EventHandler(this.btnCargarTXT_Click);
            // 
            // dgvCodbars
            // 
            this.dgvCodbars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodbars.Location = new System.Drawing.Point(13, 13);
            this.dgvCodbars.Name = "dgvCodbars";
            this.dgvCodbars.Size = new System.Drawing.Size(775, 370);
            this.dgvCodbars.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar Codigos TXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(672, 368);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(116, 32);
            this.btnExportCSV.TabIndex = 12;
            this.btnExportCSV.Text = "Exportar a CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // frmGemelosPorLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCodbars);
            this.Controls.Add(this.btnCargarTXT);
            this.Controls.Add(this.btnGetSand);
            this.Controls.Add(this.txtGetSand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGemelosPorLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Gemelos por lista de Codbars";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodbars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSand;
        private System.Windows.Forms.TextBox txtGetSand;
        private System.Windows.Forms.Button btnCargarTXT;
        private System.Windows.Forms.DataGridView dgvCodbars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExportCSV;
    }
}
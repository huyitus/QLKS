namespace QLKS.GUI
{
    partial class FormLT_Service
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
            this.dataDV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDV
            // 
            this.dataDV.BackgroundColor = System.Drawing.Color.White;
            this.dataDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDV.Location = new System.Drawing.Point(61, 76);
            this.dataDV.Name = "dataDV";
            this.dataDV.ReadOnly = true;
            this.dataDV.RowHeadersVisible = false;
            this.dataDV.RowHeadersWidth = 51;
            this.dataDV.RowTemplate.Height = 24;
            this.dataDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDV.Size = new System.Drawing.Size(486, 213);
            this.dataDV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // FormLT_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDV);
            this.Name = "FormLT_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLT_Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLT_Service_FormClosed);
            this.Load += new System.EventHandler(this.FormLT_Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDV;
        private System.Windows.Forms.Label label1;
    }
}
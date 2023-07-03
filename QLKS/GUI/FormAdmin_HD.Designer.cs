namespace QLKS.GUI
{
    partial class FormAdmin_HD
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
            this.panellabel = new System.Windows.Forms.Panel();
            this.lab_HD = new System.Windows.Forms.Label();
            this.dgv_hd = new System.Windows.Forms.DataGridView();
            this.panellabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).BeginInit();
            this.SuspendLayout();
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Controls.Add(this.lab_HD);
            this.panellabel.Location = new System.Drawing.Point(3, 1);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 67);
            this.panellabel.TabIndex = 22;
            // 
            // lab_HD
            // 
            this.lab_HD.AutoSize = true;
            this.lab_HD.BackColor = System.Drawing.Color.DarkCyan;
            this.lab_HD.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_HD.ForeColor = System.Drawing.Color.White;
            this.lab_HD.Location = new System.Drawing.Point(322, 18);
            this.lab_HD.Name = "lab_HD";
            this.lab_HD.Size = new System.Drawing.Size(145, 32);
            this.lab_HD.TabIndex = 1;
            this.lab_HD.Text = "HÓA ĐƠN";
            // 
            // dgv_hd
            // 
            this.dgv_hd.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hd.Location = new System.Drawing.Point(23, 88);
            this.dgv_hd.Name = "dgv_hd";
            this.dgv_hd.ReadOnly = true;
            this.dgv_hd.RowHeadersVisible = false;
            this.dgv_hd.RowHeadersWidth = 62;
            this.dgv_hd.RowTemplate.Height = 28;
            this.dgv_hd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hd.Size = new System.Drawing.Size(757, 266);
            this.dgv_hd.TabIndex = 23;
            // 
            // FormAdmin_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 384);
            this.Controls.Add(this.dgv_hd);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_HD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FormAdmin_HD_Load);
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Label lab_HD;
        private System.Windows.Forms.DataGridView dgv_hd;
    }
}
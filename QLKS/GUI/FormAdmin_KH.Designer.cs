namespace QLKS.GUI
{
    partial class FormAdmin_KH
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
            this.lb_KH = new System.Windows.Forms.Label();
            this.dvgCus = new System.Windows.Forms.DataGridView();
            this.panellabel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCus)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_KH
            // 
            this.lb_KH.AutoSize = true;
            this.lb_KH.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_KH.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KH.ForeColor = System.Drawing.Color.White;
            this.lb_KH.Location = new System.Drawing.Point(209, 18);
            this.lb_KH.Name = "lb_KH";
            this.lb_KH.Size = new System.Drawing.Size(377, 32);
            this.lb_KH.TabIndex = 0;
            this.lb_KH.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // dvgCus
            // 
            this.dvgCus.BackgroundColor = System.Drawing.Color.White;
            this.dvgCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCus.Location = new System.Drawing.Point(29, 80);
            this.dvgCus.Name = "dvgCus";
            this.dvgCus.ReadOnly = true;
            this.dvgCus.RowHeadersVisible = false;
            this.dvgCus.RowHeadersWidth = 62;
            this.dvgCus.RowTemplate.Height = 28;
            this.dvgCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCus.Size = new System.Drawing.Size(740, 280);
            this.dvgCus.TabIndex = 1;
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Location = new System.Drawing.Point(0, 1);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 67);
            this.panellabel.TabIndex = 17;
            // 
            // FormAdmin_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 384);
            this.Controls.Add(this.dvgCus);
            this.Controls.Add(this.lb_KH);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Khách hàng";
            this.Load += new System.EventHandler(this.FormAdmin_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_KH;
        private System.Windows.Forms.DataGridView dvgCus;
        private System.Windows.Forms.Panel panellabel;
    }
}
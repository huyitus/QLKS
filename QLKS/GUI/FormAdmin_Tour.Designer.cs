namespace QLKS.GUI
{
    partial class FormAdmin_Tour
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
            this.lab_Tour = new System.Windows.Forms.Label();
            this.dtg_Tour = new System.Windows.Forms.DataGridView();
            this.panellabel = new System.Windows.Forms.Panel();
            this.butt_dktour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Tour)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Tour
            // 
            this.lab_Tour.AutoSize = true;
            this.lab_Tour.BackColor = System.Drawing.Color.DarkCyan;
            this.lab_Tour.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Tour.ForeColor = System.Drawing.Color.White;
            this.lab_Tour.Location = new System.Drawing.Point(206, 17);
            this.lab_Tour.Name = "lab_Tour";
            this.lab_Tour.Size = new System.Drawing.Size(382, 32);
            this.lab_Tour.TabIndex = 0;
            this.lab_Tour.Text = "THÔNG TIN TOUR DU LỊCH";
            // 
            // dtg_Tour
            // 
            this.dtg_Tour.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Tour.Location = new System.Drawing.Point(33, 88);
            this.dtg_Tour.Name = "dtg_Tour";
            this.dtg_Tour.ReadOnly = true;
            this.dtg_Tour.RowHeadersVisible = false;
            this.dtg_Tour.RowHeadersWidth = 62;
            this.dtg_Tour.RowTemplate.Height = 28;
            this.dtg_Tour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Tour.Size = new System.Drawing.Size(743, 255);
            this.dtg_Tour.TabIndex = 1;
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Location = new System.Drawing.Point(3, 1);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 67);
            this.panellabel.TabIndex = 19;
            // 
            // butt_dktour
            // 
            this.butt_dktour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butt_dktour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_dktour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_dktour.Location = new System.Drawing.Point(322, 360);
            this.butt_dktour.Name = "butt_dktour";
            this.butt_dktour.Size = new System.Drawing.Size(204, 45);
            this.butt_dktour.TabIndex = 20;
            this.butt_dktour.Text = "ĐĂNG KÝ TOUR";
            this.butt_dktour.UseVisualStyleBackColor = false;
            this.butt_dktour.Click += new System.EventHandler(this.butt_dktour_Click);
            // 
            // FormAdmin_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 417);
            this.Controls.Add(this.butt_dktour);
            this.Controls.Add(this.dtg_Tour);
            this.Controls.Add(this.lab_Tour);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_Tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin Tour";
            this.Load += new System.EventHandler(this.FormAdmin_Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Tour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Tour;
        private System.Windows.Forms.DataGridView dtg_Tour;
        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Button butt_dktour;
    }
}
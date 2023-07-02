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
            this.dtg_Tour.RowHeadersWidth = 62;
            this.dtg_Tour.RowTemplate.Height = 28;
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
            // FormAdmin_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 384);
            this.Controls.Add(this.dtg_Tour);
            this.Controls.Add(this.lab_Tour);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_Tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin_Tour";
            this.Load += new System.EventHandler(this.FormAdmin_Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Tour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Tour;
        private System.Windows.Forms.DataGridView dtg_Tour;
        private System.Windows.Forms.Panel panellabel;
    }
}

namespace QLKS.GUI
{
    partial class FormDevideRoom
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
            this.label_MADP = new System.Windows.Forms.Label();
            this.labelMaPhong = new System.Windows.Forms.Label();
            this.tbMaDP = new System.Windows.Forms.TextBox();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.btnPhanPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MADP
            // 
            this.label_MADP.AutoSize = true;
            this.label_MADP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MADP.Location = new System.Drawing.Point(60, 47);
            this.label_MADP.Name = "label_MADP";
            this.label_MADP.Size = new System.Drawing.Size(110, 20);
            this.label_MADP.TabIndex = 0;
            this.label_MADP.Text = "Mã đặt phòng";
            // 
            // labelMaPhong
            // 
            this.labelMaPhong.AutoSize = true;
            this.labelMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaPhong.Location = new System.Drawing.Point(60, 100);
            this.labelMaPhong.Name = "labelMaPhong";
            this.labelMaPhong.Size = new System.Drawing.Size(82, 20);
            this.labelMaPhong.TabIndex = 1;
            this.labelMaPhong.Text = "Mã phòng";
            // 
            // tbMaDP
            // 
            this.tbMaDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaDP.Location = new System.Drawing.Point(195, 47);
            this.tbMaDP.Name = "tbMaDP";
            this.tbMaDP.Size = new System.Drawing.Size(165, 27);
            this.tbMaDP.TabIndex = 2;
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaPhong.Location = new System.Drawing.Point(195, 100);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(165, 27);
            this.tbMaPhong.TabIndex = 3;
            // 
            // btnPhanPhong
            // 
            this.btnPhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanPhong.Location = new System.Drawing.Point(130, 157);
            this.btnPhanPhong.Name = "btnPhanPhong";
            this.btnPhanPhong.Size = new System.Drawing.Size(184, 31);
            this.btnPhanPhong.TabIndex = 4;
            this.btnPhanPhong.Text = "Phân phòng";
            this.btnPhanPhong.UseVisualStyleBackColor = true;
            this.btnPhanPhong.Click += new System.EventHandler(this.btnPhanPhong_Click);
            // 
            // FormDevideRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 200);
            this.Controls.Add(this.btnPhanPhong);
            this.Controls.Add(this.tbMaPhong);
            this.Controls.Add(this.tbMaDP);
            this.Controls.Add(this.labelMaPhong);
            this.Controls.Add(this.label_MADP);
            this.Name = "FormDevideRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDevideRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MADP;
        private System.Windows.Forms.Label labelMaPhong;
        private System.Windows.Forms.TextBox tbMaDP;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Button btnPhanPhong;
    }
}
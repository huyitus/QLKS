
namespace QLKS.GUI
{
    partial class FormReceptionist
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
            this.btnTracuuKH = new System.Windows.Forms.Button();
            this.btnTracuuPhong = new System.Windows.Forms.Button();
            this.btnTracuuDV = new System.Windows.Forms.Button();
            this.btnTracuuTourDL = new System.Windows.Forms.Button();
            this.btnQLPhong = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnQuiDinh = new System.Windows.Forms.Button();
            this.btnYCDaiLy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTracuuKH
            // 
            this.btnTracuuKH.Location = new System.Drawing.Point(102, 77);
            this.btnTracuuKH.Name = "btnTracuuKH";
            this.btnTracuuKH.Size = new System.Drawing.Size(154, 40);
            this.btnTracuuKH.TabIndex = 0;
            this.btnTracuuKH.Text = "Tra cứu khách hàng";
            this.btnTracuuKH.UseVisualStyleBackColor = true;
            this.btnTracuuKH.Click += new System.EventHandler(this.btnTracuuKH_Click);
            // 
            // btnTracuuPhong
            // 
            this.btnTracuuPhong.Location = new System.Drawing.Point(102, 164);
            this.btnTracuuPhong.Name = "btnTracuuPhong";
            this.btnTracuuPhong.Size = new System.Drawing.Size(154, 40);
            this.btnTracuuPhong.TabIndex = 1;
            this.btnTracuuPhong.Text = "Tra cứu phòng";
            this.btnTracuuPhong.UseVisualStyleBackColor = true;
            this.btnTracuuPhong.Click += new System.EventHandler(this.btnTracuuPhong_Click);
            // 
            // btnTracuuDV
            // 
            this.btnTracuuDV.Location = new System.Drawing.Point(102, 250);
            this.btnTracuuDV.Name = "btnTracuuDV";
            this.btnTracuuDV.Size = new System.Drawing.Size(154, 40);
            this.btnTracuuDV.TabIndex = 2;
            this.btnTracuuDV.Text = "Tra cứu dịch vụ";
            this.btnTracuuDV.UseVisualStyleBackColor = true;
            this.btnTracuuDV.Click += new System.EventHandler(this.btnTracuuDV_Click);
            // 
            // btnTracuuTourDL
            // 
            this.btnTracuuTourDL.Location = new System.Drawing.Point(102, 336);
            this.btnTracuuTourDL.Name = "btnTracuuTourDL";
            this.btnTracuuTourDL.Size = new System.Drawing.Size(154, 40);
            this.btnTracuuTourDL.TabIndex = 3;
            this.btnTracuuTourDL.Text = "Tra cứu Tour du lịch";
            this.btnTracuuTourDL.UseVisualStyleBackColor = true;
            this.btnTracuuTourDL.Click += new System.EventHandler(this.btnTracuuTourDL_Click);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.Location = new System.Drawing.Point(380, 77);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Size = new System.Drawing.Size(154, 40);
            this.btnQLPhong.TabIndex = 4;
            this.btnQLPhong.Text = "Quản lý phòng";
            this.btnQLPhong.UseVisualStyleBackColor = true;
            this.btnQLPhong.Click += new System.EventHandler(this.btnQLPhong_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(380, 164);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(154, 40);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnQuiDinh
            // 
            this.btnQuiDinh.Location = new System.Drawing.Point(380, 250);
            this.btnQuiDinh.Name = "btnQuiDinh";
            this.btnQuiDinh.Size = new System.Drawing.Size(154, 40);
            this.btnQuiDinh.TabIndex = 6;
            this.btnQuiDinh.Text = "Qui định";
            this.btnQuiDinh.UseVisualStyleBackColor = true;
            this.btnQuiDinh.Click += new System.EventHandler(this.btnQuiDinh_Click);
            // 
            // btnYCDaiLy
            // 
            this.btnYCDaiLy.Location = new System.Drawing.Point(380, 336);
            this.btnYCDaiLy.Name = "btnYCDaiLy";
            this.btnYCDaiLy.Size = new System.Drawing.Size(154, 40);
            this.btnYCDaiLy.TabIndex = 7;
            this.btnYCDaiLy.Text = "Yêu cầu từ đại lý";
            this.btnYCDaiLy.UseVisualStyleBackColor = true;
            this.btnYCDaiLy.Click += new System.EventHandler(this.btnYCDaiLy_Click);
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btnYCDaiLy);
            this.Controls.Add(this.btnQuiDinh);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnQLPhong);
            this.Controls.Add(this.btnTracuuTourDL);
            this.Controls.Add(this.btnTracuuDV);
            this.Controls.Add(this.btnTracuuPhong);
            this.Controls.Add(this.btnTracuuKH);
            this.Name = "FormReceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceptionist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReceptionist_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTracuuKH;
        private System.Windows.Forms.Button btnTracuuPhong;
        private System.Windows.Forms.Button btnTracuuDV;
        private System.Windows.Forms.Button btnTracuuTourDL;
        private System.Windows.Forms.Button btnQLPhong;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnQuiDinh;
        private System.Windows.Forms.Button btnYCDaiLy;
    }
}
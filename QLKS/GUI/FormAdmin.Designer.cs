namespace QLKS.GUI
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.buttQD = new System.Windows.Forms.Button();
            this.buttHD = new System.Windows.Forms.Button();
            this.buttTour = new System.Windows.Forms.Button();
            this.buttDT = new System.Windows.Forms.Button();
            this.buttTTKH = new System.Windows.Forms.Button();
            this.buttQLNV = new System.Windows.Forms.Button();
            this.panellabel = new System.Windows.Forms.Panel();
            this.lb_gdql = new System.Windows.Forms.Label();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.buttDV = new System.Windows.Forms.Button();
            this.panellabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // buttQD
            // 
            this.buttQD.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttQD.Location = new System.Drawing.Point(271, 330);
            this.buttQD.Name = "buttQD";
            this.buttQD.Size = new System.Drawing.Size(207, 96);
            this.buttQD.TabIndex = 14;
            this.buttQD.Text = "QUY ĐỊNH";
            this.buttQD.UseVisualStyleBackColor = false;
            this.buttQD.Click += new System.EventHandler(this.buttQD_Click);
            // 
            // buttHD
            // 
            this.buttHD.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttHD.Location = new System.Drawing.Point(45, 330);
            this.buttHD.Name = "buttHD";
            this.buttHD.Size = new System.Drawing.Size(207, 96);
            this.buttHD.TabIndex = 13;
            this.buttHD.Text = "HÓA ĐƠN";
            this.buttHD.UseVisualStyleBackColor = false;
            this.buttHD.Click += new System.EventHandler(this.buttHD_Click);
            // 
            // buttTour
            // 
            this.buttTour.BackColor = System.Drawing.Color.GhostWhite;
            this.buttTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttTour.Location = new System.Drawing.Point(271, 216);
            this.buttTour.Name = "buttTour";
            this.buttTour.Size = new System.Drawing.Size(207, 96);
            this.buttTour.TabIndex = 12;
            this.buttTour.Text = "THÔNG TIN TOUR";
            this.buttTour.UseVisualStyleBackColor = false;
            this.buttTour.Click += new System.EventHandler(this.buttTour_Click);
            // 
            // buttDT
            // 
            this.buttDT.BackColor = System.Drawing.Color.Lavender;
            this.buttDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDT.Location = new System.Drawing.Point(45, 215);
            this.buttDT.Name = "buttDT";
            this.buttDT.Size = new System.Drawing.Size(207, 97);
            this.buttDT.TabIndex = 11;
            this.buttDT.Text = "ĐỐI TÁC";
            this.buttDT.UseVisualStyleBackColor = false;
            this.buttDT.Click += new System.EventHandler(this.buttDT_Click);
            // 
            // buttTTKH
            // 
            this.buttTTKH.BackColor = System.Drawing.Color.LightCyan;
            this.buttTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttTTKH.Location = new System.Drawing.Point(271, 101);
            this.buttTTKH.Name = "buttTTKH";
            this.buttTTKH.Size = new System.Drawing.Size(207, 97);
            this.buttTTKH.TabIndex = 10;
            this.buttTTKH.Text = "KHÁCH HÀNG";
            this.buttTTKH.UseVisualStyleBackColor = false;
            this.buttTTKH.Click += new System.EventHandler(this.buttTTKH_Click);
            // 
            // buttQLNV
            // 
            this.buttQLNV.BackColor = System.Drawing.Color.Honeydew;
            this.buttQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttQLNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttQLNV.Location = new System.Drawing.Point(45, 101);
            this.buttQLNV.Name = "buttQLNV";
            this.buttQLNV.Size = new System.Drawing.Size(207, 96);
            this.buttQLNV.TabIndex = 9;
            this.buttQLNV.Text = "NHÂN VIÊN\r\n";
            this.buttQLNV.UseVisualStyleBackColor = false;
            this.buttQLNV.Click += new System.EventHandler(this.buttQLNV_Click);
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Controls.Add(this.lb_gdql);
            this.panellabel.Location = new System.Drawing.Point(0, 0);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(522, 70);
            this.panellabel.TabIndex = 16;
            // 
            // lb_gdql
            // 
            this.lb_gdql.AutoSize = true;
            this.lb_gdql.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gdql.ForeColor = System.Drawing.Color.White;
            this.lb_gdql.Location = new System.Drawing.Point(137, 23);
            this.lb_gdql.Name = "lb_gdql";
            this.lb_gdql.Size = new System.Drawing.Size(255, 26);
            this.lb_gdql.TabIndex = 0;
            this.lb_gdql.Text = "GIAO DIỆN QUẢN LÝ";
            // 
            // picNhanVien
            // 
            this.picNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.picNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("picNhanVien.Image")));
            this.picNhanVien.Location = new System.Drawing.Point(428, 523);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(50, 47);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 17;
            this.picNhanVien.TabStop = false;
            this.picNhanVien.Click += new System.EventHandler(this.picNhanVien_Click);
            // 
            // buttDV
            // 
            this.buttDV.Location = new System.Drawing.Point(142, 441);
            this.buttDV.Name = "buttDV";
            this.buttDV.Size = new System.Drawing.Size(207, 96);
            this.buttDV.TabIndex = 18;
            this.buttDV.Text = "DỊCH VỤ";
            this.buttDV.UseVisualStyleBackColor = true;
            this.buttDV.Click += new System.EventHandler(this.buttDV_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 582);
            this.Controls.Add(this.buttDV);
            this.Controls.Add(this.picNhanVien);
            this.Controls.Add(this.buttQD);
            this.Controls.Add(this.buttHD);
            this.Controls.Add(this.buttTour);
            this.Controls.Add(this.buttDT);
            this.Controls.Add(this.buttTTKH);
            this.Controls.Add(this.buttQLNV);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện quản lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttQD;
        private System.Windows.Forms.Button buttHD;
        private System.Windows.Forms.Button buttTour;
        private System.Windows.Forms.Button buttDT;
        private System.Windows.Forms.Button buttTTKH;
        private System.Windows.Forms.Button buttQLNV;
        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.Label lb_gdql;
        private System.Windows.Forms.Button buttDV;
    }
}
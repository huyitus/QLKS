
namespace QLKS.GUI
{
    partial class FormReceptionistViewRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.labelDSDatPhong = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label_TenKH = new System.Windows.Forms.Label();
            this.dGV_DSdatphong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBPhongCDD = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cBPhongTrong = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_DSPhong = new System.Windows.Forms.DataGridView();
            this.btnPhanPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSdatphong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.labelDSDatPhong);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbTenKH);
            this.panel1.Controls.Add(this.label_TenKH);
            this.panel1.Controls.Add(this.dGV_DSdatphong);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 267);
            this.panel1.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(788, 185);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(155, 37);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Xem Toàn bộ";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // labelDSDatPhong
            // 
            this.labelDSDatPhong.AutoSize = true;
            this.labelDSDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSDatPhong.ForeColor = System.Drawing.Color.Green;
            this.labelDSDatPhong.Location = new System.Drawing.Point(12, 16);
            this.labelDSDatPhong.Name = "labelDSDatPhong";
            this.labelDSDatPhong.Size = new System.Drawing.Size(234, 20);
            this.labelDSDatPhong.TabIndex = 4;
            this.labelDSDatPhong.Text = "DANH SÁCH ĐẶT PHÒNG";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(788, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(832, 62);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(193, 27);
            this.tbTenKH.TabIndex = 2;
            // 
            // label_TenKH
            // 
            this.label_TenKH.AutoSize = true;
            this.label_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKH.Location = new System.Drawing.Point(700, 66);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(117, 18);
            this.label_TenKH.TabIndex = 1;
            this.label_TenKH.Text = "Tên khách hàng:";
            // 
            // dGV_DSdatphong
            // 
            this.dGV_DSdatphong.BackgroundColor = System.Drawing.Color.White;
            this.dGV_DSdatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSdatphong.Location = new System.Drawing.Point(3, 39);
            this.dGV_DSdatphong.Name = "dGV_DSdatphong";
            this.dGV_DSdatphong.ReadOnly = true;
            this.dGV_DSdatphong.RowHeadersVisible = false;
            this.dGV_DSdatphong.RowHeadersWidth = 51;
            this.dGV_DSdatphong.RowTemplate.Height = 24;
            this.dGV_DSdatphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_DSdatphong.Size = new System.Drawing.Size(673, 227);
            this.dGV_DSdatphong.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cBPhongCDD);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.cBPhongTrong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dGV_DSPhong);
            this.panel2.Location = new System.Drawing.Point(0, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 261);
            this.panel2.TabIndex = 1;
            // 
            // cBPhongCDD
            // 
            this.cBPhongCDD.AutoSize = true;
            this.cBPhongCDD.Location = new System.Drawing.Point(702, 227);
            this.cBPhongCDD.Name = "cBPhongCDD";
            this.cBPhongCDD.Size = new System.Drawing.Size(182, 21);
            this.cBPhongCDD.TabIndex = 8;
            this.cBPhongCDD.Text = "Phòng đã chưa dọn dẹp";
            this.cBPhongCDD.UseVisualStyleBackColor = true;
            this.cBPhongCDD.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(788, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cBPhongTrong
            // 
            this.cBPhongTrong.AutoSize = true;
            this.cBPhongTrong.Location = new System.Drawing.Point(703, 200);
            this.cBPhongTrong.Name = "cBPhongTrong";
            this.cBPhongTrong.Size = new System.Drawing.Size(108, 21);
            this.cBPhongTrong.TabIndex = 6;
            this.cBPhongTrong.Text = "Phòng trống";
            this.cBPhongTrong.UseVisualStyleBackColor = true;
            this.cBPhongTrong.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // dGV_DSPhong
            // 
            this.dGV_DSPhong.BackgroundColor = System.Drawing.Color.White;
            this.dGV_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DSPhong.Location = new System.Drawing.Point(2, 34);
            this.dGV_DSPhong.Name = "dGV_DSPhong";
            this.dGV_DSPhong.ReadOnly = true;
            this.dGV_DSPhong.RowHeadersVisible = false;
            this.dGV_DSPhong.RowHeadersWidth = 51;
            this.dGV_DSPhong.RowTemplate.Height = 24;
            this.dGV_DSPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_DSPhong.Size = new System.Drawing.Size(674, 226);
            this.dGV_DSPhong.TabIndex = 0;
            // 
            // btnPhanPhong
            // 
            this.btnPhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanPhong.Location = new System.Drawing.Point(321, 545);
            this.btnPhanPhong.Name = "btnPhanPhong";
            this.btnPhanPhong.Size = new System.Drawing.Size(174, 43);
            this.btnPhanPhong.TabIndex = 2;
            this.btnPhanPhong.Text = "Phân Phòng";
            this.btnPhanPhong.UseVisualStyleBackColor = true;
            this.btnPhanPhong.Click += new System.EventHandler(this.btnPhanPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(553, 545);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(174, 43);
            this.btnDatPhong.TabIndex = 3;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // FormReceptionistViewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 600);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnPhanPhong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReceptionistViewRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRoom_FormClosed);
            this.Load += new System.EventHandler(this.FormRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSdatphong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DSPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDSDatPhong;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label_TenKH;
        private System.Windows.Forms.DataGridView dGV_DSdatphong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cBPhongTrong;
        private System.Windows.Forms.Button btnPhanPhong;
        private System.Windows.Forms.DataGridView dGV_DSPhong;
        private System.Windows.Forms.CheckBox cBPhongCDD;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDatPhong;
    }
}
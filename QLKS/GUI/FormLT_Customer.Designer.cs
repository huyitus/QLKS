namespace QLKS.GUI
{
    partial class FormLT_Customer
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
            this.dataKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKH
            // 
            this.dataKH.BackgroundColor = System.Drawing.Color.White;
            this.dataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKH.Location = new System.Drawing.Point(23, 124);
            this.dataKH.Name = "dataKH";
            this.dataKH.ReadOnly = true;
            this.dataKH.RowHeadersVisible = false;
            this.dataKH.RowHeadersWidth = 51;
            this.dataKH.RowTemplate.Height = 24;
            this.dataKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKH.Size = new System.Drawing.Size(753, 295);
            this.dataKH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(580, 73);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(62, 35);
            this.them.TabIndex = 2;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.button1_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(648, 73);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(62, 35);
            this.sua.TabIndex = 3;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(714, 73);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(62, 35);
            this.xoa.TabIndex = 4;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormLT_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataKH);
            this.Name = "FormLT_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLT_Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLT_Customer_Form_Closed);
            this.Load += new System.EventHandler(this.FormLT_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button button1;
    }
}
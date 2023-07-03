namespace QLKS.GUI
{
    partial class FormAdmin_AddDV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.butt_confirm = new System.Windows.Forms.Button();
            this.panellabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Controls.Add(this.label1);
            this.panellabel.Location = new System.Drawing.Point(1, 0);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(416, 67);
            this.panellabel.TabIndex = 21;
            this.panellabel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập thông tin dịch vụ";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên dịch vụ:";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giá tiền:";
            this.label4.UseWaitCursor = true;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(121, 109);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(261, 26);
            this.txtTenDV.TabIndex = 29;
            this.txtTenDV.UseWaitCursor = true;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(121, 168);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(261, 26);
            this.txtGiaDV.TabIndex = 30;
            this.txtGiaDV.UseWaitCursor = true;
            // 
            // butt_confirm
            // 
            this.butt_confirm.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butt_confirm.Location = new System.Drawing.Point(250, 249);
            this.butt_confirm.Name = "butt_confirm";
            this.butt_confirm.Size = new System.Drawing.Size(132, 34);
            this.butt_confirm.TabIndex = 34;
            this.butt_confirm.Text = "Xác nhận";
            this.butt_confirm.UseVisualStyleBackColor = false;
            this.butt_confirm.UseWaitCursor = true;
            this.butt_confirm.Click += new System.EventHandler(this.butt_confirm_Click);
            // 
            // FormAdmin_AddDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 329);
            this.Controls.Add(this.butt_confirm);
            this.Controls.Add(this.txtGiaDV);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_AddDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm dịch vụ";
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Button butt_confirm;
    }
}
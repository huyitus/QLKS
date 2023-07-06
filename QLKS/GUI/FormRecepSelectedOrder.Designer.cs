
namespace QLKS.GUI
{
    partial class FormRecepSelectedOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaNhan = new System.Windows.Forms.Button();
            this.btnDoanKhach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(163, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÌNH THỨC ĐĂNG KÝ";
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaNhan.Location = new System.Drawing.Point(40, 113);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(212, 36);
            this.btnCaNhan.TabIndex = 1;
            this.btnCaNhan.Text = "Cá nhân";
            this.btnCaNhan.UseVisualStyleBackColor = true;
            this.btnCaNhan.Click += new System.EventHandler(this.btnCaNhan_Click);
            // 
            // btnDoanKhach
            // 
            this.btnDoanKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanKhach.Location = new System.Drawing.Point(287, 113);
            this.btnDoanKhach.Name = "btnDoanKhach";
            this.btnDoanKhach.Size = new System.Drawing.Size(212, 36);
            this.btnDoanKhach.TabIndex = 2;
            this.btnDoanKhach.Text = "Đoàn khách";
            this.btnDoanKhach.UseVisualStyleBackColor = true;
            this.btnDoanKhach.Click += new System.EventHandler(this.btnDoanKhach_Click);
            // 
            // FormRecepSelectedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 191);
            this.Controls.Add(this.btnDoanKhach);
            this.Controls.Add(this.btnCaNhan);
            this.Controls.Add(this.label1);
            this.Name = "FormRecepSelectedOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecepSelectedOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRecepSelectedOrder_FormClosed);
            this.Load += new System.EventHandler(this.FormRecepSelectedOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaNhan;
        private System.Windows.Forms.Button btnDoanKhach;
    }
}
namespace QLKS.GUI
{
    partial class FormAdmin_AddRule
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
            this.txtND = new System.Windows.Forms.TextBox();
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
            this.panellabel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập thông tin quy định";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nội dung quy định:";
            // 
            // txtND
            // 
            this.txtND.Location = new System.Drawing.Point(172, 101);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(228, 26);
            this.txtND.TabIndex = 30;
            // 
            // butt_confirm
            // 
            this.butt_confirm.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butt_confirm.Location = new System.Drawing.Point(268, 217);
            this.butt_confirm.Name = "butt_confirm";
            this.butt_confirm.Size = new System.Drawing.Size(132, 34);
            this.butt_confirm.TabIndex = 35;
            this.butt_confirm.Text = "Xác nhận";
            this.butt_confirm.UseVisualStyleBackColor = false;
            this.butt_confirm.Click += new System.EventHandler(this.butt_confirm_Click);
            // 
            // FormAdmin_AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 278);
            this.Controls.Add(this.butt_confirm);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_AddRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm quy định";
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Button butt_confirm;
    }
}
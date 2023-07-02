﻿namespace QLKS.GUI
{
    partial class FormAdmin_DV
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
            this.lab_DV = new System.Windows.Forms.Label();
            this.dtg_DV = new System.Windows.Forms.DataGridView();
            this.butt_Add = new System.Windows.Forms.Button();
            this.butt_Del = new System.Windows.Forms.Button();
            this.butt_Fix = new System.Windows.Forms.Button();
            this.panellabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // panellabel
            // 
            this.panellabel.BackColor = System.Drawing.Color.DarkCyan;
            this.panellabel.Controls.Add(this.lab_DV);
            this.panellabel.Location = new System.Drawing.Point(3, 1);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(806, 67);
            this.panellabel.TabIndex = 21;
            // 
            // lab_DV
            // 
            this.lab_DV.AutoSize = true;
            this.lab_DV.BackColor = System.Drawing.Color.DarkCyan;
            this.lab_DV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DV.ForeColor = System.Drawing.Color.White;
            this.lab_DV.Location = new System.Drawing.Point(240, 17);
            this.lab_DV.Name = "lab_DV";
            this.lab_DV.Size = new System.Drawing.Size(309, 32);
            this.lab_DV.TabIndex = 1;
            this.lab_DV.Text = "DỊCH VỤ KHÁCH SẠN";
            this.lab_DV.Click += new System.EventHandler(this.lab_QD_Click);
            // 
            // dtg_DV
            // 
            this.dtg_DV.BackgroundColor = System.Drawing.Color.White;
            this.dtg_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DV.Location = new System.Drawing.Point(33, 88);
            this.dtg_DV.Name = "dtg_DV";
            this.dtg_DV.RowHeadersWidth = 62;
            this.dtg_DV.RowTemplate.Height = 28;
            this.dtg_DV.Size = new System.Drawing.Size(743, 255);
            this.dtg_DV.TabIndex = 22;
            // 
            // butt_Add
            // 
            this.butt_Add.BackColor = System.Drawing.Color.DarkTurquoise;
            this.butt_Add.Location = new System.Drawing.Point(685, 363);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(91, 34);
            this.butt_Add.TabIndex = 23;
            this.butt_Add.Text = "Thêm";
            this.butt_Add.UseVisualStyleBackColor = false;
            // 
            // butt_Del
            // 
            this.butt_Del.BackColor = System.Drawing.Color.LightCoral;
            this.butt_Del.Location = new System.Drawing.Point(572, 363);
            this.butt_Del.Name = "butt_Del";
            this.butt_Del.Size = new System.Drawing.Size(90, 34);
            this.butt_Del.TabIndex = 24;
            this.butt_Del.Text = "Xóa";
            this.butt_Del.UseVisualStyleBackColor = false;
            // 
            // butt_Fix
            // 
            this.butt_Fix.BackColor = System.Drawing.Color.Moccasin;
            this.butt_Fix.Location = new System.Drawing.Point(462, 363);
            this.butt_Fix.Name = "butt_Fix";
            this.butt_Fix.Size = new System.Drawing.Size(90, 34);
            this.butt_Fix.TabIndex = 25;
            this.butt_Fix.Text = "Sửa";
            this.butt_Fix.UseVisualStyleBackColor = false;
            // 
            // FormAdmin_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 409);
            this.Controls.Add(this.butt_Fix);
            this.Controls.Add(this.butt_Del);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.dtg_DV);
            this.Controls.Add(this.panellabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_DV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ khách sạn";
            this.Load += new System.EventHandler(this.FormAdmin_DV_Load);
            this.panellabel.ResumeLayout(false);
            this.panellabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellabel;
        private System.Windows.Forms.Label lab_DV;
        private System.Windows.Forms.DataGridView dtg_DV;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.Button butt_Del;
        private System.Windows.Forms.Button butt_Fix;
    }
}